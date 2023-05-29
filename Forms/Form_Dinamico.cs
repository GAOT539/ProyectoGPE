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
    public partial class Form_Dinamico : Form
    {
        public Form_Dinamico()
        {
            InitializeComponent();
        }
        public void AbrirCrear(object Forms_Create)
        {
            if (this.panel_CCreate.Controls.Count > 0)
                this.panel_CCreate.Controls.RemoveAt(0);
            Form form = Forms_Create as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel_CCreate.Controls.Add(form);
            this.panel_CCreate.Tag = form;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirCrear(new Forms.Form_CreateBD());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirCrear(new Forms.Form_CreateTabla());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirCrear(new Forms.Form_CreateColumna());
        }
    }
}
