using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSGBD_MySQL.Forms
{
    public partial class Form_Login : Form
    {
        private bool isDarkModeEnabled;
        public Form_Login(bool isDarkModeEnabled)
        {
            InitializeComponent();
            textBox_Password.UseSystemPasswordChar = true; // Oculta la contraseña
            this.MaximizeBox = false; // Bloquea la maximización del formulario
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Bloquea el cambio de tamaño del formulario
            this.isDarkModeEnabled = isDarkModeEnabled;
            SetTheme();
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = !checkBox_Password.Checked; // Muestra u oculta la contraseña según el estado del checkbox
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        private void button_TestConnection_Click(object sender, EventArgs e)
        {
            // Obtiene los valores de los campos de texto
            string servidor = textBox_Hostname.Text;
            string puerto = textBox_Port.Text;
            string usuario = textBox_Username.Text;
            string password = textBox_Password.Text;
            string bd = textBox_NameBD.Text;

            // Crea la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; Port=" + puerto + "; User Id=" +
                usuario + "; Password=" + password + "";

            // Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

            // Agrega un bloque try-catch para capturar posibles errores de conexión o sintaxis
            try
            {
                conexionBD.Open(); // Abre la conexión
                MessageBox.Show("¡Conexión exitosa!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information); // Muestra un mensaje de éxito en un cuadro de diálogo
            }
            catch (MySqlException er)
            {
                MessageBox.Show("Se produjo un error:\n\n" + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Si hay un error, muestra el mensaje en un cuadro de diálogo
            }
            finally
            {
                conexionBD.Close(); // Cierra la conexión a MySQL
            }
        }
        private void button_Connection_Control_Click(object sender, EventArgs e)
        {
            // Obtiene los valores de los campos de texto
            string servidor = textBox_Hostname.Text;
            string puerto = textBox_Port.Text;
            string usuario = textBox_Username.Text;
            string password = textBox_Password.Text;
            string bd = textBox_NameBD.Text;
            string nombreConexion = comboBox_ConnectionName.Text;

            cAux.datosConexion(servidor, puerto, usuario, password, bd, nombreConexion);

            // Asigna el valor de la cadena de conexión a la propiedad CadenaConexion de cAux.cs
            cAux.CadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; Port=" + puerto + "; User Id=" +
                usuario + "; Password=" + password + ";";
            string cadenaConexion = cAux.CadenaConexion;

            // Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

            // Agrega un bloque try-catch para capturar posibles errores de conexión o sintaxis
            try
            {
                conexionBD.Open(); // Abre la conexión

                // Crea una instancia del formulario Form_BD
                Forms.Form_BD form_BD = new Forms.Form_BD(isDarkModeEnabled);
                form_BD.Show();
                form_BD.FormClosed += cAux.cerrarFormulario;
                this.Hide();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Se produjo un error:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Si hay un error, muestra el mensaje en un cuadro de diálogo
            }
            finally
            {
                conexionBD.Close(); // Cierra la conexión a MySQL
            }
        }
        private void button_Connection_Click(object sender, EventArgs e)
        {

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

                // Ajustar el color de fondo del TabControl
                tabControl1.BackColor = Color.DarkGray;

                // Ajustar el color de las pestañas (TabPages) en el TabControl
                foreach (TabPage tabPage in tabControl1.TabPages)
                {
                    tabPage.BackColor = tabControl1.BackColor;
                    tabPage.ForeColor = Color.Black; // Color de fuente negro para mejorar la legibilidad
                }

                button_Exit.BackColor = darkBackgroundColor;
                button_Exit.ForeColor = darkTextColor;
                button_TestConnection.BackColor = darkBackgroundColor;
                button_TestConnection.ForeColor = darkTextColor;
                button_Connection.BackColor = darkBackgroundColor;
                button_Connection.ForeColor = darkTextColor;

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
                button_Exit.BackColor = originalBackgroundColor;
                button_Exit.ForeColor = originalTextColor;
                button_TestConnection.BackColor = originalBackgroundColor;
                button_TestConnection.ForeColor = originalTextColor;
                button_Connection.BackColor = originalBackgroundColor;
                button_Connection.ForeColor = originalTextColor;

            }
        }

    }
}
