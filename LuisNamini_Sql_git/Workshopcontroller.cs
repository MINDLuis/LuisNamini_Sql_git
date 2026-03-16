using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuisNamini_Sql_git
{
    public class WorkshopController
    {
        private WorkshopModel model;

        public WorkshopController()
        {
            model = new WorkshopModel(this);
        }

        public void WorkshopSpeichern(int nr, string titel, int kosten, string beschreibung,
                                      string voraussetzungen, int teilnehmerMin, int teilnehmerMax,
                                      string schwerpunkt)
        {
            Workshop w = new Workshop()
            {
                Nr = nr,
                Titel = titel,
                Kosten = kosten,
                Beschreibung = beschreibung,
                Voraussetzungen = voraussetzungen,
                TeilnehmerMin = teilnehmerMin,
                TeilnehmerMax = teilnehmerMax,
                Schwerpunkt = schwerpunkt
            };

            model.InsertWorkshop(w);
        }

        public System.Collections.Generic.List<Workshop> LadeWorkshops()
        {
            return model.GetWorkshops();
        }
    }
}