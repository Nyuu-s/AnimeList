using System.Collections.ObjectModel;
using AnimeList.Core.Models;

namespace AnimeList.Core.Services
{
    
    public interface AnimeParser
    { 
        ObservableCollection<Anime> getAnimes();
    }
}