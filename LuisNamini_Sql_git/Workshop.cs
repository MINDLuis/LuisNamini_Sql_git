using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuisNamini_Sql_git
{
    public class Workshop
    {
        public int WorkshopID { get; set; }
        public int Nr { get; set; }
        public string Titel { get; set; }
        public int Kosten { get; set; }
        public string Beschreibung { get; set; }
        public string Voraussetzungen { get; set; }
        public int TeilnehmerMin { get; set; }
        public int TeilnehmerMax { get; set; }
        public string Schwerpunkt { get; set; }
    }
}