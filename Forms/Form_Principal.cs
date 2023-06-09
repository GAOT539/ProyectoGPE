﻿using System;
using System.Windows.Forms;

namespace ProyectoSGBD_MySQL.Forms
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
            // Bloquea la maximización del formulario
            this.MaximizeBox = false; 
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            // Este método se activa cuando se hace clic en el pictureBox_Exit.
            // Cierra la aplicación.
            Application.Exit();
        }

        private void panel_Inicio_Click(object sender, EventArgs e)
        {
            // Este método se activa cuando se hace clic en el panel_Inicio.
            // Crea una instancia del formulario de inicio de sesión (Form_Login) y una instancia de cAux.
            // Muestra el formulario de inicio de sesión.
            // Agrega un controlador de eventos para el evento FormClosed, que se ejecuta cuando se cierra el formulario de inicio de sesión.
            // Oculta el formulario actual.
            Form_Login login = new Form_Login();
            cAux cAux = new cAux();
            login.Show();
            login.FormClosed += cAux.cerrarFormulario;
            this.Hide();
        }

        private void label_BrowseDocumentation_Click(object sender, EventArgs e)
        {
            // Este método se activa cuando se hace clic en el label_BrowseDocumentation.
            // Abre un enlace específico en el navegador web predeterminado del sistema.
            string enlace = "https://dev.mysql.com/doc/workbench/en/";

            try
            {
                System.Diagnostics.Process.Start(enlace);
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si ocurre alguna excepción al abrir el enlace.
                MessageBox.Show("Error al abrir el enlace: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label_DiscussForums_Click(object sender, EventArgs e)
        {
            // Este método se activa cuando se hace clic en el label_DiscussForums.
            // Abre un enlace específico en el navegador web predeterminado del sistema.
            string enlace = "https://forums.mysql.com/list.php?152";

            try
            {
                System.Diagnostics.Process.Start(enlace);
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si ocurre alguna excepción al abrir el enlace.
                MessageBox.Show("Error al abrir el enlace: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label_ReadBlog_Click(object sender, EventArgs e)
        {
            // Este método se activa cuando se hace clic en el label_ReadBlog.
            // Abre un enlace específico en el navegador web predeterminado del sistema.
            string enlace = "https://dev.mysql.com/blog-archive/";

            try
            {
                System.Diagnostics.Process.Start(enlace);
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si ocurre alguna excepción al abrir el enlace.
                MessageBox.Show("Error al abrir el enlace: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
