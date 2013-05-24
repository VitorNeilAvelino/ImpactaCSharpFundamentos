using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Impacta.Capitulo03.Medias
{
    static class Programa
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new principalForm());
        }
    }
}
