//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Drawing;
//using System.ComponentModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ProyectoSGBD_MySQL.Forms
{
    public partial class Form_BD : Form
    {

        public Form_BD()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            Load += FormularioEsquemas_Load;
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
            string cadenaConexion = textBox_RecibeBD.Text;
            using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    connection.Open();

                    DataTable schemas = connection.GetSchema("Databases");

                    // Mostrar los esquemas en el ListBox
                    listBoxEsquemas.DataSource = schemas;
                    listBoxEsquemas.DisplayMember = "SCHEMA_NAME";
                    listBoxEsquemas.ValueMember = "SCHEMA_NAME";
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error al obtener los esquemas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
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

        private void pictureBox31_Click(object sender, EventArgs e)
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

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            string sqlQuery = textBox_Query.Text;
            DataTable dataTable = new DataTable();
            List<string> mensajes = new List<string>();
            // Eliminar el contenido previo del DataGridView
            dataGridView1.ClearSelection();

            // Crearemos la cadena de conexión concatenando las variables
            string cadenaConexion = textBox_RecibeBD.Text;

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
                                dataGridView1.DataSource = dataTable; // Enlazar los datos al DataGridView
                            }

                            // Verificar que el DataTable contenga los datos esperados
                            if (dataTable.Rows.Count > 0)
                            {
                                // Enlazar los datos al DataGridView
                                dataGridView1.DataSource = dataTable;
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
    }
}
