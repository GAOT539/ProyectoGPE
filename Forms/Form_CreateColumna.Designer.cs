﻿namespace ProyectoSGBD_MySQL.Forms
{
    partial class Form_CreateColumna
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_TiposDatos = new System.Windows.Forms.ComboBox();
            this.button_Ejecutar = new System.Windows.Forms.Button();
            this.textBox_Primaria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_BasesDatos = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.comboBox_TiposDatos);
            this.panel1.Controls.Add(this.button_Ejecutar);
            this.panel1.Controls.Add(this.textBox_Primaria);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_Nombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_BasesDatos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 524);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_TiposDatos
            // 
            this.comboBox_TiposDatos.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TiposDatos.FormattingEnabled = true;
            this.comboBox_TiposDatos.Location = new System.Drawing.Point(747, 260);
            this.comboBox_TiposDatos.Name = "comboBox_TiposDatos";
            this.comboBox_TiposDatos.Size = new System.Drawing.Size(255, 45);
            this.comboBox_TiposDatos.TabIndex = 15;
            // 
            // button_Ejecutar
            // 
            this.button_Ejecutar.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ejecutar.ForeColor = System.Drawing.Color.Black;
            this.button_Ejecutar.Location = new System.Drawing.Point(487, 361);
            this.button_Ejecutar.Name = "button_Ejecutar";
            this.button_Ejecutar.Size = new System.Drawing.Size(353, 111);
            this.button_Ejecutar.TabIndex = 14;
            this.button_Ejecutar.Text = "Ejecutar";
            this.button_Ejecutar.UseVisualStyleBackColor = true;
            this.button_Ejecutar.Click += new System.EventHandler(this.button_Ejecutar_Click);
            // 
            // textBox_Primaria
            // 
            this.textBox_Primaria.Font = new System.Drawing.Font("Consolas", 16F);
            this.textBox_Primaria.Location = new System.Drawing.Point(373, 260);
            this.textBox_Primaria.Name = "textBox_Primaria";
            this.textBox_Primaria.Size = new System.Drawing.Size(307, 45);
            this.textBox_Primaria.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "Columna";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Font = new System.Drawing.Font("Consolas", 16F);
            this.textBox_Nombre.Location = new System.Drawing.Point(373, 151);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(307, 45);
            this.textBox_Nombre.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(52, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre Tabla";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Base de Datos";
            // 
            // comboBox_BasesDatos
            // 
            this.comboBox_BasesDatos.Font = new System.Drawing.Font("Consolas", 16F);
            this.comboBox_BasesDatos.FormattingEnabled = true;
            this.comboBox_BasesDatos.Location = new System.Drawing.Point(373, 43);
            this.comboBox_BasesDatos.Name = "comboBox_BasesDatos";
            this.comboBox_BasesDatos.Size = new System.Drawing.Size(307, 45);
            this.comboBox_BasesDatos.TabIndex = 8;
            // 
            // Form_CreateColumna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 524);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CreateColumna";
            this.Text = "Form_CreateColumna";
            this.Load += new System.EventHandler(this.Form_CreateColumna_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_TiposDatos;
        private System.Windows.Forms.Button button_Ejecutar;
        private System.Windows.Forms.TextBox textBox_Primaria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_BasesDatos;
    }
}