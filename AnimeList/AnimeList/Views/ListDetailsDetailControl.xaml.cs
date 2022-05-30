using System;

using AnimeList.Core.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using System.Diagnostics;


using HtmlAgilityPack;
using System.Net.Http;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

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

        struct imageRequest
        {
            public int status;
            public string message;
        }
        private static async Task<imageRequest> getImageFromWeb(string uri)
        {

            imageRequest result; 
            const string imageNode = "//td/div/div/a/img";
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(uri.ToString());
                    HttpContent content = response.Content;
                    HtmlDocument document = new HtmlDocument();
                    document.LoadHtml(await content.ReadAsStringAsync());
                    // Get img
                    var image = document.DocumentNode.SelectSingleNode(imageNode);
                    result.message = image.GetDataAttribute("src").Value;
                    Debug.WriteLine(result.message);
                    result.status = 200;
                }
                catch (Exception error)
                {
                    result.message = error.Message;
                    result.status = 500;
                    return result;
                }
            }
            return result;
        }
        private static async void OnListMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ListDetailsDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
            var animes = control.ListMenuItem;


            //TODO: scrap control.listMenuItem.NameHyperLink --> .leftside img --> src ou data-src
            var response = await getImageFromWeb(animes.NameHyperlink);
            if(response.status == 200)
            {
                control.animeImg.Source = new BitmapImage( new Uri(response.message));
                control.animeImg.Visibility = Visibility.Visible;
            }
            else
                control.animeImg.Visibility = Visibility.Collapsed;

            control.Title.Content = animes.Name;
            control.Title.NavigateUri = new Uri(animes.NameHyperlink);
        }
    }
}
