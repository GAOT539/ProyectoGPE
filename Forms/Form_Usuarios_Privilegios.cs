using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoSGBD_MySQL.Forms
{

    public partial class Form_Usuarios_Privilegios : Form
    {

        private bool isDarkModeEnabled;
        
        public Form_Usuarios_Privilegios(bool isDarkModeEnabled)
        {
            InitializeComponent();
            bloquearLogin();//Bloquear el registro login
            label_nombreUser.Text = cAux.NombreConexion;
            //comboBox_authenticationType.SelectedIndex = 0;
            comboBox_authenticationType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.isDarkModeEnabled = isDarkModeEnabled;
            SetTheme();
            dataGridView_userView.CellFormatting += dataGridView1_CellFormatting;

            this.MaximizeBox = false; // Bloquea la maximización del formulario
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Bloquea el cambio de tamaño del formulario
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
                CargarPermisosUsuarios();
            }
        }

        private void CargarPermisosUsuarios()
        {
            string nombreUsuario = text_loginName.Text;
            string host = text_limitHostsMatching.Text;
            string cadenaConexion = cAux.CadenaConexion;

            // Desmarcar todos los elementos del checkedListBox_globalPrivilegios
            for (int i = 0; i < checkedListBox_globalPrivilegios.Items.Count; i++)
            {
                checkedListBox_globalPrivilegios.SetItemChecked(i, false);
            }

            // Crear la consulta SQL para obtener los permisos del usuario
            string sqlQuery = $"SHOW GRANTS FOR '{nombreUsuario}'@'{host}';";

            try
            {
                // Establecer la cadena de conexión y crear una instancia de MySqlConnection
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();

                    // Ejecutar la consulta SQL y leer los resultados
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Crear una lista para almacenar los permisos obtenidos de la consulta
                            List<string> permisosUsuario = new List<string>();

                            while (reader.Read())
                            {
                                string permiso = reader.GetString(0);

                                // Dividir los permisos por comas
                                string[] permisos = permiso.Split(',');

                                // Agregar solo los permisos válidos a la lista
                                foreach (string p in permisos)
                                {
                                    string permisoLimpio = p.Trim(); // Eliminar espacios adicionales

                                    if (EsPermisoValido(permisoLimpio))
                                    {
                                        permisosUsuario.Add(permisoLimpio);
                                    }
                                }
                            }

                            // Recorrer los elementos del checkedListBox_globalPrivilegios y seleccionar los que coincidan con los permisos del usuario
                            for (int i = 0; i < checkedListBox_globalPrivilegios.Items.Count; i++)
                            {
                                string permisoItem = checkedListBox_globalPrivilegios.Items[i].ToString();

                                if (permisosUsuario.Contains(permisoItem))
                                {
                                    checkedListBox_globalPrivilegios.SetItemChecked(i, true);
                                }
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar los permisos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para verificar si un permiso es válido
        private bool EsPermisoValido(string permiso)
        {
            string[] permisosValidos =
            {
                "ALTER",
                "ALTER ROUTINE",
                "CREATE",
                "CREATE ROUTINE",
                "CREATE TABLESPACE",
                "CREATE TEMPORARY TABLES",
                "CREATE USER",
                "CREATE VIEW",
                "DELETE",
                "DROP",
                "EVENT",
                "EXECUTE",
                "FILE",
                "GRANT OPTION",
                "INDEX",
                "INSERT",
                "LOCK TABLES",
                "PROCESS",
                "REFERENCES",
                "RELOAD",
                "REPLICATION CLIENT",
                "REPLICATION SLAVE",
                "SELECT",
                "SHOW DATABASES",
                "SHOW VIEW",
                "SHUTDOWN",
                "SUPER",
                "TRIGGER",
                "UPDATE"
            };

            return permisosValidos.Any(p => permiso.Contains(p));
        }

        private void Form_Usuarios_Privilegios_Load(object sender, EventArgs e)
        {
            CargaraDatosView();
        }
        
        private void CargaraDatosView()
        {
            string cadenaConexion = cAux.CadenaConexion;
            string sqlQuery = "SELECT User, Host FROM mysql.user WHERE User <> 'root' AND User NOT LIKE 'mysql%';";
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
            textos_TabPage();
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
            PermisosUsuarios();
            limpiarLogin();
            bloquearLogin();
        }

        private void PermisosUsuarios()
        {
            // Obtener el nombre de usuario del texto del control TextBox
            string loginName = text_loginName.Text;
            string host = text_limitHostsMatching.Text;

            // Obtener los permisos seleccionados del CheckedListBox
            List<string> permisosSeleccionados = new List<string>();
            foreach (object itemChecked in checkedListBox_globalPrivilegios.CheckedItems)
            {
                permisosSeleccionados.Add(itemChecked.ToString());
            }

            // Obtener los permisos deseleccionados del CheckedListBox
            List<string> permisosDeseleccionados = new List<string>();
            foreach (object itemUnchecked in checkedListBox_globalPrivilegios.Items)
            {
                string permiso = itemUnchecked.ToString();
                if (!checkedListBox_globalPrivilegios.CheckedItems.Contains(itemUnchecked))
                {
                    permisosDeseleccionados.Add(permiso);
                }
            }

            // Crear la cadena de conexión a MySQL
            string cadenaConexion = cAux.CadenaConexion;

            // Crear la consulta SQL para asignar los permisos al usuario
            string sqlQuery = "";

            if (permisosSeleccionados.Count > 0)
            {
                sqlQuery += $"GRANT {string.Join(", ", permisosSeleccionados)} ON *.* TO '{loginName}'@'{host}' WITH GRANT OPTION;";
            }

            if (permisosDeseleccionados.Count > 0)
            {
                sqlQuery += $"REVOKE {string.Join(", ", permisosDeseleccionados)} ON *.* FROM '{loginName}'@'{host}';";
            }

            // Ejecutar la consulta SQL
            try
            {
                using (MySqlConnection connection = new MySqlConnection(cadenaConexion))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                MessageBox.Show("Permisos asignados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al asignar permisos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            button_addAccount.Enabled = false;
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
            button_addAccount.Enabled = true;
        }
               
        private void SetTheme()
        {
            if (isDarkModeEnabled)
            {
                groupBox_Encabezado.ForeColor = Color.White;
                groupBox_UseAccounts.ForeColor = Color.White;
                groupBox_Details.ForeColor = Color.White;
                panel_Fondo.BackColor = Color.FromArgb(65, 65, 65);
                button_CargarPermisos.ForeColor = Color.Black;
                button_AsignarPermisosUsuarios.ForeColor = Color.Black;
                button_AsignarRoles.ForeColor = Color.Black;
                button_CargarRoles.ForeColor = Color.Black;
            }
        }

        private void textos_TabPage()
        {
            tabControl_accountLimits.ForeColor = Color.Black;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (isDarkModeEnabled)
            {
                // Establecer el color de fuente de las celdas en negro
                e.CellStyle.ForeColor = Color.Black;
            }
            else
            {
                // Restaurar el color de fuente predeterminado
                e.CellStyle.ForeColor = dataGridView_userView.DefaultCellStyle.ForeColor;
            }
        }
        
        private void button_RolesAdmin_Click(object sender, EventArgs e)
        {
            PermisosUsuarios();
        }

        private void button_CargarPermisos_Click(object sender, EventArgs e)
        {
            CargarPermisosUsuarios();
        }

        private void button_CargarRoles_Click(object sender, EventArgs e)
        {
            CargarRolesUsuarios();
        }

        private void CargarRolesUsuarios()
        {
            throw new NotImplementedException();
        }

        private void AsignarRolesUsuario()
        {
            throw new NotImplementedException();
        }

        private void button_AsignarRoles_Click(object sender, EventArgs e)
        {
            AsignarRolesUsuario();
        }
    }
}
