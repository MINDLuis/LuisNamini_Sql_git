using LuisNamini_Sql_git;

public interface IController
{
    void setView(IView view);
    void setModel(IModel model);

    void ladeWorkshops();
    void workshopErstellen(string titel);
}