using AnimeList.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.IO;

namespace AnimeList.Core.Services
{
    public class AnimeParserCSV : AnimeParser
    {
        private string sPath { get; set; }
        AnimeParserCSV(string path)
        {
            sPath = path;
        }
        public ObservableCollection<Anime> getAnimes()
        {
            ObservableCollection<Anime> animes = new ObservableCollection<Anime>();
            if (File.Exists(sPath))
            {
                StreamReader reader = new StreamReader(sPath);
                int debug_count = 0;
                string line;
                while((line = reader.ReadLine()) != null)
                {
                  string[] elements =  line.Split(';');


                  foreach (var element in elements )
                  {
                      
                  }

                }
            }  

            return animes;
        }
    }
}
