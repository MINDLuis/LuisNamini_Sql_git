using System.Collections.Generic;

namespace LuisNamini_Sql_git
{
    public interface IView
    {
        void workshopsAnzeigen(List<Workshop> liste);
        void meldung(string text);

        int nrEinlesen();
        string titelEinlesen();
        int kostenEinlesen();
        string beschreibungEinlesen();
        string voraussetzungenEinlesen();
        int teilnehmerMinEinlesen();
        int teilnehmerMaxEinlesen();
        string schwerpunktEinlesen();
    }
}