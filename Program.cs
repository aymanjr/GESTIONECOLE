using GESTIONECOLE.FORMS;
using System;
using System.Windows.Forms;

namespace GESTIONECOLE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new THEMAINFORM());
        }
    }
}
