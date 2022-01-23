using System;

using AnimeList.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

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

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            await ViewModel.LoadDataAsync();
        }
    }
}
