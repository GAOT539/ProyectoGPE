using MySql.Data.MySqlClient;
using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using MySqlX.XDevAPI;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSGBD_MySQL.Forms
{
    public partial class Form_CreateBD : Form
    {
        public Form_CreateBD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlQuery = "CREATE DATABASE "+textBox_BD.Text;

            // Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database = mysql; Data Source = localhost; Port = 3306; User Id = root; Password = 2001;";

            // en caso de error descomentar MySqlConnection conexionBD = new MySqlConnection(cadenaConexion); 
            // Try-catch para capturar posibles errores de conexión o sintaxis.
            try
            {
                //Instancia para conexión a MySQL, recibe la cadena de conexión
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                MessageBox.Show("Ejecución Completa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox_BD.Text = "";
        }
    }
}

