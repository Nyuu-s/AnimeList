using System;
using System.Diagnostics;
using AnimeList.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AnimeList.Views
{
    public sealed partial class ListDetailsPage : Page
    {
        public ListDetailsViewModel ViewModel { get; } = new ListDetailsViewModel();

        public ListDetailsPage()
        {
            InitializeComponent();
            Loaded += ListDetailsPage_Loaded;
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
            await ViewModel.LoadDataAsync(ListDetailsViewControl.ViewState);
            if (e.Parameter != null)
            {
                Debug.WriteLine(ViewModel.AnimesItems.Count);
                ViewModel.Selected = ViewModel.AnimesItems[(int)e.Parameter];
            }
               
            
        }
        private async void ListDetailsPage_Loaded(object sender, RoutedEventArgs e)
        {
            //await ViewModel.LoadDataAsync(ListDetailsViewControl.ViewState);
           
        }
    }
}
