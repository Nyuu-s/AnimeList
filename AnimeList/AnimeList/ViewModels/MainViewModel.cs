using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AnimeList.Core.Models;
using AnimeList.Core.Services;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace AnimeList.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private ObservableCollection<Anime> source;
        public MainViewModel()
        {
        }

        public void loadDataAsynch(string path)
        {
            AnimeParser parser = new AnimeParserXLSL(path);
           source = parser.getAnimes();
        }
    }
}
