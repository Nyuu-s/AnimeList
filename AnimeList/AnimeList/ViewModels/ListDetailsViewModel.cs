using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using AnimeList.Core.Models;
using AnimeList.Core.Services;

using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Uwp.UI.Controls;

namespace AnimeList.ViewModels
{
    public class ListDetailsViewModel : ObservableObject
    {
        private Anime _selected;
        public static ObservableCollection<Anime> AnimeItemsCache = AnimeGridViewModel.Source1Cache;
        public Anime Selected
        {
            get { return _selected; }
            set { SetProperty(ref _selected, value); }
        }

        public ObservableCollection<Anime> AnimesItems { get; private set; } = new ObservableCollection<Anime>();

        public ListDetailsViewModel()
        {
        }

        public async Task LoadDataAsync(ListDetailsViewState viewState)
        {
            if (AnimeItemsCache.Count > 0)
            {
                Selected = AnimeItemsCache.First();
                AnimesItems = AnimeItemsCache;
                return;
            }

            AnimesItems.Clear();
           
                var data = await ViewModels.AnimeGridViewModel.GetAllAnimesAsynch();

                foreach (var item in data)
                {
                    AnimesItems.Add(item);
                    AnimeItemsCache.Add(item);
                }
                

                if (viewState == ListDetailsViewState.Both)
                {
                    Selected = AnimesItems.First();
                }
            
                return;
        }
    }
}
