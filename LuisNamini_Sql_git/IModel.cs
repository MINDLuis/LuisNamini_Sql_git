namespace LuisNamini_Sql_git
{
    internal interface IModel
    {
        IView View { set; }
        IController Controller { set; }
    }
}