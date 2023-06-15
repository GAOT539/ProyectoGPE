namespace ProyectoSGBD_MySQL.Forms
{
    partial class Form_Dinamico_BD_COL_TAB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dinamico_BD_COL_TAB));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_CreateDataBase = new System.Windows.Forms.Button();
            this.textBox_CreateDataBase = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox_Nombre_Tabla = new System.Windows.Forms.TextBox();
            this.comboBox_DataBase_Tabla = new System.Windows.Forms.ComboBox();
            this.button_Añadir_Tabla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ClavePrimaria_Tabla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_TipoDato_Tabla = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_Null_Columna = new System.Windows.Forms.CheckBox();
            this.comboBox_DataBase_Columna = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_Añadir_Columna = new System.Windows.Forms.Button();
            this.comboBox_TipoDato_Columna = new System.Windows.Forms.ComboBox();
            this.textBox_Atributo_Tabla = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Tabla_Columna = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridView_Muestra = new System.Windows.Forms.DataGridView();
            this.textBox_Consola = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Muestra)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Location = new System.Drawing.Point(16, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 52);
            this.panel2.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1316, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(224, 44);
            this.label17.TabIndex = 0;
            this.label17.Text = "SGBD GPE";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_CreateDataBase);
            this.groupBox1.Controls.Add(this.textBox_CreateDataBase);
            this.groupBox1.Location = new System.Drawing.Point(16, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(411, 466);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base de Datos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox2.Image = global::ProyectoSGBD_MySQL.Properties.Resources._30393;
            this.pictureBox2.Location = new System.Drawing.Point(44, 46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 208);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresa un Nombre:";
            // 
            // button_CreateDataBase
            // 
            this.button_CreateDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_CreateDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CreateDataBase.Location = new System.Drawing.Point(90, 392);
            this.button_CreateDataBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_CreateDataBase.Name = "button_CreateDataBase";
            this.button_CreateDataBase.Size = new System.Drawing.Size(198, 35);
            this.button_CreateDataBase.TabIndex = 1;
            this.button_CreateDataBase.Text = "Crear Base de Datos";
            this.button_CreateDataBase.UseVisualStyleBackColor = true;
            this.button_CreateDataBase.Click += new System.EventHandler(this.button_CreateDataBase_Click);
            // 
            // textBox_CreateDataBase
            // 
            this.textBox_CreateDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_CreateDataBase.Location = new System.Drawing.Point(38, 322);
            this.textBox_CreateDataBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_CreateDataBase.Name = "textBox_CreateDataBase";
            this.textBox_CreateDataBase.Size = new System.Drawing.Size(322, 26);
            this.textBox_CreateDataBase.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.textBox_Nombre_Tabla);
            this.groupBox2.Controls.Add(this.comboBox_DataBase_Tabla);
            this.groupBox2.Controls.Add(this.button_Añadir_Tabla);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_ClavePrimaria_Tabla);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox_TipoDato_Tabla);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(472, 77);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(922, 213);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabla";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::ProyectoSGBD_MySQL.Properties.Resources._981402;
            this.pictureBox3.Location = new System.Drawing.Point(736, 46);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(159, 117);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.button_Añadir_Tabla_Click);
            // 
            // textBox_Nombre_Tabla
            // 
            this.textBox_Nombre_Tabla.Location = new System.Drawing.Point(211, 105);
            this.textBox_Nombre_Tabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Nombre_Tabla.Name = "textBox_Nombre_Tabla";
            this.textBox_Nombre_Tabla.Size = new System.Drawing.Size(224, 26);
            this.textBox_Nombre_Tabla.TabIndex = 4;
            // 
            // comboBox_DataBase_Tabla
            // 
            this.comboBox_DataBase_Tabla.FormattingEnabled = true;
            this.comboBox_DataBase_Tabla.Location = new System.Drawing.Point(211, 43);
            this.comboBox_DataBase_Tabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_DataBase_Tabla.Name = "comboBox_DataBase_Tabla";
            this.comboBox_DataBase_Tabla.Size = new System.Drawing.Size(475, 28);
            this.comboBox_DataBase_Tabla.TabIndex = 8;
            this.comboBox_DataBase_Tabla.SelectedIndexChanged += new System.EventHandler(this.comboBox_DataBase_Tabla_SelectedIndexChanged);
            // 
            // button_Añadir_Tabla
            // 
            this.button_Añadir_Tabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Añadir_Tabla.Location = new System.Drawing.Point(480, 101);
            this.button_Añadir_Tabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Añadir_Tabla.Name = "button_Añadir_Tabla";
            this.button_Añadir_Tabla.Size = new System.Drawing.Size(206, 35);
            this.button_Añadir_Tabla.TabIndex = 4;
            this.button_Añadir_Tabla.Text = "Añadir Tabla";
            this.button_Añadir_Tabla.UseVisualStyleBackColor = true;
            this.button_Añadir_Tabla.Click += new System.EventHandler(this.button_Añadir_Tabla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de la Tabla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Base de Datos:";
            // 
            // textBox_ClavePrimaria_Tabla
            // 
            this.textBox_ClavePrimaria_Tabla.Location = new System.Drawing.Point(211, 162);
            this.textBox_ClavePrimaria_Tabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_ClavePrimaria_Tabla.Name = "textBox_ClavePrimaria_Tabla";
            this.textBox_ClavePrimaria_Tabla.Size = new System.Drawing.Size(162, 26);
            this.textBox_ClavePrimaria_Tabla.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Clave Primaria:";
            // 
            // comboBox_TipoDato_Tabla
            // 
            this.comboBox_TipoDato_Tabla.FormattingEnabled = true;
            this.comboBox_TipoDato_Tabla.Location = new System.Drawing.Point(524, 162);
            this.comboBox_TipoDato_Tabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_TipoDato_Tabla.Name = "comboBox_TipoDato_Tabla";
            this.comboBox_TipoDato_Tabla.Size = new System.Drawing.Size(162, 28);
            this.comboBox_TipoDato_Tabla.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo de Dato:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.checkBox_Null_Columna);
            this.groupBox3.Controls.Add(this.comboBox_DataBase_Columna);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.button_Añadir_Columna);
            this.groupBox3.Controls.Add(this.comboBox_TipoDato_Columna);
            this.groupBox3.Controls.Add(this.textBox_Atributo_Tabla);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboBox_Tabla_Columna);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(472, 300);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(926, 243);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Columna";
            // 
            // checkBox_Null_Columna
            // 
            this.checkBox_Null_Columna.AutoSize = true;
            this.checkBox_Null_Columna.Location = new System.Drawing.Point(574, 122);
            this.checkBox_Null_Columna.Name = "checkBox_Null_Columna";
            this.checkBox_Null_Columna.Size = new System.Drawing.Size(112, 24);
            this.checkBox_Null_Columna.TabIndex = 21;
            this.checkBox_Null_Columna.Text = "NOT NULL";
            this.checkBox_Null_Columna.UseVisualStyleBackColor = true;
            // 
            // comboBox_DataBase_Columna
            // 
            this.comboBox_DataBase_Columna.FormattingEnabled = true;
            this.comboBox_DataBase_Columna.Location = new System.Drawing.Point(211, 66);
            this.comboBox_DataBase_Columna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_DataBase_Columna.Name = "comboBox_DataBase_Columna";
            this.comboBox_DataBase_Columna.Size = new System.Drawing.Size(475, 28);
            this.comboBox_DataBase_Columna.TabIndex = 16;
            this.comboBox_DataBase_Columna.SelectedIndexChanged += new System.EventHandler(this.comboBox_DataBase_Columna_SelectedIndexChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::ProyectoSGBD_MySQL.Properties.Resources._1239779;
            this.pictureBox4.Location = new System.Drawing.Point(736, 29);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(159, 117);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.button_Añadir_Columna_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Base de Datos:";
            // 
            // button_Añadir_Columna
            // 
            this.button_Añadir_Columna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Añadir_Columna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Añadir_Columna.Location = new System.Drawing.Point(736, 174);
            this.button_Añadir_Columna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Añadir_Columna.Name = "button_Añadir_Columna";
            this.button_Añadir_Columna.Size = new System.Drawing.Size(159, 35);
            this.button_Añadir_Columna.TabIndex = 9;
            this.button_Añadir_Columna.Text = "Añadir Columna";
            this.button_Añadir_Columna.UseVisualStyleBackColor = true;
            this.button_Añadir_Columna.Click += new System.EventHandler(this.button_Añadir_Columna_Click);
            // 
            // comboBox_TipoDato_Columna
            // 
            this.comboBox_TipoDato_Columna.FormattingEnabled = true;
            this.comboBox_TipoDato_Columna.Location = new System.Drawing.Point(524, 183);
            this.comboBox_TipoDato_Columna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_TipoDato_Columna.Name = "comboBox_TipoDato_Columna";
            this.comboBox_TipoDato_Columna.Size = new System.Drawing.Size(162, 28);
            this.comboBox_TipoDato_Columna.TabIndex = 20;
            // 
            // textBox_Atributo_Tabla
            // 
            this.textBox_Atributo_Tabla.Location = new System.Drawing.Point(211, 183);
            this.textBox_Atributo_Tabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Atributo_Tabla.Name = "textBox_Atributo_Tabla";
            this.textBox_Atributo_Tabla.Size = new System.Drawing.Size(182, 26);
            this.textBox_Atributo_Tabla.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tipo de Dato:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 186);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Atributo:";
            // 
            // comboBox_Tabla_Columna
            // 
            this.comboBox_Tabla_Columna.FormattingEnabled = true;
            this.comboBox_Tabla_Columna.Location = new System.Drawing.Point(211, 120);
            this.comboBox_Tabla_Columna.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Tabla_Columna.Name = "comboBox_Tabla_Columna";
            this.comboBox_Tabla_Columna.Size = new System.Drawing.Size(332, 28);
            this.comboBox_Tabla_Columna.TabIndex = 16;
            this.comboBox_Tabla_Columna.SelectedIndexChanged += new System.EventHandler(this.comboBox_Tabla_Columna_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tabla:";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.textBox_Consola);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Location = new System.Drawing.Point(16, 551);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1382, 325);
            this.panel5.TabIndex = 47;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.dataGridView_Muestra);
            this.panel9.Location = new System.Drawing.Point(10, 78);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1353, 242);
            this.panel9.TabIndex = 3;
            // 
            // dataGridView_Muestra
            // 
            this.dataGridView_Muestra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Muestra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Muestra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Muestra.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Muestra.Name = "dataGridView_Muestra";
            this.dataGridView_Muestra.ReadOnly = true;
            this.dataGridView_Muestra.RowHeadersWidth = 62;
            this.dataGridView_Muestra.RowTemplate.Height = 28;
            this.dataGridView_Muestra.Size = new System.Drawing.Size(1353, 242);
            this.dataGridView_Muestra.TabIndex = 1;
            // 
            // textBox_Consola
            // 
            this.textBox_Consola.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Consola.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Consola.Location = new System.Drawing.Point(10, 32);
            this.textBox_Consola.Name = "textBox_Consola";
            this.textBox_Consola.Size = new System.Drawing.Size(1351, 31);
            this.textBox_Consola.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Controls.Add(this.label19);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1605, 26);
            this.panel8.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(-2, 0);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(1374, 25);
            this.label19.TabIndex = 5;
            this.label19.Text = "OUTPUT ::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::" +
    "::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::" +
    ":::::::::::::::::::::::::::";
            // 
            // Form_Dinamico_BD_COL_TAB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 886);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Dinamico_BD_COL_TAB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Dinamico_BD_COL_TAB";
            this.Load += new System.EventHandler(this.Form_Dinamico_BD_COL_TAB_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Muestra)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_CreateDataBase;
        private System.Windows.Forms.TextBox textBox_CreateDataBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Añadir_Tabla;
        private System.Windows.Forms.ComboBox comboBox_DataBase_Tabla;
        private System.Windows.Forms.TextBox textBox_Nombre_Tabla;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox_Tabla_Columna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_TipoDato_Tabla;
        private System.Windows.Forms.TextBox textBox_ClavePrimaria_Tabla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Añadir_Columna;
        private System.Windows.Forms.ComboBox comboBox_TipoDato_Columna;
        private System.Windows.Forms.TextBox textBox_Atributo_Tabla;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.DataGridView dataGridView_Muestra;
        private System.Windows.Forms.TextBox textBox_Consola;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox comboBox_DataBase_Columna;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_Null_Columna;
    }
}