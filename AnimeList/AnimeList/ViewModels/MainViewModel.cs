using System;
using System.Collections.ObjectModel;
using System.IO;
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
            var data = await parser.getAnimes();
            foreach (var item in data)
            {
                source.Add(item);
            }
        }

        private void Parser_Data_Loaded(object sender, int e)
        {

            DataLoaded(this, e);
        }
    }
}
