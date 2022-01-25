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
        public string Groupe { get; set; }
        public int Year { get; set; }
        public string Language { get; set; }
        public int nbWatched { get; set; }
        public int nbDownloaded { get; set; }
        public string WatchState { get; set; }
        public string Dwn { get; set; } // to be confirmed
        public int nbVotes { get; set; }
        public int nbSupport { get; set; }
        public string Media { get; set; }
        public string Resolution { get; set; }
        public string Cover { get; set; }
        public string Note { get; set; }
        public string hyperlink { get; set; }




    }
}
