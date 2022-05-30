using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;

using AnimeList.Core.Models;
using AnimeList.Core.Services;

using Microsoft.Toolkit.Mvvm.ComponentModel;
using Windows.Storage;
using Windows.Storage.Streams;

namespace AnimeList.ViewModels
{
    public class AnimeGridViewModel : ObservableObject
    {
       // public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();
        public ObservableCollection<Anime> Source1 { get; set; } = new ObservableCollection<Anime>();
        public static ObservableCollection<Anime> Source1Cache;
        public event EventHandler Loaded;
        public AnimeGridViewModel()
        {
            
            this.Loaded += AnimeGridViewModel_Loaded;

        }


        private async void AnimeGridViewModel_Loaded(object sender, EventArgs e)
        {
            
            Source1 = await LoadAnimes();
            
        }

        public static async Task<ObservableCollection<Anime>> LoadAnimes()
        {
           
            return await Task.Run(() => { return Source1Cache; });
        }

        private static async Task<Boolean> PurgeLocalFilesDebug()
        {
            return await Task.Run(  async () =>
            {
                try
                {
                    var localfiles = await ApplicationData.Current.LocalFolder.GetFilesAsync();
                    foreach (var localfile in localfiles)
                    {
                        await localfile.DeleteAsync();
                    }
                    return true;
                }catch (Exception ex)
                {
                    return false;
                }
  
            });

        }
        public static async Task<ObservableCollection<Anime>> GetAllAnimesAsynch()
        {
           
            if (Source1Cache != null)
                return Source1Cache;

   

            StorageFile file;
            try
            {
                file = await ApplicationData.Current.LocalFolder.GetFileAsync("animesData");
                using (IInputStream inStream = await file.OpenSequentialReadAsync())
                {
                    var cpt = 0;
                    Source1Cache = new ObservableCollection<Anime>();
                    DataContractSerializer serializer = new DataContractSerializer(typeof(ObservableCollection<Anime>));
                    var animeData = (ObservableCollection<Anime>)serializer.ReadObject(inStream.AsStreamForRead());
                    foreach (var item in animeData)
                    {
                        item.ID = cpt++;
                        Source1Cache.Add(item);
                    }
                }
            }
            catch
            {
                await ApplicationData.Current.LocalFolder.CreateFileAsync("animesData", CreationCollisionOption.ReplaceExisting); // TODO replace to OpenIfExists
            }



            return Source1Cache;

        }
  

        public async Task LoadDataAsync()
        {

           Loaded?.Invoke(this, null);
          


        }
    }
}
