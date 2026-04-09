using System.Collections.Generic;

namespace LuisNamini_Sql_git
{
    public interface IModel
    {
        List<Workshop> alleWorkshops();
        void insertWorkshop(Workshop w);
    }
}