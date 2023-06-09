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
    }
}
