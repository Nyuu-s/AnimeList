using AnimeList.Core.Models;
using System;
using System.Linq;
using OfficeOpenXml;
using Windows.Storage;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AnimeList.Core.Services
{
    public class AnimeParserXLSL : AnimeParser
    {
        public StorageFile sFile { get; set; }
        public int loadingStatus;
        public event EventHandler<int> Loaded;

        protected virtual void onLoaded()
        {
            EventHandler<int> handler = Loaded;
            if(handler != null)
            {
               
                handler(this, loadingStatus);
                
            }
        }

        public AnimeParserXLSL(StorageFile file)
        {
            sFile = file;
            loadingStatus = 0;
        }

        public AnimeParserXLSL()
        {
            loadingStatus = 0;
        }



        public async Task<Anime> GetAnime(int row, ExcelWorksheet worksheet)
        {

          
               
            int col = 1;
            var anime = new Anime();
            var nameHyperlink   = worksheet.Cells[row, col].Hyperlink;
            var Name            = worksheet.Cells[row, col++].Value;
            var Genre           = worksheet.Cells[row, col++].Value;
            var Type            = worksheet.Cells[row, col++].Value;
            var Year            = worksheet.Cells[row, col++].Value;
            var Language        = worksheet.Cells[row, col++].Value;
            var groupeHyperlink = worksheet.Cells[row, col].Hyperlink;
            var Groupe          = worksheet.Cells[row, col++].Value;
            var nbWatched       = worksheet.Cells[row, col++].Value;
            var nbDownloaded    = worksheet.Cells[row, col++].Value;
            var WatchState      = worksheet.Cells[row, col++].Value;
            var Dwn             = worksheet.Cells[row, col++].Value;
            var nbVotes         = worksheet.Cells[row, col++].Value;
            var nbSupport       = worksheet.Cells[row, col++].Value;
            var Media           = worksheet.Cells[row, col++].Value;
            var Resolution      = worksheet.Cells[row, col++].Value;
            var Cover           = worksheet.Cells[row, col++].Value;
            var Note            = worksheet.Cells[row, col++].Value;

            anime.NameHyperlink     = nameHyperlink != null ? nameHyperlink.ToString() : "";
            anime.GroupHyperlink    = groupeHyperlink != null ? groupeHyperlink.ToString() : "";
            anime.Name              = Name != null ? Name.ToString() : "";
            anime.Genre             = Genre != null ? Genre.ToString() : "";
            anime.Type              = Type != null ? Type.ToString() : "";
            anime.Language          = Language != null ? Language.ToString() : "";
            anime.Groupe            = Groupe != null ? Groupe.ToString() : "";
            anime.WatchState        = WatchState != null ? WatchState.ToString() : "";
            anime.Dwn               = Dwn != null ? Dwn.ToString() : "";
            anime.Media             = Media != null ? Media.ToString() : "";
            anime.Resolution        = Resolution != null ? Resolution.ToString() : "";
            anime.Cover             = Cover != null ? Cover.ToString() : "";
            anime.Note              = Note != null ? Note.ToString() : "";
            try { anime.Year = Int16.Parse(Year.ToString()); } catch (Exception e) { anime.Year = 0; };
            try { anime.nbWatched = Int16.Parse(nbWatched.ToString()); } catch (Exception e) { anime.nbWatched = 0; };
            try { anime.nbDownloaded = Int16.Parse(nbDownloaded.ToString()); } catch (Exception e) { anime.nbDownloaded = 0; };
            try { anime.nbVotes = Int16.Parse(nbVotes.ToString()); } catch (Exception e) { anime.nbVotes = 0; };
            try { anime.nbSupport = Int16.Parse(nbSupport.ToString()); } catch (Exception e) { anime.nbSupport = 0; };

            
            return anime;
            
        }

  

        private ICollection<Anime> AllAnimes()
        {
            List<Anime> animes = new List<Anime>();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;


            using (var package = new ExcelPackage(sFile.Path))
            {
                var worksheet = package.Workbook.Worksheets.First();
                var totalRows = worksheet.Dimension.End.Row;



                for (int i = 2; i < totalRows; i++)
                {
                    var anime =  GetAnime(i, worksheet);
                   // animes.Add(anime);
                    loadingStatus = (i / (totalRows - 2)) * 100;
                    onLoaded();
                    animes.Add(anime.Result);
                }

            }

            return animes;
        }

        public ICollection<Anime> getAnimes()
        {
            return AllAnimes();
        }
        
        public void setFile(StorageFile file)
        {
            sFile = file;
        }
    }
}
