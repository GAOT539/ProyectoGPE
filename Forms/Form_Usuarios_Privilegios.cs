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
            }
        }

        private void Form_Usuarios_Privilegios_Load(object sender, EventArgs e)
        {
            CargaraDatosView();
        }

        private void CargaraDatosView()
        {
            string cadenaConexion = "Database=mysql; Data Source=localhost; Port=3306; User Id=root; Password=2001;";
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

        private Color originalBackgroundColor;
        private Color originalTextColor;
        private Color darkBackgroundColor = Color.FromArgb(30, 30, 30);
        private Color darkTextColor = Color.White;
        private void SetTheme()
        {
            if (isDarkModeEnabled)
            {

                // Cambiar a modo oscuro
                BackColor = darkBackgroundColor;
                //ForeColor = darkTextColor;
                // Establecer los colores oscuros para otros controles según sea necesario

                tabControl_accountLimits.BackColor = Color.FromArgb(30, 30, 30);

                // Ajustar el color de las pestañas (TabPages) en el TabControl
                foreach (TabPage tabPage in tabControl_accountLimits.TabPages)
                {
                    tabPage.BackColor = tabControl_accountLimits.BackColor;
                    tabPage.ForeColor = Color.Black; // Color de fuente blanco para mejorar la legibilidad
                }

                // Ajustar el color de fuente del groupBox1-2
                groupBox1.ForeColor = Color.White;
                groupBox2.ForeColor = Color.White;

                dataGridView_userView.ForeColor = originalTextColor;
                

                button_addAccount.ForeColor = darkTextColor;
                button_addAccount.BackColor = darkBackgroundColor;

                button_Delete.ForeColor = darkTextColor;
                button_Delete.BackColor = darkBackgroundColor;

                button_Refresh.ForeColor = darkTextColor;
                button_Refresh.BackColor = darkBackgroundColor;

                button_Revert.ForeColor = darkTextColor;
                button_Revert.BackColor = darkBackgroundColor;

                button_Apply.ForeColor = darkTextColor;
                button_Apply.BackColor = darkBackgroundColor;

                groupBox3.ForeColor = darkTextColor;
                groupBox3.BackColor = SystemColors.ControlDarkDark;

            }
            else
            {
                // Cambiar a modo claro
                BackColor = originalBackgroundColor;
                ForeColor = originalTextColor;
                // Restablecer los colores claros para otros controles según sea necesario

                tabControl_accountLimits.BackColor = SystemColors.Control;

                // Restaurar el color de las pestañas (TabPages) en el TabControl al color original
                foreach (TabPage tabPage in tabControl_accountLimits.TabPages)
                {
                    tabPage.BackColor = tabControl_accountLimits.BackColor;
                    tabPage.ForeColor = SystemColors.ControlText; // Restaurar el color de fuente original
                }

                // Restaurar el color de fuente original del groupBox1-2
                groupBox1.ForeColor = SystemColors.ControlText;
                groupBox2.ForeColor = SystemColors.ControlText;
                groupBox3.ForeColor = originalTextColor;
                groupBox3.BackColor = SystemColors.ControlText;


                button_addAccount.ForeColor = originalTextColor;
                button_addAccount.BackColor = originalBackgroundColor;

                button_Delete.ForeColor = originalTextColor;
                button_Delete.BackColor = originalBackgroundColor;

                button_Refresh.ForeColor = originalTextColor;
                button_Refresh.BackColor = originalBackgroundColor;

                button_Revert.ForeColor = originalTextColor;
                button_Revert.BackColor = originalBackgroundColor;

                button_Apply.ForeColor = originalTextColor;
                button_Apply.BackColor = originalBackgroundColor;
            }
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

    }
}
