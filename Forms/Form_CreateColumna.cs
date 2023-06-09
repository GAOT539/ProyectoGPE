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
    public partial class Form_CreateColumna : Form
    {
        public Form_CreateColumna()
        {
            InitializeComponent();
        }

        private void Form_CreateColumna_Load(object sender, EventArgs e)
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
                    List<string> tiposDatos_Columna = new List<string>()
                    {
                        "INT",
                        "BIGINT",
                        "FLOAT",
                        "DOUBLE",
                        "DECIMAL",
                        "DATE",
                        "TIME",
                        "DATETIME",
                        "TIMESTAMP",
                        "CHAR",
                        "VARCHAR (50)",
                        "TEXT",
                        "BOOL",
                        "BOOLEAN",
                        "BINARY",
                        "VARBINARY",
                        "BLOB"
                    };

                    comboBox_TiposDatos.DataSource = tiposDatos_Columna;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_Ejecutar_Click(object sender, EventArgs e)
        {
            string cadenaConexion = "Database=" + comboBox_BasesDatos.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();
                    string sqlQuery = "ALTER TABLE " + MySqlHelper.EscapeString(textBox_Nombre.Text) + " ADD " + MySqlHelper.EscapeString(textBox_Primaria.Text) + " " + MySqlHelper.EscapeString(comboBox_TiposDatos.Text) + ";";
                    //añadir checkbox notnull null
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Columna creada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
