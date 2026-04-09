using System;
using System.Windows.Forms;

namespace LuisNamini_Sql_git
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IModel model = new Model();
            IController controller = new Controller();
            View view = new View(controller);

            controller.setModel(model);
            controller.setView(view);

            
            Application.Run(view);
        }
    }
}