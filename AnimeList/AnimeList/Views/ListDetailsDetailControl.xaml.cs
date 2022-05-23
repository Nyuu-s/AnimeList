using System;

using AnimeList.Core.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using System.Diagnostics;

namespace AnimeList.Views
{
   
    public sealed partial class ListDetailsDetailControl : UserControl
    {
        
        public Anime ListMenuItem
        {
           
            get { return GetValue(ListMenuItemProperty) as Anime; }
            set { SetValue(ListMenuItemProperty, value); }
        }
        
        public static readonly DependencyProperty ListMenuItemProperty = DependencyProperty.Register("ListMenuItem", typeof(Anime), typeof(ListDetailsDetailControl), new PropertyMetadata(null, OnListMenuItemPropertyChanged));
        

    
        public ListDetailsDetailControl()
        {
            InitializeComponent();
            //webView1.ContentLoading += webView1_ContentLoading;
            //webView1.NavigationCompleted += webView1_NavigationCompleted;


        }

        //private void webView1_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        //{
        //    if (args.IsSuccess == true)
        //    {
        //        statusTextBlock.Visibility = Visibility.Collapsed;
        //    }
        //}
        //private void webView1_ContentLoading(WebView sender, WebViewContentLoadingEventArgs args)
        //{
        //    // Show status.
        //    if (args.Uri != null)
        //    {
        //        statusTextBlock.Text = "Loading content for " + args.Uri.ToString();
        //    }
        //}

        private static async void OnListMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ListDetailsDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
            var animes = control.ListMenuItem;
            control.webView1.Navigate(new Uri(animes.NameHyperlink));
            var result = new Uri(animes.NameHyperlink);
            Debug.WriteLine(result);

            //control.testImg.Source = new BitmapImage( new Uri(""));

            control.Title.Content = animes.Name;
            control.Title.NavigateUri = new Uri(animes.NameHyperlink);
        }
    }
}
