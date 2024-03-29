﻿using MySql.Data.MySqlClient;
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
        
        private void button_Añadir_TablaFH_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos estén llenos
            if (string.IsNullOrEmpty(comboBox_DataBaseFH.Text) ||
                string.IsNullOrEmpty(comboBox_TablaFH.Text) ||
                string.IsNullOrEmpty(comboBox_ColumnaFH.Text) ||
                string.IsNullOrEmpty(comboBox_Separacion1FH.Text) ||
                string.IsNullOrEmpty(comboBox_Separacion2FH.Text) ||
                string.IsNullOrEmpty(textBox_NombreTabla1FH.Text) ||
                string.IsNullOrEmpty(textBox_NombreTabla2FH.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CrearFragmentacionH();
            MostrarTablasEnDataGridViewFH();
            LimpiarFH();
        }

        private void LimpiarFH()
        {
            comboBox_TablaFH.Items.Clear();
            comboBox_ColumnaFH.Items.Clear();
            comboBox_Separacion1FH.Items.Clear();
            comboBox_Separacion2FH.Items.Clear();
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

                string[] columnasTablaPrincipal = ObtenerNombresColumnasFH(tableName);

                // Crear el trigger
                CrearTriggerFH(tableName, newTableName1, newTableName2, columnasTablaPrincipal, columnName, separationAttr1, separationAttr2);

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
                    comboBox_TablaFMH.Items.Clear();
                    comboBox_TablaFMV.Items.Clear();

                    using (MySqlCommand commandBasesDatos = new MySqlCommand(sqlQueryTabla, connection))
                    {
                        using (MySqlDataReader readerBasesDatos = commandBasesDatos.ExecuteReader())
                        {
                            while (readerBasesDatos.Read())
                            {
                                string nombreTablas = readerBasesDatos.GetString(0);
                                comboBox_TablaFM.Items.Add(nombreTablas);
                                comboBox_TablaFMH.Items.Add(nombreTablas);
                                comboBox_TablaFMV.Items.Add(nombreTablas);
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

        private void comboBox_TablaFMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosDataGridViewFMH();
        }

        private void cargarDatosDataGridViewFMH()
        {
            string cadenaConexion = "Database=" + comboBox_DataBaseFM.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();
                    // Cargar los datos de la tabla en el dataGridView_Muestra
                    string selectQuery1 = $"SELECT * FROM {comboBox_DataBaseFM.Text}.{comboBox_TablaFMH.Text}";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery1, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView_CamposFMH.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_TablaFMV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosDataGridViewFMV();
        }

        private void cargarDatosDataGridViewFMV()
        {
            string cadenaConexion = "Database=" + comboBox_DataBaseFM.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();
                    // Cargar los datos de la tabla en el dataGridView_Muestra
                    string selectQuery1 = $"SELECT * FROM {comboBox_DataBaseFM.Text}.{comboBox_TablaFMV.Text}";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery1, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView_CamposFMV.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Añadir_TablaFV_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos estén llenos
            if (string.IsNullOrEmpty(comboBox_DataBaseFV.Text) ||
                string.IsNullOrEmpty(comboBox_TablaFV.Text) ||
                string.IsNullOrEmpty(textBox_Separacion1FV.Text) ||
                string.IsNullOrEmpty(textBox_Separacion1FV.Text) ||
                string.IsNullOrEmpty(textBox_NombreTabla1FV.Text) ||
                string.IsNullOrEmpty(textBox_NombreTabla2FV.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CrearFragmentacionV();
            MostrarTablasEnDataGridViewFV();
            LimpiarFV();
        }

        private void CrearFragmentacionV()
        {
            try
            {
                // Obtener los valores de los campos de texto
                string databaseName = comboBox_DataBaseFV.Text;
                string tableName = comboBox_TablaFV.Text;
                string separationAttr1 = textBox_Separacion1FV.Text;
                string separationAttr2 = textBox_Separacion2FV.Text;
                string newTableName1 = textBox_NombreTabla1FV.Text;
                string newTableName2 = textBox_NombreTabla2FV.Text;

                // Cadena de conexión a MySQL
                // string connectionString = cAux.CadenaConexion;
                string cadenaConexion = "Database=" + comboBox_DataBaseFV.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

                // Consulta para crear la tabla 1
                string createTableQuery1 = $"CREATE TABLE {databaseName}.{newTableName1} SELECT {separationAttr1} FROM {databaseName}.{tableName}";
                // Consulta para crear la tabla 2 
                string createTableQuery2 = $"CREATE TABLE {databaseName}.{newTableName2} SELECT {separationAttr2} FROM {databaseName}.{tableName}";

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

        private void MostrarTablasEnDataGridViewFV()
        {
            try
            {
                // Obtener los valores de los campos de texto
                string databaseName = comboBox_DataBaseFV.Text;
                string newTableName1 = textBox_NombreTabla1FV.Text;
                string newTableName2 = textBox_NombreTabla2FV.Text;

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
                dataGridView_CamposFV1.DataSource = table1;
                dataGridView_CamposFV2.DataSource = table2;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al mostrar los datos en los DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFV()
        {
            comboBox_TablaFV.Items.Clear();
            textBox_Separacion1FV.Text = "";
            textBox_Separacion2FV.Text = "";
            textBox_NombreTabla1FV.Text = "";
            textBox_NombreTabla2FV.Text = "";
        }

        private void button_Añadir_TablaFM_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos estén llenos
            if (string.IsNullOrEmpty(comboBox_DataBaseFM.Text) ||
                string.IsNullOrEmpty(comboBox_TablaFM.Text) ||
                string.IsNullOrEmpty(comboBox_TablaFMH.Text) ||
                string.IsNullOrEmpty(comboBox_TablaFMV.Text) ||
                string.IsNullOrEmpty(textBox_NombreTablaFMM.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CrearFragmentacionM();
            MostrarTablasEnDataGridViewFM();
            LimpiarFM();
        }

        private void CrearFragmentacionM()
        {
            string cadenaConexion = "Database=" + comboBox_DataBaseFM.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";
            string nombreBaseDatos = comboBox_DataBaseFM.Text;
            string nombreTabla1 = comboBox_TablaFMV.Text;
            string nombreTabla2 = comboBox_TablaFMH.Text;
            string nombreTablaCrear = textBox_NombreTablaFMM.Text;

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    // Obtener los datos de la tabla2
                    string consultaTabla2 = $"SELECT * FROM {nombreBaseDatos}.{nombreTabla2}";
                    MySqlCommand comandoTabla2 = new MySqlCommand(consultaTabla2, conexion);
                    MySqlDataAdapter adaptadorTabla2 = new MySqlDataAdapter(comandoTabla2);
                    DataTable datosTabla2 = new DataTable();
                    adaptadorTabla2.Fill(datosTabla2);

                    // Crear la tabla3
                    string consultaCrearTabla = $"CREATE TABLE {nombreBaseDatos}.{nombreTablaCrear} LIKE {nombreBaseDatos}.{nombreTabla1}";
                    MySqlCommand comandoCrearTabla = new MySqlCommand(consultaCrearTabla, conexion);
                    comandoCrearTabla.ExecuteNonQuery();

                    // Insertar los datos de la tabla2 en la tabla3
                    // Nota: La logica de insercion es que se optiene las columnas de la TablaFV en formato (dato, dato, dato) y asi se selecciona las columnas especificas.
                    string sqlQueryColumnas1 = $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '{nombreBaseDatos}' AND TABLE_NAME = '{nombreTabla1}' ORDER BY ORDINAL_POSITION;";
                    MySqlCommand comandoColumnas1 = new MySqlCommand(sqlQueryColumnas1, conexion);
                    MySqlDataReader readerColumnas1 = comandoColumnas1.ExecuteReader();
                    List<string> columnas = new List<string>();
                    while (readerColumnas1.Read())
                    {
                        string columna = readerColumnas1.GetString(0);
                        columnas.Add(columna);
                    }
                    readerColumnas1.Close();

                    //Dar formato a las columnas
                    string datoColumna = string.Join(", ", columnas.ToArray());
                    datoColumna = datoColumna.TrimStart(',', ' ').TrimEnd(',', ' ');
                    //MessageBox.Show(datoColumna, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    string consultaInsertarDatos = $"INSERT INTO {nombreBaseDatos}.{nombreTablaCrear} SELECT {datoColumna} FROM {nombreBaseDatos}.{nombreTabla2}";
                    MySqlCommand comandoInsertarDatos = new MySqlCommand(consultaInsertarDatos, conexion);
                    comandoInsertarDatos.ExecuteNonQuery();


                    MessageBox.Show("Tabla creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al crear la tabla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MostrarTablasEnDataGridViewFM()
        {
            try
            {
                // Obtener los valores de los campos de texto
                string databaseName = comboBox_DataBaseFM.Text;
                string newTableName1 = textBox_NombreTablaFMM.Text;

                // Cadena de conexión a MySQL
                string connectionString = cAux.CadenaConexion;

                // Consulta para obtener los datos de la tabla 1
                string selectQuery1 = $"SELECT * FROM {databaseName}.{newTableName1}";

                // Crear un DataTable para almacenar los datos de la tabla 1
                DataTable table1 = new DataTable();

                // Obtener los datos de la tabla 1
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlDataAdapter adapter1 = new MySqlDataAdapter(selectQuery1, connection))
                    {
                        adapter1.Fill(table1);
                    }
                    connection.Close();
                }

                // Mostrar los datos en los DataGridView
                dataGridView_CamposFMM.DataSource = table1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al mostrar los datos en los DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFM()
        {
            comboBox_TablaFM.Items.Clear();
            comboBox_TablaFMH.Items.Clear();
            comboBox_TablaFMV.Items.Clear();
            textBox_NombreTablaFMM.Text = "";
        }

        private string[] ObtenerNombresColumnasFH(string tablaPrincipal)
        {
            try
            {
                // Obtener los nombres de las columnas de la tabla principal
                List<string> columnas = new List<string>();

                // Cadena de conexión a MySQL
                string cadenaConexion = "Database=" + comboBox_DataBaseFH.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

                // Consulta para obtener los nombres de las columnas
                string query = $"SHOW COLUMNS FROM {tablaPrincipal}";

                // Ejecutar la consulta
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nombreColumna = reader.GetString("Field");
                                columnas.Add(nombreColumna);
                            }
                        }
                    }

                    connection.Close();
                }

                return columnas.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al obtener los nombres de las columnas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new string[0]; // Devolver un arreglo vacío en caso de error
            }
        }

        private void CrearTriggerFH(string tablaPrincipal, string nombreTabla1, string nombreTabla2, string[] columnas, string columnName, string separationAttr1, string separationAttr2)
        {
            try
            {
                string triggerName = "Trigger_" + tablaPrincipal + "_" + nombreTabla1 + nombreTabla2;

                // Cadena de conexión a MySQL
                string cadenaConexion = "Database=" + comboBox_DataBaseFH.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

                // Construir la lista de columnas para la inserción
                string columnList = string.Join(", ", columnas);

                // Construir la lista de valores para la inserción
                string valueList = string.Join(", ", columnas.Select(c => "NEW." + c));

                // Consulta para crear el trigger
                string createTriggerQuery = $@"
                    CREATE TRIGGER {triggerName}_Insert AFTER INSERT ON {tablaPrincipal}
                    FOR EACH ROW
                    BEGIN
                        -- Eliminar de la tabla 1
                        DELETE FROM {nombreTabla1} WHERE {columnName} = '{separationAttr1}' AND id = NEW.id;

                        -- Eliminar de la tabla 2
                        DELETE FROM {nombreTabla2} WHERE {columnName} = '{separationAttr2}' AND id = NEW.id;

                        -- Insertar en la tabla 1
                        INSERT INTO {nombreTabla1} ({columnList}) SELECT {columnList} FROM {tablaPrincipal} WHERE {columnName} = '{separationAttr1}' AND id = NEW.id;

                        -- Insertar en la tabla 2
                        INSERT INTO {nombreTabla2} ({columnList}) SELECT {columnList} FROM {tablaPrincipal} WHERE {columnName} = '{separationAttr2}' AND id = NEW.id;
                    END;

                    CREATE TRIGGER {triggerName}_Update AFTER UPDATE ON {tablaPrincipal}
                    FOR EACH ROW
                    BEGIN
                        -- Eliminar de la tabla 1
                        DELETE FROM {nombreTabla1} WHERE {columnName} = '{separationAttr1}' AND id = NEW.id;

                        -- Eliminar de la tabla 2
                        DELETE FROM {nombreTabla2} WHERE {columnName} = '{separationAttr2}' AND id = NEW.id;

                        -- Insertar en la tabla 1
                        INSERT INTO {nombreTabla1} ({columnList}) SELECT {columnList} FROM {tablaPrincipal} WHERE {columnName} = '{separationAttr1}' AND id = NEW.id;

                        -- Insertar en la tabla 2
                        INSERT INTO {nombreTabla2} ({columnList}) SELECT {columnList} FROM {tablaPrincipal} WHERE {columnName} = '{separationAttr2}' AND id = NEW.id;
                    END;

                    CREATE TRIGGER {triggerName}_Delete AFTER DELETE ON {tablaPrincipal}
                    FOR EACH ROW
                    BEGIN
                        -- Eliminar de la tabla 1
                        DELETE FROM {nombreTabla1} WHERE {columnName} = '{separationAttr1}' AND id = OLD.id;

                        -- Eliminar de la tabla 2
                        DELETE FROM {nombreTabla2} WHERE {columnName} = '{separationAttr2}' AND id = OLD.id;
                    END";

                // Ejecutar la consulta
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(createTriggerQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                //MessageBox.Show("Trigger creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al crear el trigger: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
