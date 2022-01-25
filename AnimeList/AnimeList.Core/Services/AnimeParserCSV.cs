using AnimeList.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;

namespace AnimeList.Core.Services
{
    public class AnimeParserCSV : AnimeParser
    {
        private string sPath { get; set; }
        public event EventHandler<int> Loaded;
        AnimeParserCSV(string path)
        {
            sPath = path;
        }


        public Task<IEnumerable<Anime>> getAnimes()
        {
            throw new NotImplementedException();
        }

        public void setFile(StorageFile file)
        {
            throw new NotImplementedException();
        }
    }
}
