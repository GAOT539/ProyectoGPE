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
            this.Height = 820;
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
            CrearFragmentacionH();
            MostrarTablasEnDataGridViewFH();
            LimpiarFH();
        }

        private void LimpiarFH()
        {
            comboBox_DataBaseFH.Text = "";
            comboBox_TablaFH.Text = "";
            comboBox_ColumnaFH.Text = "";
            comboBox_Separacion1FH.Text = "";
            comboBox_Separacion2FH.Text = "";
            textBox_NombreTabla1FH.Text = "";
            textBox_NombreTabla2FH.Text = "";
        }

        public void MostrarTablasEnDataGridViewFH()
        {
            try
            {
                // Obtener los valores de los campos de texto
                string databaseName = comboBox_DataBaseFH.Text;
                string newTableName1 = textBox_NombreTabla1FH.Text;
                string newTableName2 = textBox_NombreTabla2FH.Text;

                // Cadena de conexión a MySQL
                string connectionString = cAux.CadenaConexion;

                // Consulta para obtener los datos de la tabla 1
                string selectQuery1 = $"SELECT * FROM {databaseName}.{newTableName1}";

                // Consulta para obtener los datos de la tabla 2
                string selectQuery2 = $"SELECT * FROM {databaseName}.{newTableName2}";

                // Crear un DataTable para almacenar los datos de la tabla 1
                DataTable table1 = new DataTable();

                // Crear un DataTable para almacenar los datos de la tabla 2
                DataTable table2 = new DataTable();

                // Obtener los datos de la tabla 1
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlDataAdapter adapter1 = new MySqlDataAdapter(selectQuery1, connection))
                    {
                        adapter1.Fill(table1);
                    }

                    using (MySqlDataAdapter adapter2 = new MySqlDataAdapter(selectQuery2, connection))
                    {
                        adapter2.Fill(table2);
                    }

                    connection.Close();
                }

                // Mostrar los datos en los DataGridView
                dataGridView_CamposFH1.DataSource = table1;
                dataGridView_CamposFH2.DataSource = table2;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al mostrar los datos en los DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearFragmentacionH()
        {
            try
            {
                // Obtener los valores de los campos de texto
                string databaseName = comboBox_DataBaseFH.Text;
                string tableName = comboBox_TablaFH.Text;
                string columnName = comboBox_ColumnaFH.Text;
                string separationAttr1 = comboBox_Separacion1FH.Text;
                string separationAttr2 = comboBox_Separacion2FH.Text;
                string newTableName1 = textBox_NombreTabla1FH.Text;
                string newTableName2 = textBox_NombreTabla2FH.Text;

                // Cadena de conexión a MySQL
                // string connectionString = cAux.CadenaConexion;
                string cadenaConexion = "Database=" + comboBox_DataBaseFH.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

                // Consulta para crear la tabla 1 (Personas_M)
                string createTableQuery1 = $"CREATE TABLE {newTableName1} AS SELECT * FROM {databaseName}.{tableName} WHERE {columnName} = '{separationAttr1}'";

                // Consulta para crear la tabla 2 (Personas_F)
                string createTableQuery2 = $"CREATE TABLE {newTableName2} AS SELECT * FROM {databaseName}.{tableName} WHERE {columnName} = '{separationAttr2}'";

                // Ejecutar las consultas
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    // Crear tabla 1
                    using (MySqlCommand command1 = new MySqlCommand(createTableQuery1, connection))
                    {
                        command1.ExecuteNonQuery();
                    }

                    // Crear tabla 2
                    using (MySqlCommand command2 = new MySqlCommand(createTableQuery2, connection))
                    {
                        command2.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                MessageBox.Show("Tablas creadas exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al crear las tablas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
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

        private void comboBox_ColumnaFH_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosAtributosFH();
        }

        private void CargarDatosAtributosFH()
        {
            string cadenaConexion = "Database=" + comboBox_DataBaseFH.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    // Obtener las bases de datos existentes
                    string sqlQueryTabla = $"SELECT DISTINCT {comboBox_ColumnaFH.Text} FROM {comboBox_DataBaseFH.Text}.{comboBox_TablaFH.Text};";
                    //Limpia antes de añadir datos
                    comboBox_Separacion1FH.Items.Clear();
                    comboBox_Separacion2FH.Items.Clear();

                    using (MySqlCommand commandBasesDatos = new MySqlCommand(sqlQueryTabla, connection))
                    {
                        using (MySqlDataReader readerBasesDatos = commandBasesDatos.ExecuteReader())
                        {
                            while (readerBasesDatos.Read())
                            {
                                string nombreTablas = readerBasesDatos.GetString(0);
                                comboBox_Separacion1FH.Items.Add(nombreTablas);
                                comboBox_Separacion2FH.Items.Add(nombreTablas);
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

        private void comboBox_ColumnaFV_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosAtributosFV();
        }

        private void CargarDatosAtributosFV()
        {
            string cadenaConexion = "Database=" + comboBox_DataBaseFV.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    // Obtener las bases de datos existentes
                    string sqlQueryTabla = $"SELECT DISTINCT {comboBox_ColumnaFV.Text} FROM {comboBox_DataBaseFV.Text}.{comboBox_TablaFV.Text};";
                    //Limpia antes de añadir datos
                    comboBox_Separacion1FV.Items.Clear();
                    comboBox_Separacion2FV.Items.Clear();

                    using (MySqlCommand commandBasesDatos = new MySqlCommand(sqlQueryTabla, connection))
                    {
                        using (MySqlDataReader readerBasesDatos = commandBasesDatos.ExecuteReader())
                        {
                            while (readerBasesDatos.Read())
                            {
                                string nombreTablas = readerBasesDatos.GetString(0);
                                comboBox_Separacion1FV.Items.Add(nombreTablas);
                                comboBox_Separacion2FV.Items.Add(nombreTablas);
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
    }
}
