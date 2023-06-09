namespace ProyectoSGBD_MySQL.Forms
{
    partial class Form_ChatGPT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Respuesta = new System.Windows.Forms.ListBox();
            this.textBox_Pregunta = new System.Windows.Forms.TextBox();
            this.button_Enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Respuesta
            // 
            this.listBox_Respuesta.FormattingEnabled = true;
            this.listBox_Respuesta.ItemHeight = 20;
            this.listBox_Respuesta.Location = new System.Drawing.Point(12, 12);
            this.listBox_Respuesta.Name = "listBox_Respuesta";
            this.listBox_Respuesta.Size = new System.Drawing.Size(756, 204);
            this.listBox_Respuesta.TabIndex = 0;
            // 
            // textBox_Pregunta
            // 
            this.textBox_Pregunta.Location = new System.Drawing.Point(12, 231);
            this.textBox_Pregunta.Name = "textBox_Pregunta";
            this.textBox_Pregunta.Size = new System.Drawing.Size(557, 26);
            this.textBox_Pregunta.TabIndex = 1;
            // 
            // button_Enviar
            // 
            this.button_Enviar.Location = new System.Drawing.Point(599, 228);
            this.button_Enviar.Name = "button_Enviar";
            this.button_Enviar.Size = new System.Drawing.Size(168, 33);
            this.button_Enviar.TabIndex = 2;
            this.button_Enviar.Text = "button_Enviar";
            this.button_Enviar.UseVisualStyleBackColor = true;
            this.button_Enviar.Click += new System.EventHandler(this.button_Enviar_Click);
            // 
            // Form_ChatGPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.button_Enviar);
            this.Controls.Add(this.textBox_Pregunta);
            this.Controls.Add(this.listBox_Respuesta);
            this.Name = "Form_ChatGPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Respuesta;
        private System.Windows.Forms.TextBox textBox_Pregunta;
        private System.Windows.Forms.Button button_Enviar;
    }
}