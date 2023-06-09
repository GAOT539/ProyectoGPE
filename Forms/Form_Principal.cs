using System;
using System.Windows.Forms;

namespace ProyectoSGBD_MySQL.Forms
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
            this.MaximizeBox = false; //Bloquear Maximizar
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            cAux cAux = new cAux();
            login.Show();
            login.FormClosed += cAux.cerrarFormulario;
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            string enlace = "https://dev.mysql.com/doc/workbench/en/";

            try
            {
                System.Diagnostics.Process.Start(enlace);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el enlace: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string enlace = "https://forums.mysql.com/list.php?152";

            try
            {
                System.Diagnostics.Process.Start(enlace);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el enlace: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            string enlace = "https://dev.mysql.com/blog-archive/";

            try
            {
                System.Diagnostics.Process.Start(enlace);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el enlace: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
