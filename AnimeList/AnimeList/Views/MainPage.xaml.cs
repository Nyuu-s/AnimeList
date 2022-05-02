using System;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.System;
using AnimeList.ViewModels;
using AnimeList.Services;
using System.IO;

using Windows.UI.Xaml.Controls;
using AnimeList.Core.Services;

namespace AnimeList.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
            ViewModel.DataLoaded += ProgressBar_loading_data;
            
        }

        

        private async void AddFile_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = PickerLocationId.ComputerFolder;
            picker.FileTypeFilter.Add(".xlsx");
            StorageFile file = await picker.PickSingleFileAsync();

            if (file != null)
            {
                //did not work, because a FileInfo need to be created but permisson given to StorageFile
                Windows.Storage.AccessCache.StorageApplicationPermissions.FutureAccessList.Add(file);
                //temp fix : copy file into app directory for permissions, parse data, delete copied file
                StorageFile copied;

                AddFile_Textbox.Text = file.Name;
                ProgressBar_loading_data(this, 10);
                //if copied file already exist use it else paste it
                if (await storageFolder.TryGetItemAsync(file.Name) != null)
                {
                    copied = await storageFolder.GetFileAsync(file.Name);
                }
                else
                {
                    copied = await file.CopyAsync(storageFolder);
                }
                
                await ViewModel.loadDataAsynch(copied);


                await copied.DeleteAsync();
                await AnimeGridViewModel.GetAllAnimesAsynch();

            }
        }

        private void ProgressBar_loading_data(object sender, int e)
        {
            this.DataProgressBar.Value = e;
        }

        private void AddFile_Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


    }
}
