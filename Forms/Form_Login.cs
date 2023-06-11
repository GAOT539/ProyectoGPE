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

        public Form_Login()
        {
            InitializeComponent();
            textBox_Password.UseSystemPasswordChar = true; // Oculta la contraseña
            this.MaximizeBox = false; // Bloquea la maximización del formulario
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Bloquea el cambio de tamaño del formulario
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
                Forms.Form_BD form_BD = new Forms.Form_BD();
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

    }
}
