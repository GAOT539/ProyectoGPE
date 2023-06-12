using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSGBD_MySQL.Forms
{
    public partial class Form_Usuarios_Privilegios : Form
    {
        bool isDarkModeEnabled;
        public Form_Usuarios_Privilegios(bool isDarkModeEnabled)
        {
            InitializeComponent();
            this.isDarkModeEnabled = isDarkModeEnabled;
            SetTheme();
        }

        private Color originalBackgroundColor;
        private Color originalTextColor;
        private Color darkBackgroundColor = Color.FromArgb(30, 30, 30);
        private Color darkTextColor = Color.White;
        private void SetTheme()
        {
            if (isDarkModeEnabled)
            {

                // Cambiar a modo oscuro
                originalBackgroundColor = BackColor;
                originalTextColor = ForeColor;
                BackColor = darkBackgroundColor;
                ForeColor = darkTextColor;
                // Establecer los colores oscuros para otros controles según sea necesario

                tabControl1.BackColor = Color.FromArgb(30, 30, 30);

                // Ajustar el color de las pestañas (TabPages) en el TabControl
                foreach (TabPage tabPage in tabControl1.TabPages)
                {
                    tabPage.BackColor = tabControl1.BackColor;
                    tabPage.ForeColor = Color.Black; // Color de fuente blanco para mejorar la legibilidad
                }

                // Ajustar el color de fuente del groupBox1-2
                groupBox1.ForeColor = Color.White;
                groupBox2.ForeColor = Color.White;

                button_Add_Account.ForeColor = darkTextColor;
                button_Add_Account.BackColor = darkBackgroundColor;

                button_Delete.ForeColor = darkTextColor;
                button_Delete.BackColor = darkBackgroundColor;

                button_Refresh.ForeColor = darkTextColor;
                button_Refresh.BackColor = darkBackgroundColor; 

                button_Revert.ForeColor = darkTextColor;
                button_Revert.BackColor = darkBackgroundColor;

                button_Apply.ForeColor = darkTextColor;
                button_Apply.BackColor = darkBackgroundColor;

            }
            else
            {
                // Cambiar a modo claro
                BackColor = originalBackgroundColor;
                ForeColor = originalTextColor;
                // Restablecer los colores claros para otros controles según sea necesario

                tabControl1.BackColor = SystemColors.Control;

                // Restaurar el color de las pestañas (TabPages) en el TabControl al color original
                foreach (TabPage tabPage in tabControl1.TabPages)
                {
                    tabPage.BackColor = tabControl1.BackColor;
                    tabPage.ForeColor = SystemColors.ControlText; // Restaurar el color de fuente original
                }

                // Restaurar el color de fuente original del groupBox1-2
                groupBox1.ForeColor = SystemColors.ControlText;
                groupBox2.ForeColor = SystemColors.ControlText;


                button_Add_Account.ForeColor = originalTextColor;
                button_Add_Account.BackColor = originalBackgroundColor;

                button_Delete.ForeColor = originalTextColor;
                button_Delete.BackColor = originalBackgroundColor;

                button_Refresh.ForeColor = originalTextColor;
                button_Refresh.BackColor = originalBackgroundColor;

                button_Revert.ForeColor = originalTextColor;
                button_Revert.BackColor = originalBackgroundColor;

                button_Apply.ForeColor = originalTextColor;
                button_Apply.BackColor = originalBackgroundColor;
            }
        }
    }
}
