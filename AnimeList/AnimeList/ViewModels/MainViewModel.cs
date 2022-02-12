using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using AnimeList.Core.Models;
using AnimeList.Core.Services;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Windows.Storage;

namespace AnimeList.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private ObservableCollection<Anime> source { get; } = new ObservableCollection<Anime>();
        public event EventHandler<int> DataLoaded;
        AnimeParser parser = new AnimeParserXLSL();

        public MainViewModel()
        {
            parser.Loaded += Parser_Data_Loaded;
        }

        public async Task loadDataAsynch(StorageFile file)
        {

            parser.setFile(file);
            var data = parser.getAnimes();
            foreach (var item in data)
            {
                source.Add(item);
            }

            //serialize source into Local
            serializeAnimesAsync(source);
        }

        private async void serializeAnimesAsync(ObservableCollection<Anime> data)
        {
            MemoryStream sessionData = new MemoryStream();
            DataContractSerializer serializer = new DataContractSerializer(typeof(ObservableCollection<Anime>));
            serializer.WriteObject(sessionData, data);
            StorageFile dataFile = await ApplicationData.Current.LocalFolder.CreateFileAsync("animesData", CreationCollisionOption.ReplaceExisting);

            using (Stream fileStream = await dataFile.OpenStreamForWriteAsync())
            {
                sessionData.Seek(0, SeekOrigin.Begin);
                await sessionData.CopyToAsync(fileStream);
                await fileStream.FlushAsync();
            }
        }
        private void Parser_Data_Loaded(object sender, int e)
        {

            DataLoaded(this, e);
        }
    }
}
