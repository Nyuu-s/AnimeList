using System;
using System.IO;
using AnimeList.Core.Models;
using AnimeList.ViewModels;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AnimeList.Views
{
    public sealed partial class AnimeGridPage : Page
    {
        public AnimeGridViewModel ViewModel { get; } = new AnimeGridViewModel();
        

        // TODO WTS: Change the grid as appropriate to your app, adjust the column definitions on AnimeGridPage.xaml.
        // For more details see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid
        public AnimeGridPage()
        {
            InitializeComponent();
        }

        private void MyMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var item = (sender as FrameworkElement).DataContext as Anime;
            Debug.WriteLine(item.Name);
            // Do things with your item.
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            await ViewModel.LoadDataAsync();
        }

        private void DataGrid_Sorting(object sender, Microsoft.Toolkit.Uwp.UI.Controls.DataGridColumnEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            var item = e.AddedItems[0] as Anime;
            var itemIndex = ViewModel.Source1.IndexOf(item);

            Frame.Navigate(typeof(ListDetailsPage), itemIndex);
        }
    }
}
