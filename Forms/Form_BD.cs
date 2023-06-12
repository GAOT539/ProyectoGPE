using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoSGBD_MySQL.Forms
{
    public partial class Form_BD : Form
    {
        private bool isDarkModeEnabled;
        public Form_BD(bool isDarkModeEnabled)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            Load += FormularioEsquemas_Load;
            comboBox_Asistente.SelectedIndexChanged += comboBox_Asistente_SelectedIndexChanged;
            textBox_Connection.Text = cAux.CadenaConexion;
            comboBox_Asistente.DropDownStyle = ComboBoxStyle.DropDownList;
            this.isDarkModeEnabled = isDarkModeEnabled;
            SetTheme();
        }

        // Evento Load del formulario
        private void FormularioEsquemas_Load(object sender, EventArgs e)
        {
            ObtenerEsquemas();
        }

        // Método para obtener los esquemas de la base de datos MySQL
        private void ObtenerEsquemas()
        {
            // Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = cAux.CadenaConexion;
            using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    DataTable schemas = connection.GetSchema("Databases");
                    TreeNode nodoRaiz = new TreeNode("esquemas");
                    treeView_Schemas.Nodes.Add(nodoRaiz);

                    foreach (DataRow row in schemas.Rows)
                    {
                        string schemaName = row["database_name"].ToString();

                        // Crear un nodo para cada esquema y agregarlo al nodo raíz
                        TreeNode schemaNode = new TreeNode(schemaName);
                        nodoRaiz.Nodes.Add(schemaNode);

                        MostrarTablasCadaEsquema(schemaName, schemaNode, connection);
                        MostrarVistasCadaEsquema(schemaName, schemaNode, connection);
                        MostrarProcedimientosCadaEsquema(schemaName, schemaNode, connection);
                        MostrarFuncionesCadaEsquema(schemaName, schemaNode, connection);
                        MostrarTriggersCadaEsquema(schemaName, schemaNode, connection);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los esquemas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // Método para mostrar los triggers de cada esquema
        private void MostrarTriggersCadaEsquema(string schemaName, TreeNode schemaNode, MySqlConnection connection)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                DataTable triggers = connection.GetSchema("Triggers", new string[] { null, schemaName });

                TreeNode triggersNode = new TreeNode("Triggers");
                schemaNode.Nodes.Add(triggersNode);

                foreach (DataRow triggerRow in triggers.Rows)
                {
                    string triggerName = triggerRow["TRIGGER_NAME"].ToString();

                    TreeNode triggerNode = new TreeNode(triggerName);
                    triggersNode.Nodes.Add(triggerNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los triggers del esquema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para mostrar las funciones de cada esquema
        private void MostrarFuncionesCadaEsquema(string schemaName, TreeNode schemaNode, MySqlConnection connection)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                DataTable functions = connection.GetSchema("Functions", new string[] { null, schemaName });

                TreeNode funcionesNode = new TreeNode("Funciones");
                schemaNode.Nodes.Add(funcionesNode);

                foreach (DataRow functionRow in functions.Rows)
                {
                    string functionName = functionRow["ROUTINE_NAME"].ToString();

                    TreeNode functionNode = new TreeNode(functionName);
                    funcionesNode.Nodes.Add(functionNode);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al obtener las funciones del esquema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para mostrar los procedimientos de cada esquema
        private void MostrarProcedimientosCadaEsquema(string schemaName, TreeNode schemaNode, MySqlConnection connection)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                DataTable procedures = connection.GetSchema("Procedures", new string[] { null, schemaName });

                TreeNode procedimientosNode = new TreeNode("Procedimientos");
                schemaNode.Nodes.Add(procedimientosNode);

                foreach (DataRow procedureRow in procedures.Rows)
                {
                    string procedureName = procedureRow["ROUTINE_NAME"].ToString();

                    TreeNode procedureNode = new TreeNode(procedureName);
                    procedimientosNode.Nodes.Add(procedureNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los procedimientos del esquema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para mostrar las vistas de cada esquema
        private void MostrarVistasCadaEsquema(string schemaName, TreeNode schemaNode, MySqlConnection connection)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                DataTable views = connection.GetSchema("Views", new string[] { null, schemaName });

                TreeNode vistasNode = new TreeNode("Vistas");
                schemaNode.Nodes.Add(vistasNode);

                foreach (DataRow viewRow in views.Rows)
                {
                    string viewName = viewRow["TABLE_NAME"].ToString();

                    TreeNode viewNode = new TreeNode(viewName);
                    vistasNode.Nodes.Add(viewNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las vistas del esquema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para mostrar las tablas de cada esquema
        private void MostrarTablasCadaEsquema(string schemaName, TreeNode schemaNode, MySqlConnection connection)
        {
            try
            {
                using (connection)
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    DataTable tables = connection.GetSchema("Tables", new string[] { null, schemaName });

                    // Crear el nodo padre "Tablas"
                    TreeNode tablasNode = new TreeNode("Tablas");
                    schemaNode.Nodes.Add(tablasNode);

                    foreach (DataRow tableRow in tables.Rows)
                    {
                        string tableName = tableRow["TABLE_NAME"].ToString();

                        // Crear un nodo para cada tabla y agregarlo como hijo del nodo del esquema
                        TreeNode tableNode = new TreeNode(tableName);
                        tablasNode.Nodes.Add(tableNode);

                        MostrarColumnasDeTabla(schemaName, tableName, tableNode, connection);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las tablas del esquema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para mostrar las columnas de una tabla
        private void MostrarColumnasDeTabla(string schemaName, string tableName, TreeNode tableNode, MySqlConnection connection)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                DataTable columns = connection.GetSchema("Columns", new string[] { null, schemaName, tableName });

                // Crear el nodo padre "Columnas"
                TreeNode columnasNode = new TreeNode("Columnas");
                tableNode.Nodes.Add(columnasNode);

                foreach (DataRow columnRow in columns.Rows)
                {
                    string columnName = columnRow["COLUMN_NAME"].ToString();
                    TreeNode columnNode = new TreeNode(columnName);
                    columnasNode.Nodes.Add(columnNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las columnas de la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void pictureBox_GuardarDocumento_Click(object sender, EventArgs e)
        {
            // Limpiar el árbol antes de actualizar el esquema
            treeView_Schemas.Nodes.Clear();
            // Llamar al método para obtener y mostrar el esquema
            ObtenerEsquemas();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos SQL (*.sql)|*.sql";
            saveFileDialog.Title = "Guardar archivo SQL";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Guardar el contenido en el archivo SQL
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.Write(textBox_Query.Text);
                    }

                    MessageBox.Show("Archivo guardado exitosamente.", "Guardar archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Guardar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox_AbrirDocumento_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos SQL (*.sql)|*.sql";
            openFileDialog.Title = "Cargar archivo SQL";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Leer el contenido del archivo SQL
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string contenido = reader.ReadToEnd();
                        textBox_Query.Text = contenido;
                    }

                    MessageBox.Show("Archivo cargado exitosamente.", "Cargar archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el archivo: " + ex.Message, "Cargar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_EjecutarQuery_Click(object sender, EventArgs e)
        {
            string sqlQuery = textBox_Query.Text;
            DataTable dataTable = new DataTable();
            List<string> mensajes = new List<string>();
            // Eliminar el contenido previo del DataGridView
            dataGridView_Muestra.ClearSelection();

            // Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = textBox_Connection.Text;

            // Instancia para conexión a MySQL, recibe la cadena de conexión
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

            // Try-catch para capturar posibles errores de conexión o sintaxis.
            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open(); // Abre la conexión

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        if (!sqlQuery.ToUpper().Contains("CREATE") && !sqlQuery.ToUpper().Contains("INSERT")
                            && !sqlQuery.ToUpper().Contains("UPDATE") && !sqlQuery.ToUpper().Contains("DELETE"))
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                dataTable.Load(reader); // Crear un DataTable para almacenar los datos de la consulta
                                dataGridView_Muestra.DataSource = dataTable; // Enlazar los datos al DataGridView
                            }

                            // Verificar que el DataTable contenga los datos esperados
                            if (dataTable.Rows.Count > 0)
                            {
                                // Enlazar los datos al DataGridView
                                dataGridView_Muestra.DataSource = dataTable;
                            }
                            else
                            {
                                // No se encontraron datos, mostrar un mensaje de error
                                MessageBox.Show("Error al mostrar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        // Obtener los estados del SQL y mostrarlos en el TextBox
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    string estado = reader[i].ToString();
                                    textBox_Consola.AppendText(estado + Environment.NewLine);
                                }
                            }
                        }
                    }
                }
                if (mensajes.Count > 0)
                {
                    string mensajeCompleto = string.Join("\n", mensajes);
                    MessageBox.Show(mensajeCompleto, "Mensajes de Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Mostrar MessageBox "EjecucionCompleta"
                MessageBox.Show("Ejecución Completa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Si existe un error aquí muestra el mensaje
            }
            finally
            {
                conexionBD.Close(); // Cierra la conexión a MySQL
            }
        }

        private void comboBox_Asistente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox_Asistente.SelectedItem.ToString();

            string generatedText = string.Empty;

            // Lógica para generar el texto según el elemento seleccionado
            switch (selectedItem)
            {
                case "Jump to":
                    generatedText = cAux.JumpToText;
                    break;
                case "SELECT":
                    generatedText = cAux.SelectText;
                    break;
                case "UPDATE":
                    generatedText = cAux.UpdateText;
                    break;
                case "INSERT":
                    generatedText = cAux.InsertText;
                    break;
                case "DELETE":
                    generatedText = cAux.DeleteText;
                    break;
                case "CREATE TABLE":
                    generatedText = cAux.CreateTableText;
                    break;
                case "CREATE VIEW":
                    generatedText = cAux.CreateViewText; 
                    break;
                case "CREATE PROCEDURE":
                    generatedText = cAux.CreateProcedureText;
                    break;
                case "CREATE FUNCTION":
                    generatedText = cAux.CreateFunctionText;
                    break;
                case "ALTER TABLE":
                    generatedText = cAux.AlterTableText;
                    break;
                default:
                    generatedText = cAux.AutomaticText;
                    break;
            }

            textBox_Asistente.Text = generatedText;
        }

        private void pictureBox_FormDinamico_Click(object sender, EventArgs e)
        {
            Forms.Form_Dinamico_BD_COL_TAB form_D = new Forms.Form_Dinamico_BD_COL_TAB(isDarkModeEnabled);
            cAux cAux = new cAux();
            this.Hide();
            form_D.ShowDialog();
            this.Show();
        }

        private void label_Users_Click(object sender, EventArgs e)
        {
            Forms.Form_Usuarios_Privilegios form_Usuarios_Privilegios = new Forms.Form_Usuarios_Privilegios(isDarkModeEnabled);
            cAux cAux = new cAux();
            this.Hide();
            form_Usuarios_Privilegios.ShowDialog();
            this.Show();
        }

        private Color originalBackgroundColor;
        private Color originalTextColor;
        private Color darkBackgroundColor = Color.FromArgb(30, 30, 30);
        private Color darkTextColor = Color.Black;
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


            }
            else
            {
                // Cambiar a modo claro
                BackColor = originalBackgroundColor;
                ForeColor = originalTextColor;
                // Restablecer los colores claros para otros controles según sea necesario


            }
        }
    }
}
