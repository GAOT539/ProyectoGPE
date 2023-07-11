using System;
using System.Windows.Forms;

namespace ProyectoSGBD_MySQL
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Forms.Form_Dinamico_BD_COL_TAB());
            Application.Run(new Forms.Form_Principal());
            //Application.Run(new Forms.Form_ChatGPT());
        }
    }
}
