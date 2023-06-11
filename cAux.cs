using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSGBD_MySQL
{
    public class cAux
    {
        public static string CadenaConexion { get; set; }
        public static void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            // Cerrar completamente la aplicación
            Application.Exit();
        }
    }
}
