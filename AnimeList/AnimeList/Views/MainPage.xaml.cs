using System;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.System;
using AnimeList.ViewModels;
using AnimeList.Services;

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
        }

        

        private async void AddFile_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = PickerLocationId.ComputerFolder;
            picker.FileTypeFilter.Add(".xlsx");
            StorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                this.AddFile_Textbox.Text = file.Path;
                ViewModel.loadDataAsynch(file.Path);

            }
        }

        private void AddFile_Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
