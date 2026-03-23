namespace LuisNamini_Sql_git
{
    internal class Model : IModel
    {
        private IView view;
        private IController controller;

        IController IModel.Controller { set => controller=value; }
        IView IModel.View { set => view=value; }
    }
}