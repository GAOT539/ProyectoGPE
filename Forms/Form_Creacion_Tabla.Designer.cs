namespace ProyectoSGBD_MySQL
{
    partial class Form_Creacion_Tabla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Creacion_Tabla));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Nombre_Tabla = new System.Windows.Forms.TextBox();
            this.comboBox_DataBase_Tabla = new System.Windows.Forms.ComboBox();
            this.button_Añadir_Tabla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Limpiar_Tabla = new System.Windows.Forms.Button();
            this.textBox_ClavePrimaria_Tabla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_TipoDato_Tabla = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_Campos = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Campos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Location = new System.Drawing.Point(11, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 34);
            this.panel2.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(2, 3);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 29);
            this.label17.TabIndex = 0;
            this.label17.Text = "SGBD GPE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(408, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Nombre_Tabla);
            this.groupBox1.Controls.Add(this.comboBox_DataBase_Tabla);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 70);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Base de Datos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_Campos);
            this.groupBox2.Controls.Add(this.textBox_ClavePrimaria_Tabla);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox_TipoDato_Tabla);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button_Limpiar_Tabla);
            this.groupBox2.Controls.Add(this.button_Añadir_Tabla);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 417);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Campos";
            // 
            // textBox_Nombre_Tabla
            // 
            this.textBox_Nombre_Tabla.Location = new System.Drawing.Point(116, 44);
            this.textBox_Nombre_Tabla.Name = "textBox_Nombre_Tabla";
            this.textBox_Nombre_Tabla.Size = new System.Drawing.Size(318, 20);
            this.textBox_Nombre_Tabla.TabIndex = 9;
            // 
            // comboBox_DataBase_Tabla
            // 
            this.comboBox_DataBase_Tabla.FormattingEnabled = true;
            this.comboBox_DataBase_Tabla.Location = new System.Drawing.Point(116, 17);
            this.comboBox_DataBase_Tabla.Name = "comboBox_DataBase_Tabla";
            this.comboBox_DataBase_Tabla.Size = new System.Drawing.Size(318, 21);
            this.comboBox_DataBase_Tabla.TabIndex = 13;
            // 
            // button_Añadir_Tabla
            // 
            this.button_Añadir_Tabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Añadir_Tabla.Location = new System.Drawing.Point(262, 374);
            this.button_Añadir_Tabla.Name = "button_Añadir_Tabla";
            this.button_Añadir_Tabla.Size = new System.Drawing.Size(137, 23);
            this.button_Añadir_Tabla.TabIndex = 10;
            this.button_Añadir_Tabla.Text = "Añadir Tabla";
            this.button_Añadir_Tabla.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre de la Tabla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Base de Datos:";
            // 
            // button_Limpiar_Tabla
            // 
            this.button_Limpiar_Tabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Limpiar_Tabla.Location = new System.Drawing.Point(35, 374);
            this.button_Limpiar_Tabla.Name = "button_Limpiar_Tabla";
            this.button_Limpiar_Tabla.Size = new System.Drawing.Size(137, 23);
            this.button_Limpiar_Tabla.TabIndex = 11;
            this.button_Limpiar_Tabla.Text = "Limpiar Tabla";
            this.button_Limpiar_Tabla.UseVisualStyleBackColor = true;
            // 
            // textBox_ClavePrimaria_Tabla
            // 
            this.textBox_ClavePrimaria_Tabla.Location = new System.Drawing.Point(115, 27);
            this.textBox_ClavePrimaria_Tabla.Name = "textBox_ClavePrimaria_Tabla";
            this.textBox_ClavePrimaria_Tabla.Size = new System.Drawing.Size(109, 20);
            this.textBox_ClavePrimaria_Tabla.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Clave Primaria:";
            // 
            // comboBox_TipoDato_Tabla
            // 
            this.comboBox_TipoDato_Tabla.FormattingEnabled = true;
            this.comboBox_TipoDato_Tabla.Location = new System.Drawing.Point(323, 27);
            this.comboBox_TipoDato_Tabla.Name = "comboBox_TipoDato_Tabla";
            this.comboBox_TipoDato_Tabla.Size = new System.Drawing.Size(109, 21);
            this.comboBox_TipoDato_Tabla.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tipo de Dato:";
            // 
            // dataGridView_Campos
            // 
            this.dataGridView_Campos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Campos.Location = new System.Drawing.Point(7, 67);
            this.dataGridView_Campos.Name = "dataGridView_Campos";
            this.dataGridView_Campos.Size = new System.Drawing.Size(425, 291);
            this.dataGridView_Campos.TabIndex = 31;
            // 
            // Form_Creacion_Tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Creacion_Tabla";
            this.Text = "Form_Creacion_Tabla";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Campos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Nombre_Tabla;
        private System.Windows.Forms.ComboBox comboBox_DataBase_Tabla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Limpiar_Tabla;
        private System.Windows.Forms.Button button_Añadir_Tabla;
        private System.Windows.Forms.DataGridView dataGridView_Campos;
        private System.Windows.Forms.TextBox textBox_ClavePrimaria_Tabla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_TipoDato_Tabla;
        private System.Windows.Forms.Label label5;
    }
}