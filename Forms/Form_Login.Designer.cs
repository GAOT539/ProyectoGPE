namespace ProyectoSGBD_MySQL.Forms
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.button_TestConnection = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Connection = new System.Windows.Forms.Button();
            this.button_ConfigureServerManagement = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox_Password = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox_DefaultSchema = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_NameBD = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Hostname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBox_ConnectionMethod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ConnectionName = new System.Windows.Forms.ComboBox();
            this.button_Saver = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_TestConnection
            // 
            this.button_TestConnection.Location = new System.Drawing.Point(736, 480);
            this.button_TestConnection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_TestConnection.Name = "button_TestConnection";
            this.button_TestConnection.Size = new System.Drawing.Size(165, 35);
            this.button_TestConnection.TabIndex = 22;
            this.button_TestConnection.Text = "Test Connection";
            this.button_TestConnection.UseVisualStyleBackColor = true;
            this.button_TestConnection.Click += new System.EventHandler(this.button_TestConnection_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(616, 480);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(112, 35);
            this.button_Exit.TabIndex = 21;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Connection
            // 
            this.button_Connection.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Connection.FlatAppearance.BorderSize = 2;
            this.button_Connection.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Connection.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Connection.Location = new System.Drawing.Point(909, 480);
            this.button_Connection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Connection.Name = "button_Connection";
            this.button_Connection.Size = new System.Drawing.Size(112, 35);
            this.button_Connection.TabIndex = 20;
            this.button_Connection.Text = "Connection";
            this.button_Connection.UseVisualStyleBackColor = true;
            this.button_Connection.Click += new System.EventHandler(this.button_Connection_Control_Click);
            // 
            // button_ConfigureServerManagement
            // 
            this.button_ConfigureServerManagement.Enabled = false;
            this.button_ConfigureServerManagement.Location = new System.Drawing.Point(30, 480);
            this.button_ConfigureServerManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ConfigureServerManagement.Name = "button_ConfigureServerManagement";
            this.button_ConfigureServerManagement.Size = new System.Drawing.Size(288, 35);
            this.button_ConfigureServerManagement.TabIndex = 19;
            this.button_ConfigureServerManagement.Text = "Configure Server Management";
            this.button_ConfigureServerManagement.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(26, 122);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 348);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox_Password);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.textBox_DefaultSchema);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.textBox_Password);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBox_Port);
            this.tabPage1.Controls.Add(this.textBox_NameBD);
            this.tabPage1.Controls.Add(this.textBox_Username);
            this.tabPage1.Controls.Add(this.textBox_Hostname);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(991, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parameters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox_Password
            // 
            this.checkBox_Password.AutoSize = true;
            this.checkBox_Password.Location = new System.Drawing.Point(612, 123);
            this.checkBox_Password.Name = "checkBox_Password";
            this.checkBox_Password.Size = new System.Drawing.Size(22, 21);
            this.checkBox_Password.TabIndex = 28;
            this.checkBox_Password.UseVisualStyleBackColor = true;
            this.checkBox_Password.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(662, 227);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(282, 20);
            this.label33.TabIndex = 27;
            this.label33.Text = "The schema to use as default schema.";
            // 
            // textBox_DefaultSchema
            // 
            this.textBox_DefaultSchema.Enabled = false;
            this.textBox_DefaultSchema.Location = new System.Drawing.Point(183, 221);
            this.textBox_DefaultSchema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_DefaultSchema.Name = "textBox_DefaultSchema";
            this.textBox_DefaultSchema.Size = new System.Drawing.Size(451, 26);
            this.textBox_DefaultSchema.TabIndex = 26;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(27, 224);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(128, 20);
            this.label34.TabIndex = 25;
            this.label34.Text = "Default Schema:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(183, 120);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(422, 26);
            this.textBox_Password.TabIndex = 24;
            this.textBox_Password.Text = "2001";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(662, 171);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "The name of the database";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(662, 123);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "The user\'s password.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(662, 78);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Name of the user to connect with.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(662, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(280, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Name or IP address of the server host.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Port:";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(453, 28);
            this.textBox_Port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(181, 26);
            this.textBox_Port.TabIndex = 19;
            this.textBox_Port.Text = "3306";
            // 
            // textBox_NameBD
            // 
            this.textBox_NameBD.Location = new System.Drawing.Point(183, 168);
            this.textBox_NameBD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_NameBD.Name = "textBox_NameBD";
            this.textBox_NameBD.Size = new System.Drawing.Size(451, 26);
            this.textBox_NameBD.TabIndex = 18;
            this.textBox_NameBD.Text = "mysql";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(183, 72);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(451, 26);
            this.textBox_Username.TabIndex = 16;
            this.textBox_Username.Text = "root";
            // 
            // textBox_Hostname
            // 
            this.textBox_Hostname.Location = new System.Drawing.Point(183, 28);
            this.textBox_Hostname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Hostname.Name = "textBox_Hostname";
            this.textBox_Hostname.Size = new System.Drawing.Size(181, 26);
            this.textBox_Hostname.TabIndex = 12;
            this.textBox_Hostname.Text = "localhost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Name BD:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hostname:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.textBox11);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(991, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SSL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(688, 208);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(262, 20);
            this.label15.TabIndex = 48;
            this.label15.Text = "Optional: separed list of permissible.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(688, 163);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(257, 20);
            this.label14.TabIndex = 47;
            this.label14.Text = "Path to Client Authority file for SSL.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(688, 120);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(266, 20);
            this.label18.TabIndex = 46;
            this.label18.Text = "Path to Client Certificate file for SSL.";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "No",
            "If availabre",
            "Require",
            "Require and Verify CA",
            "Require and Verify Identity"});
            this.comboBox2.Location = new System.Drawing.Point(184, 22);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(468, 28);
            this.comboBox2.TabIndex = 45;
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(594, 158);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(63, 31);
            this.button11.TabIndex = 44;
            this.button11.Text = " ...";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(594, 118);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(63, 31);
            this.button10.TabIndex = 43;
            this.button10.Text = " ...";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(594, 71);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 31);
            this.button9.TabIndex = 42;
            this.button9.Text = " ...";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(184, 203);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(470, 26);
            this.textBox11.TabIndex = 41;
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(184, 115);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(398, 26);
            this.textBox10.TabIndex = 40;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(50, 214);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 20);
            this.label23.TabIndex = 39;
            this.label23.Text = "SSL Cipher:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(688, 75);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(220, 20);
            this.label16.TabIndex = 36;
            this.label16.Text = "Path to Client Key file for SSL.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(688, 26);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(187, 20);
            this.label17.TabIndex = 24;
            this.label17.Text = "Turns on SSL encryption.";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(184, 158);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(398, 26);
            this.textBox7.TabIndex = 33;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(349, 266);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 35);
            this.button7.TabIndex = 32;
            this.button7.Text = "Files ...";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(176, 266);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(165, 35);
            this.button8.TabIndex = 25;
            this.button8.Text = "SSL Wizard ...";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(184, 71);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(398, 26);
            this.textBox8.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(45, 169);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 20);
            this.label19.TabIndex = 30;
            this.label19.Text = "SSL CA File:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 126);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 20);
            this.label20.TabIndex = 29;
            this.label20.Text = "SSL CERT File:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(42, 82);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 20);
            this.label21.TabIndex = 28;
            this.label21.Text = "SSL Key File:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(69, 35);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 20);
            this.label22.TabIndex = 27;
            this.label22.Text = "Use SSL:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.textBox12);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.checkedListBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(991, 315);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Advanced";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(632, 265);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(243, 20);
            this.label30.TabIndex = 53;
            this.label30.Text = "Other options for Connector/C++.";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(632, 220);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(285, 20);
            this.label31.TabIndex = 52;
            this.label31.Text = "Override the default SQL_MODE uded.";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(632, 171);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(309, 20);
            this.label32.TabIndex = 51;
            this.label32.Text = "Maximum time to wait before a connection.";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(632, 120);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(238, 20);
            this.label27.TabIndex = 50;
            this.label27.Text = "Send user password in cleartext.";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(632, 75);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(343, 20);
            this.label28.TabIndex = 49;
            this.label28.Text = "Id enabled this option overwrites the serverside.";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(632, 26);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(285, 20);
            this.label29.TabIndex = 48;
            this.label29.Text = "Select this option for Wan connections.";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(189, 214);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(420, 26);
            this.textBox6.TabIndex = 47;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(189, 128);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(420, 26);
            this.textBox9.TabIndex = 46;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(92, 225);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 20);
            this.label24.TabIndex = 45;
            this.label24.Text = "Others:";
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(189, 171);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(420, 26);
            this.textBox12.TabIndex = 44;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(50, 182);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(102, 20);
            this.label25.TabIndex = 43;
            this.label25.Text = "SQL_MODE:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(72, 138);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 20);
            this.label26.TabIndex = 42;
            this.label26.Text = "Timeout:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Use compression",
            "Use ANSI quotes to quote identifiers",
            "Enable Cleartext Authentication Plugin"});
            this.checkedListBox1.Location = new System.Drawing.Point(96, 26);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(344, 73);
            this.checkedListBox1.TabIndex = 0;
            // 
            // comboBox_ConnectionMethod
            // 
            this.comboBox_ConnectionMethod.Enabled = false;
            this.comboBox_ConnectionMethod.FormattingEnabled = true;
            this.comboBox_ConnectionMethod.Items.AddRange(new object[] {
            "Standard (TCP/IP)",
            "Local Socket/Pipe",
            "Standard (TCP/IP) over SSH",
            "LDAP User/Password",
            "LDAPSasl/Kerberos",
            "NativeKerberos"});
            this.comboBox_ConnectionMethod.Location = new System.Drawing.Point(189, 65);
            this.comboBox_ConnectionMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_ConnectionMethod.Name = "comboBox_ConnectionMethod";
            this.comboBox_ConnectionMethod.Size = new System.Drawing.Size(451, 28);
            this.comboBox_ConnectionMethod.TabIndex = 17;
            this.comboBox_ConnectionMethod.Text = "Standard (TCP/IP)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Method to use to connect to the RDBMS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(673, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Type a name for the connection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Connection Method:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Connection Name:";
            // 
            // comboBox_ConnectionName
            // 
            this.comboBox_ConnectionName.FormattingEnabled = true;
            this.comboBox_ConnectionName.Location = new System.Drawing.Point(189, 25);
            this.comboBox_ConnectionName.Name = "comboBox_ConnectionName";
            this.comboBox_ConnectionName.Size = new System.Drawing.Size(451, 28);
            this.comboBox_ConnectionName.TabIndex = 23;
            this.comboBox_ConnectionName.Text = "Local instance MySQL80";
            this.comboBox_ConnectionName.SelectedIndexChanged += new System.EventHandler(this.comboBox_ConnectionName_SelectedIndexChanged);
            // 
            // button_Saver
            // 
            this.button_Saver.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Saver.FlatAppearance.BorderSize = 2;
            this.button_Saver.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Saver.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Saver.Location = new System.Drawing.Point(496, 480);
            this.button_Saver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Saver.Name = "button_Saver";
            this.button_Saver.Size = new System.Drawing.Size(112, 35);
            this.button_Saver.TabIndex = 24;
            this.button_Saver.Text = "Saver";
            this.button_Saver.UseVisualStyleBackColor = true;
            this.button_Saver.Click += new System.EventHandler(this.button_Saver_Click);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 536);
            this.Controls.Add(this.button_Saver);
            this.Controls.Add(this.comboBox_ConnectionName);
            this.Controls.Add(this.button_TestConnection);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Connection);
            this.Controls.Add(this.button_ConfigureServerManagement);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox_ConnectionMethod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_TestConnection;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Connection;
        private System.Windows.Forms.Button button_ConfigureServerManagement;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkBox_Password;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBox_DefaultSchema;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.TextBox textBox_NameBD;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Hostname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox_ConnectionMethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ConnectionName;
        private System.Windows.Forms.Button button_Saver;
    }
}