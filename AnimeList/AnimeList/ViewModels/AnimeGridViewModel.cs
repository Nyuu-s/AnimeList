using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using AnimeList.Core.Models;
using AnimeList.Core.Services;

using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace AnimeList.ViewModels
{
    public class AnimeGridViewModel : ObservableObject
    {
        public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

        public AnimeGridViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            Source.Clear();

            // Replace this with your actual data
            
            var data = await SampleDataService.GetGridDataAsync();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}
