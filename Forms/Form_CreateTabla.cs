using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSGBD_MySQL.Forms
{
    public partial class Form_CreateTabla : Form
    {
        public Form_CreateTabla()
        {
            InitializeComponent();
        }

        private void Form_CreateTabla_Load(object sender, EventArgs e)
        {
            string cadenaConexion = "Database=mysql; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    // Obtener las bases de datos existentes
                    string sqlQueryBasesDatos = "SHOW DATABASES";
                    using (MySqlCommand commandBasesDatos = new MySqlCommand(sqlQueryBasesDatos, connection))
                    {
                        using (MySqlDataReader readerBasesDatos = commandBasesDatos.ExecuteReader())
                        {
                            while (readerBasesDatos.Read())
                            {
                                string nombreBaseDatos = readerBasesDatos.GetString(0);
                                comboBox_BasesDatos.Items.Add(nombreBaseDatos);
                            }
                        }
                    }

                    // Obtener los tipos de datos
                    List<string> tiposDatos = new List<string>()
                    {
                        "INT",
                        "BIGINT",
                        "SMALLINT",
                        "TINYINT",
                        "CHAR",
                        "VARCHAR (50)"
                    };

                    comboBox_TiposDatos.DataSource = tiposDatos;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadenaConexion = "Database="+ comboBox_BasesDatos.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    string sqlQuery = "CREATE TABLE "+ textBox_Nombre.Text + " ("+textBox_Primaria.Text + " " + comboBox_TiposDatos.Text + " PRIMARY KEY)";//añadir checkbox AUTO_INCREMENT
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Tabla creada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
