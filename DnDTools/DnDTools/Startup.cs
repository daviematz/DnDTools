using DnDTools.Static_Classes;
using System;
using System.Windows.Forms;

namespace DnDTools
{
    static class Startup
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string containingFolderPath = Application.StartupPath;
            XMLEditor.InitializeFiles(containingFolderPath);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OpeningScreen());
        }
    }
}
