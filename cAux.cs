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
        public void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            // Cerrar completamente la aplicación
            Application.Exit();
        }
    }
}
