using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AnimeList.Core.Models;
using Windows.Storage;

namespace AnimeList.Core.Services
{
    
    public interface AnimeParser
    {
        event EventHandler<int> Loaded;
        Task<IEnumerable<Anime>> getAnimes();
        void setFile(StorageFile file);
    }
}