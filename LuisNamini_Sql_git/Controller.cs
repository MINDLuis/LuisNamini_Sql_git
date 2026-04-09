using LuisNamini_Sql_git;

public class Controller : IController
{
    private IView view;
    private IModel model;

    public void setView(IView view)
    {
        this.view = view;
    }

    public void setModel(IModel model)
    {
        this.model = model;
    }

    public void ladeWorkshops()
    {
        var liste = model.alleWorkshops();
        view.workshopsAnzeigen(liste);
    }

    public void workshopErstellen(string titel)
    {
        var w = new Workshop()
        {
            Nr = view.nrEinlesen(),
            Titel = titel,
            Kosten = view.kostenEinlesen(),
            Beschreibung = view.beschreibungEinlesen(),
            Voraussetzungen = view.voraussetzungenEinlesen(),
            TeilnehmerMin = view.teilnehmerMinEinlesen(),
            TeilnehmerMax = view.teilnehmerMaxEinlesen(),
            Schwerpunkt = view.schwerpunktEinlesen()
        };

        model.insertWorkshop(w);
        view.meldung("Workshop erstellt");
    }
}