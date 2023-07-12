using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSGBD_MySQL
{
    public partial class Form_Fragmentacion : Form
    {
        public Form_Fragmentacion()
        {
            InitializeComponent();
        }

        private void Form_Fragmentacion_Load(object sender, EventArgs e)
        {
            // Establecer el tamaño predefinido del formulario
            this.Width = 1425; 
            this.Height = 685;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Bloquea el cambio de tamaño del formulario
            this.MaximizeBox = false; // Bloquea la maximización del formulario
            cargarDatos();
        }

        private void cargarDatos()
        {
            string cadenaConexion = "Database=mysql; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    // Obtener las bases de datos existentes
                    string sqlQueryBasesDatos = "SHOW DATABASES WHERE `Database` NOT LIKE '%\\_schema';\r\n";
                    //Limpia antes de añadir datos
                    comboBox_DataBaseFH.Items.Clear();

                    using (MySqlCommand commandBasesDatos = new MySqlCommand(sqlQueryBasesDatos, connection))
                    {
                        using (MySqlDataReader readerBasesDatos = commandBasesDatos.ExecuteReader())
                        {
                            while (readerBasesDatos.Read())
                            {
                                string nombreBaseDatos = readerBasesDatos.GetString(0);
                                comboBox_DataBaseFH.Items.Add(nombreBaseDatos);
                                comboBox_DataBaseFV.Items.Add(nombreBaseDatos);
                                comboBox_DataBaseFM.Items.Add(nombreBaseDatos);

                            }
                        }
                    }

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

                    // Obtener los tipos de datos
                    List<string> tiposDatos_Tabla = new List<string>()
                    {
                        "INT",
                        "CHAR",
                        "VARCHAR (50)",
                        "INT AUTO_INCREMENT"
                    };
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox_DataBase_TablaFH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosTabla_TablasFH();
        }
        private void cargarDatosTabla_TablasFH()
        {
            string cadenaConexion = "Database=" + comboBox_DataBaseFH.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    // Obtener las bases de datos existentes
                    string sqlQueryTabla = "SHOW TABLES FROM " + comboBox_DataBaseFH.Text + ";\r\n";
                    //Limpia antes de añadir datos
                    comboBox_TablaFH.Items.Clear();

                    using (MySqlCommand commandBasesDatos = new MySqlCommand(sqlQueryTabla, connection))
                    {
                        using (MySqlDataReader readerBasesDatos = commandBasesDatos.ExecuteReader())
                        {
                            while (readerBasesDatos.Read())
                            {
                                string nombreTablas = readerBasesDatos.GetString(0);
                                comboBox_TablaFH.Items.Add(nombreTablas);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_Añadir_Tabla_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_DataBase_TablaFV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosTabla_TablasFV();
        }

        private void cargarDatosTabla_TablasFV()
        {
            string cadenaConexion = "Database=" + comboBox_DataBaseFV.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    // Obtener las bases de datos existentes
                    string sqlQueryTabla = "SHOW TABLES FROM " + comboBox_DataBaseFV.Text + ";\r\n";
                    //Limpia antes de añadir datos
                    comboBox_TablaFV.Items.Clear();

                    using (MySqlCommand commandBasesDatos = new MySqlCommand(sqlQueryTabla, connection))
                    {
                        using (MySqlDataReader readerBasesDatos = commandBasesDatos.ExecuteReader())
                        {
                            while (readerBasesDatos.Read())
                            {
                                string nombreTablas = readerBasesDatos.GetString(0);
                                comboBox_TablaFV.Items.Add(nombreTablas);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_DataBase_TablaFM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosTabla_TablasFM();
        }
        private void cargarDatosTabla_TablasFM()
        {
            string cadenaConexion = "Database=" + comboBox_DataBaseFM.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    // Obtener las bases de datos existentes
                    string sqlQueryTabla = "SHOW TABLES FROM " + comboBox_DataBaseFM.Text + ";\r\n";
                    //Limpia antes de añadir datos
                    comboBox_TablaFM.Items.Clear();

                    using (MySqlCommand commandBasesDatos = new MySqlCommand(sqlQueryTabla, connection))
                    {
                        using (MySqlDataReader readerBasesDatos = commandBasesDatos.ExecuteReader())
                        {
                            while (readerBasesDatos.Read())
                            {
                                string nombreTablas = readerBasesDatos.GetString(0);
                                comboBox_TablaFM.Items.Add(nombreTablas);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void comboBox_Tabla_ColumnaFH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosDataGridViewFH();
            cargarDatosColumnasFH();
        }

        private void cargarDatosColumnasFH()
        {
            string cadenaConexion = "Database=" + comboBox_DataBaseFH.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    // Obtener las bases de datos existentes
                    string sqlQueryTabla = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '"+ comboBox_DataBaseFH.Text + "' AND TABLE_NAME = '"+ comboBox_TablaFH.Text + "';\r\n";
                    //Limpia antes de añadir datos
                    comboBox_ColumnaFH.Items.Clear();

                    using (MySqlCommand commandBasesDatos = new MySqlCommand(sqlQueryTabla, connection))
                    {
                        using (MySqlDataReader readerBasesDatos = commandBasesDatos.ExecuteReader())
                        {
                            while (readerBasesDatos.Read())
                            {
                                string nombreTablas = readerBasesDatos.GetString(0);
                                comboBox_ColumnaFH.Items.Add(nombreTablas);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDatosDataGridViewFH()
        {
            string cadenaConexion = "Database=" + comboBox_DataBaseFH.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();
                    // Cargar los datos de la tabla en el dataGridView_Muestra
                    string sqlQuery = "DESCRIBE " + comboBox_TablaFH.Text;
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView_CamposFH.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_Tabla_ColumnaFV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosDataGridViewFV();
            cargarDatosColumnasFV();
        }

        private void cargarDatosColumnasFV()
        {
            string cadenaConexion = "Database=" + comboBox_DataBaseFV.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    // Obtener las bases de datos existentes
                    string sqlQueryTabla = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" + comboBox_DataBaseFV.Text + "' AND TABLE_NAME = '" + comboBox_TablaFV.Text + "';\r\n";
                    //Limpia antes de añadir datos
                    comboBox_ColumnaFH.Items.Clear();

                    using (MySqlCommand commandBasesDatos = new MySqlCommand(sqlQueryTabla, connection))
                    {
                        using (MySqlDataReader readerBasesDatos = commandBasesDatos.ExecuteReader())
                        {
                            while (readerBasesDatos.Read())
                            {
                                string nombreTablas = readerBasesDatos.GetString(0);
                                comboBox_ColumnaFV.Items.Add(nombreTablas);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarDatosDataGridViewFV()
        {
            string cadenaConexion = "Database=" + comboBox_DataBaseFV.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();
                    // Cargar los datos de la tabla en el dataGridView_Muestra
                    string sqlQuery = "DESCRIBE " + comboBox_TablaFV.Text;
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView_CamposFV.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
