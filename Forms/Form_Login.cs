using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ProyectoSGBD_MySQL.Forms
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            textPassword.UseSystemPasswordChar = true; //Ocultar contraseña
            this.MaximizeBox = false; //Bloquear Maximizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //Bloquear tamaño
        }
        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = !checkBoxPassword.Checked;
        }
        private void Form_Login_Load(object sender, EventArgs e)
        {
            //Ignorar
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String servidor = textHostname.Text;
            String puerto = textPort.Text;
            String usuario = textUsername.Text;
            String password = textPassword.Text;
            String bd = textNameBD.Text;

            //Crea la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; Port=" + puerto + "; User Id=" 
                + usuario + "; Password=" + password + "";


            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            try
            {
                conexionBD.Open(); //Abre la conexión
                MessageBox.Show("Conexión exitosa"); //Imprime en cuadro de dialogo el resultado
            }
            catch (MySqlException er)
            {
                MessageBox.Show("Error: " + er.Message); //Si existe un error aquí muestra el mensaje
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String servidor = textHostname.Text;
            String puerto = textPort.Text;
            String usuario = textUsername.Text;
            String password = textPassword.Text;
            String bd = textNameBD.Text;

            //Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; Port=" + puerto + "; User Id="
                + usuario + "; Password=" + password + ";";

            //Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

            //Agregamos try-catch para capturar posibles errores de conexión o sintaxis.
            try
            {
                conexionBD.Open(); //Abre la conexión.
               

                Forms.Form_BD form_BD = new Forms.Form_BD();
                AddOwnedForm(form_BD); //Establece una relación de propiedad entre formularios.
                form_BD.textBox_RecibeBD.Text = cadenaConexion; //Establecer text (cadenaConexion)
                
                cAux cAux = new cAux();
                form_BD.Show();
                form_BD.FormClosed += cAux.cerrarFormulario;
                this.Hide();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message); //Si existe un error aquí muestra el mensaje
            }
            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }
        }
    }
}
