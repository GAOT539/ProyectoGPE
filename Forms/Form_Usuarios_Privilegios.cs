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
    public partial class Form_Usuarios_Privilegios : Form
    {
        public Form_Usuarios_Privilegios()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            bloquearLogin();//Bloquear el registro login
            label_nombreUser.Text = cAux.NombreConexion;
            //comboBox_authenticationType.SelectedIndex = 0;
            comboBox_authenticationType.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void dataGridView_userView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_userView.Rows[e.RowIndex];

                // Obtener los valores de las celdas seleccionadas
                string loginName = row.Cells["User"].Value.ToString();
                string host = row.Cells["Host"].Value.ToString();

                // Mostrar los valores en los campos de texto
                text_loginName.Text = loginName;
                text_limitHostsMatching.Text = host;
            }
        }

        private void Form_Usuarios_Privilegios_Load(object sender, EventArgs e)
        {
            CargaraDatosView();
        }

        private void CargaraDatosView()
        {
            string cadenaConexion = "Database=mysql; Data Source=localhost; Port=3306; User Id=root; Password=2001;";
            string sqlQuery = "SELECT User, Host FROM mysql.user;";
            //dataGridView_userView.Rows.Clear();

            try
            {
                // Crear una tabla para almacenar los resultados
                DataTable dataTable = new DataTable();

                // Establecer la cadena de conexión y crear una instancia de MySqlConnection
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    // Crear un adaptador de datos y llenar la tabla con los resultados de la consulta
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, connection))
                    {
                        adapter.Fill(dataTable);
                    }

                    connection.Close();
                }
                // Asignar la tabla como origen de datos del DataGridView
                dataGridView_userView.DataSource = dataTable;
                dataGridView_userView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_addAccount_Click(object sender, EventArgs e)
        {
            desbloquearLogin();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            CargaraDatosView();
        }

        private void button_Revert_Click(object sender, EventArgs e)
        {
            bloquearLogin();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string cadenaConexion = cAux.CadenaConexion;
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dataGridView_userView.SelectedRows.Count > 0)
            {
                // Obtener el nombre de usuario de la fila seleccionada
                string userName = dataGridView_userView.SelectedRows[0].Cells["User"].Value.ToString();
                string hosts = dataGridView_userView.SelectedRows[0].Cells["Host"].Value.ToString();

                // Construir la sentencia SQL DELETE
                string deleteQuery = $"DROP USER '{userName}'@'{hosts}';";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                    {
                        connection.Open();

                        // Ejecutar la sentencia DELETE
                        using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        // Actualizar el DataGridView después de eliminar el usuario
                        // Puedes volver a cargar los datos o eliminar la fila seleccionada directamente
                        dataGridView_userView.Rows.Remove(dataGridView_userView.SelectedRows[0]);

                        connection.Close();
                    }

                    MessageBox.Show("Usuario eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void button_Apply_Click(object sender, EventArgs e)
        {
            loginUserCA();
            CargaraDatosView();
            limpiarLogin();
        }

        private void limpiarLogin()
        {
            text_loginName.Clear();
            text_Password.Clear();
            textBox_confirmPassword.Clear();
        }

        private void loginUserCA()
        {
            string cadenaConexion = cAux.CadenaConexion;
            // Obtener los valores de los TextBox y el ComboBox
            string loginName = text_loginName.Text;
            string authenticationType = comboBox_authenticationType.SelectedItem.ToString();
            string limitHostsMatching = text_limitHostsMatching.Text;
            string password = text_Password.Text;
            string confirmPassword = textBox_confirmPassword.Text;

            // Verificar si el usuario ya existe en la base de datos
            bool userExists = CheckUserExists(loginName);

            // Verificar si el password y confirmPassword son iguales
            if (password != confirmPassword)
            {
                MessageBox.Show("El password y la confirmación del password no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Construir la sentencia SQL correspondiente (CREATE USER o ALTER USER)
            string sqlQuery;
            if (!userExists)
            {
                sqlQuery = $"CREATE USER '{loginName}'@'{limitHostsMatching}' IDENTIFIED BY '{password}'";
            }
            else
            {
                sqlQuery = $"ALTER USER '{loginName}'@'{limitHostsMatching}' IDENTIFIED BY '{password}'";
                //sqlQuery = $"RENAME USER '{loginName}'@'{limitHostsMatching}' TO '{loginName}_temp'@'{limitHostsMatching}', '{loginName}'@'{limitHostsMatching}' IDENTIFIED BY '{password}'";
                //sqlQuery = $"DROP USER '{loginName}'@'{limitHostsMatching}'; CREATE USER '{loginName}'@'{limitHostsMatching}' IDENTIFIED BY '{password}'";
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    // Ejecutar la sentencia SQL
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                string message = userExists ? "Usuario actualizado correctamente." : "Usuario creado correctamente.";
                MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear o actualizar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool CheckUserExists(string userName)
        {
            string cadenaConexion = cAux.CadenaConexion;
            // Construir la sentencia SQL para verificar si el usuario existe
            string checkUserQuery = $"SELECT COUNT(*) FROM mysql.user WHERE User = '{userName}'";

            using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
            {
                connection.Open();

                // Ejecutar la consulta y obtener el resultado
                using (MySqlCommand command = new MySqlCommand(checkUserQuery, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    connection.Close();

                    return count > 0;
                }
            }
        }

        private void desbloquearLogin()
        {
            //Desbloquear el registro login
            tabPage_Login.Enabled = true;
            button_Revert.Enabled = true;
            button_Apply.Enabled = true;
            tabPage_Account_Limits.Enabled = true;
            tabPage_Administrative_Roles.Enabled = true;
            tabPage_Schema_Privileges.Enabled = true;
            //Bloquea botones de Accion
            button_Delete.Enabled = false;
            button_Refresh.Enabled = false;
        }

        private void bloquearLogin()
        {
            //Bloquear el registro login
            tabPage_Login.Enabled = false;
            button_Revert.Enabled = false;
            button_Apply.Enabled = false;
            tabPage_Account_Limits.Enabled = false;
            tabPage_Administrative_Roles.Enabled = false;
            tabPage_Schema_Privileges.Enabled = false;
            //Desbloquea botones de Accion
            button_Delete.Enabled = true;
            button_Refresh.Enabled = true;
        }

    }
}
