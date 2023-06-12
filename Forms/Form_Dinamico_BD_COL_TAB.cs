using MySql.Data.MySqlClient;
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
    public partial class Form_Dinamico_BD_COL_TAB : Form
    {
        private bool isDarkModeEnabled;
        public Form_Dinamico_BD_COL_TAB(bool isDarkModeEnabled)
        {
            InitializeComponent();

            //Bloquear escritura en ComboBox
            comboBox_TipoDato_Tabla.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_TipoDato_Columna.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_DataBase_Columna.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_DataBase_Tabla.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Tabla_Columna.DropDownStyle= ComboBoxStyle.DropDownList;
            this.isDarkModeEnabled = isDarkModeEnabled;
            SetTheme();
            Resize += Form_Dinamico_BD_COL_TAB_Resize;
        }

        private void button_CreateDataBase_Click(object sender, EventArgs e)
        {
            // Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = "Database=mysql; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

            // en caso de error descomentar MySqlConnection conexionBD = new MySqlConnection(cadenaConexion); 
            // Try-catch para capturar posibles errores de conexión o sintaxis.
            string databaseName = textBox_CreateDataBase.Text;
            string sqlQuery = "CREATE DATABASE " + textBox_CreateDataBase.Text;

            if (string.IsNullOrEmpty(databaseName))
            {
                MessageBox.Show("Error: El campo está vacío. Por favor, ingresa un nombre de base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
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
                    // Actualizar el DataGridView con las bases de datos
                    using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                    {
                        connection.Open();
                        // Recupera información sobre las bases de datos excluyendo aquellas que terminan en '_schema'
                        string sqlQuery1 = "SELECT * FROM information_schema.schemata WHERE schema_name NOT LIKE '%\\_schema';";
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery1, connection))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView_Muestra.DataSource = dataTable;
                        }

                        connection.Close();
                    }
                    MessageBox.Show("Ejecución Completa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBox_CreateDataBase.Text = "";
                CargarDatos();
            }
        }


        private void button_Añadir_Tabla_Click(object sender, EventArgs e)
        {
            string cadenaConexion = "Database=" + comboBox_DataBase_Tabla.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

            // Verificar si alguno de los campos está vacío
            if (string.IsNullOrEmpty(textBox_Nombre_Tabla.Text) || string.IsNullOrEmpty(textBox_ClavePrimaria_Tabla.Text) || string.IsNullOrEmpty(comboBox_TipoDato_Tabla.Text))
            {
                string campoVacio = string.Empty;

                if (string.IsNullOrEmpty(textBox_Nombre_Tabla.Text))
                {
                    campoVacio = "Nombre de tabla";
                }
                else if (string.IsNullOrEmpty(textBox_ClavePrimaria_Tabla.Text))
                {
                    campoVacio = "Clave primaria";
                }
                else if (string.IsNullOrEmpty(comboBox_TipoDato_Tabla.Text))
                {
                    campoVacio = "Tipo de dato";
                }

                MessageBox.Show("Error: El campo '" + campoVacio + "' está vacío. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    // Crear la tabla
                    string sqlQuery = "CREATE TABLE " + textBox_Nombre_Tabla.Text + " (" + textBox_ClavePrimaria_Tabla.Text + " " + comboBox_TipoDato_Tabla.Text + " PRIMARY KEY)";
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Tabla creada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cargar los datos de la tabla en el dataGridView_Muestra
                    sqlQuery = "DESCRIBE " + textBox_Nombre_Tabla.Text;
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView_Muestra.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCampos();
        }

        private void button_Añadir_Columna_Click(object sender, EventArgs e)
        {
            string cadenaConexion = "Database=" + comboBox_DataBase_Columna.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";
            // Verificar si los campos están en blanco
            if (string.IsNullOrEmpty(comboBox_DataBase_Columna.Text) ||
                string.IsNullOrEmpty(comboBox_Tabla_Columna.Text) ||
                string.IsNullOrEmpty(textBox_Atributo_Tabla.Text) ||
                string.IsNullOrEmpty(comboBox_TipoDato_Columna.Text))
            {
                MessageBox.Show("Error: Todos los campos deben ser completados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin ejecutar la consulta
            }
            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();
                    string sqlQuery;
                    if (checkBox_Null_Columna.Checked)
                    {
                        sqlQuery = "ALTER TABLE " + comboBox_Tabla_Columna.Text + " ADD " + textBox_Atributo_Tabla.Text + " " + comboBox_TipoDato_Columna.Text + " NOT NULL;";
                    }
                    else
                    {
                        sqlQuery = "ALTER TABLE " + comboBox_Tabla_Columna.Text + " ADD " + textBox_Atributo_Tabla.Text + " " + comboBox_TipoDato_Columna.Text + " NULL;";
                    }
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Columna creada exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cargar los datos de la tabla en el dataGridView_Muestra
                    sqlQuery = "DESCRIBE " + comboBox_Tabla_Columna.Text;
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView_Muestra.DataSource = dataTable;
                    }
                    connection.Close();
                    return;//-----Importante encontrar otra solucion(Eliminar esto)
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//Encontrar el error de la exeption
            }
            LimpiarCampos();
        }

        private void Form_Dinamico_BD_COL_TAB_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void LimpiarCampos()
        {
            // Limpiar TextBox
            textBox_CreateDataBase.Text = "";
            textBox_Nombre_Tabla.Text = "";
            textBox_ClavePrimaria_Tabla.Text = "";
            textBox_Atributo_Tabla.Text = "";
            // Limpiar ComboBox
            comboBox_TipoDato_Tabla.SelectedIndex = -1;
            comboBox_TipoDato_Columna.SelectedIndex = -1;
            comboBox_DataBase_Columna.SelectedIndex = -1;
            comboBox_DataBase_Tabla.SelectedIndex = -1;
            comboBox_Tabla_Columna.SelectedIndex = -1;
        }
        private void CargarDatos()
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
                    comboBox_DataBase_Tabla.Items.Clear();
                    comboBox_DataBase_Columna.Items.Clear();

                    using (MySqlCommand commandBasesDatos = new MySqlCommand(sqlQueryBasesDatos, connection))
                    {
                        using (MySqlDataReader readerBasesDatos = commandBasesDatos.ExecuteReader())
                        {
                            while (readerBasesDatos.Read())
                            {
                                string nombreBaseDatos = readerBasesDatos.GetString(0);
                                comboBox_DataBase_Tabla.Items.Add(nombreBaseDatos);
                                comboBox_DataBase_Columna.Items.Add(nombreBaseDatos);
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
                    //Limpia antes de añadir datos
                    comboBox_TipoDato_Tabla.Items.Clear();
                    comboBox_TipoDato_Columna.Items.Clear();


                    comboBox_TipoDato_Tabla.Items.AddRange(tiposDatos_Tabla.ToArray());
                    comboBox_TipoDato_Columna.Items.AddRange(tiposDatos_Columna.ToArray());
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_DataBase_Columna_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDatosTabla_Tablas();
        }

        private void cargarDatosTabla_Tablas()
        {
            string cadenaConexion = "Database="+comboBox_DataBase_Columna.Text+"; Data Source=localhost; Port=3306; User Id=root; Password=2001;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    // Obtener las bases de datos existentes
                    string sqlQueryTabla = "SHOW TABLES FROM "+comboBox_DataBase_Columna.Text+";\r\n";
                    //Limpia antes de añadir datos
                    comboBox_Tabla_Columna.Items.Clear();

                    using (MySqlCommand commandBasesDatos = new MySqlCommand(sqlQueryTabla, connection))
                    {
                        using (MySqlDataReader readerBasesDatos = commandBasesDatos.ExecuteReader())
                        {
                            while (readerBasesDatos.Read())
                            {
                                string nombreTablas = readerBasesDatos.GetString(0);
                                comboBox_Tabla_Columna.Items.Add(nombreTablas);
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

        private void comboBox_Tabla_Columna_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaConexion = "Database=" + comboBox_DataBase_Columna.Text + "; Data Source=localhost; Port=3306; User Id=root; Password=2001;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();
                    // Cargar los datos de la tabla en el dataGridView_Muestra
                    string sqlQuery = "DESCRIBE " + comboBox_Tabla_Columna.Text;
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView_Muestra.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_DataBase_Tabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaConexion = "Database=mysql; Data Source=localhost; Port=3306; User Id=root; Password=2001;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();
                    // Cargar los datos de la tabla en el dataGridView_Muestra
                    string sqlQuery = "SELECT table_name FROM information_schema.tables WHERE table_schema = '" + comboBox_DataBase_Tabla.Text+"';";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView_Muestra.DataSource = dataTable;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                // Ajustar el color de fuente del groupBox1-2-3
                groupBox1.ForeColor = darkTextColor;
                groupBox1.BackColor = SystemColors.ControlDarkDark;

                groupBox2.ForeColor = darkTextColor;
                groupBox2.BackColor = SystemColors.ControlDarkDark;

                groupBox3.ForeColor = darkTextColor;
                groupBox3.BackColor = SystemColors.ControlDarkDark;



            }
            else
            {
                // Cambiar a modo claro
                BackColor = originalBackgroundColor;
                ForeColor = originalTextColor;
                // Restablecer los colores claros para otros controles según sea necesario

                // Restaurar el color de fuente original del groupBox1-2-3
                groupBox1.ForeColor = SystemColors.ControlText;
                groupBox2.ForeColor = SystemColors.ControlText;
                groupBox3.ForeColor = SystemColors.ControlText;

            }
        }

        
        private void Form_Dinamico_BD_COL_TAB_Resize(object sender, EventArgs e)
        {
            label19.Width = ClientSize.Width; // Ajustar el ancho del Label al ancho del formulario

            // Agregar más texto al Label para que se ajuste hasta el final hacia la derecha
            string labelText = "OUTPUT ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::" +
                "::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::";
            while (label19.Width < TextRenderer.MeasureText(labelText, label19.Font).Width)
            {
                labelText = labelText.Substring(0, labelText.Length - 1);
            }
            label19.Text = labelText;
        }

    }
}
