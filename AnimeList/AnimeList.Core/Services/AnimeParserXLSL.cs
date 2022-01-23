using AnimeList.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using OfficeOpenXml;

namespace AnimeList.Core.Services
{
    public class AnimeParserXLSL : AnimeParser
    {
        public string sPath;
        public AnimeParserXLSL(string path)
        {
            sPath = path;
        }
        public ObservableCollection<Anime> getAnimes()
        {
            ObservableCollection<Anime> animes = new ObservableCollection<Anime>();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(new FileInfo(sPath) ))
            {
                var worksheet = package.Workbook.Worksheets.First();
              // var worksheet = package.Workbook.Worksheets["Anime v7"];
                var totalRows = worksheet.Dimension.End.Row;
                var totalCol = 12;
                Console.WriteLine(worksheet.Cells["B1"].Value.ToString());
                
            }
            return animes;
        }
    }
}
