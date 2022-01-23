using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeList.Core.Models
{
    public class Anime
    {

        public string Name { get; set; }
        public string Genre { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }
        public string Language { get; set; }
        public int nbWatched { get; set; }
        public int nbDownloaded { get; set; }
        public int WatchState { get; set; }
        public int Dwn { get; set; } // to be confirmed
        public int nbVotes { get; set; }
        public int nbSupport { get; set; }
        public string Media { get; set; }
        public int Resolution { get; set; }
        public bool Cover { get; set; }
        public string Note { get; set; }




    }
}
