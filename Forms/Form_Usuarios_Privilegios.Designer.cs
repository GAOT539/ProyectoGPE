namespace ProyectoSGBD_MySQL.Forms
{
    partial class Form_Usuarios_Privilegios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Usuarios_Privilegios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Login = new System.Windows.Forms.TabPage();
            this.tabPage_Account_Limits = new System.Windows.Forms.TabPage();
            this.tabPage_Administrative_Roles = new System.Windows.Forms.TabPage();
            this.tabPage_Schema_Privileges = new System.Windows.Forms.TabPage();
            this.button_Add_Account = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_Revert = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_Confirm_Password = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.text_Limit_Hosts_Matching = new System.Windows.Forms.TextBox();
            this.text_Password = new System.Windows.Forms.TextBox();
            this.text_Login_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Authentication_Type = new System.Windows.Forms.ComboBox();
            this.button_Expire_Password = new System.Windows.Forms.Button();
            this.textBox_Authentication_String = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox_Roles = new System.Windows.Forms.GroupBox();
            this.groupBox_Global_Privileges = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_Login.SuspendLayout();
            this.tabPage_Account_Limits.SuspendLayout();
            this.tabPage_Administrative_Roles.SuspendLayout();
            this.groupBox_Roles.SuspendLayout();
            this.groupBox_Global_Privileges.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1031, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(4, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 379);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Accounts";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(210, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(825, 459);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details for account root@localhost";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoSGBD_MySQL.Properties.Resources.user_person_people_6100;
            this.pictureBox1.Location = new System.Drawing.Point(8, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users and Privileges";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nobre de la BD que me conecte";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(187, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Login);
            this.tabControl1.Controls.Add(this.tabPage_Account_Limits);
            this.tabControl1.Controls.Add(this.tabPage_Administrative_Roles);
            this.tabControl1.Controls.Add(this.tabPage_Schema_Privileges);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(7, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Login
            // 
            this.tabPage_Login.Controls.Add(this.label15);
            this.tabPage_Login.Controls.Add(this.label14);
            this.tabPage_Login.Controls.Add(this.label13);
            this.tabPage_Login.Controls.Add(this.label12);
            this.tabPage_Login.Controls.Add(this.label11);
            this.tabPage_Login.Controls.Add(this.label10);
            this.tabPage_Login.Controls.Add(this.label9);
            this.tabPage_Login.Controls.Add(this.label5);
            this.tabPage_Login.Controls.Add(this.textBox_Authentication_String);
            this.tabPage_Login.Controls.Add(this.label4);
            this.tabPage_Login.Controls.Add(this.button_Expire_Password);
            this.tabPage_Login.Controls.Add(this.comboBox_Authentication_Type);
            this.tabPage_Login.Controls.Add(this.textBox_Confirm_Password);
            this.tabPage_Login.Controls.Add(this.label34);
            this.tabPage_Login.Controls.Add(this.text_Limit_Hosts_Matching);
            this.tabPage_Login.Controls.Add(this.text_Password);
            this.tabPage_Login.Controls.Add(this.text_Login_Name);
            this.tabPage_Login.Controls.Add(this.label8);
            this.tabPage_Login.Controls.Add(this.label7);
            this.tabPage_Login.Controls.Add(this.label6);
            this.tabPage_Login.Controls.Add(this.label3);
            this.tabPage_Login.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Login.Name = "tabPage_Login";
            this.tabPage_Login.Size = new System.Drawing.Size(804, 407);
            this.tabPage_Login.TabIndex = 0;
            this.tabPage_Login.Text = "Login";
            this.tabPage_Login.UseVisualStyleBackColor = true;
            // 
            // tabPage_Account_Limits
            // 
            this.tabPage_Account_Limits.Controls.Add(this.label22);
            this.tabPage_Account_Limits.Controls.Add(this.label20);
            this.tabPage_Account_Limits.Controls.Add(this.label18);
            this.tabPage_Account_Limits.Controls.Add(this.textBox4);
            this.tabPage_Account_Limits.Controls.Add(this.label23);
            this.tabPage_Account_Limits.Controls.Add(this.textBox3);
            this.tabPage_Account_Limits.Controls.Add(this.label21);
            this.tabPage_Account_Limits.Controls.Add(this.textBox2);
            this.tabPage_Account_Limits.Controls.Add(this.label19);
            this.tabPage_Account_Limits.Controls.Add(this.label16);
            this.tabPage_Account_Limits.Controls.Add(this.textBox1);
            this.tabPage_Account_Limits.Controls.Add(this.label17);
            this.tabPage_Account_Limits.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Account_Limits.Name = "tabPage_Account_Limits";
            this.tabPage_Account_Limits.Size = new System.Drawing.Size(804, 407);
            this.tabPage_Account_Limits.TabIndex = 1;
            this.tabPage_Account_Limits.Text = "Account Limits";
            this.tabPage_Account_Limits.UseVisualStyleBackColor = true;
            // 
            // tabPage_Administrative_Roles
            // 
            this.tabPage_Administrative_Roles.Controls.Add(this.groupBox_Global_Privileges);
            this.tabPage_Administrative_Roles.Controls.Add(this.groupBox_Roles);
            this.tabPage_Administrative_Roles.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Administrative_Roles.Name = "tabPage_Administrative_Roles";
            this.tabPage_Administrative_Roles.Size = new System.Drawing.Size(804, 407);
            this.tabPage_Administrative_Roles.TabIndex = 2;
            this.tabPage_Administrative_Roles.Text = "Administrative Roles";
            this.tabPage_Administrative_Roles.UseVisualStyleBackColor = true;
            // 
            // tabPage_Schema_Privileges
            // 
            this.tabPage_Schema_Privileges.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Schema_Privileges.Name = "tabPage_Schema_Privileges";
            this.tabPage_Schema_Privileges.Size = new System.Drawing.Size(804, 407);
            this.tabPage_Schema_Privileges.TabIndex = 3;
            this.tabPage_Schema_Privileges.Text = "Schema Privileges";
            this.tabPage_Schema_Privileges.UseVisualStyleBackColor = true;
            // 
            // button_Add_Account
            // 
            this.button_Add_Account.Location = new System.Drawing.Point(6, 563);
            this.button_Add_Account.Name = "button_Add_Account";
            this.button_Add_Account.Size = new System.Drawing.Size(105, 23);
            this.button_Add_Account.TabIndex = 2;
            this.button_Add_Account.Text = "Add Account";
            this.button_Add_Account.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(117, 563);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 3;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(198, 563);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(75, 23);
            this.button_Refresh.TabIndex = 4;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(960, 563);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(75, 23);
            this.button_Apply.TabIndex = 6;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            // 
            // button_Revert
            // 
            this.button_Revert.Location = new System.Drawing.Point(879, 563);
            this.button_Revert.Name = "button_Revert";
            this.button_Revert.Size = new System.Drawing.Size(75, 23);
            this.button_Revert.TabIndex = 5;
            this.button_Revert.Text = "Revert";
            this.button_Revert.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "User";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "From Host";
            this.Column2.Name = "Column2";
            // 
            // textBox_Confirm_Password
            // 
            this.textBox_Confirm_Password.Enabled = false;
            this.textBox_Confirm_Password.Location = new System.Drawing.Point(136, 169);
            this.textBox_Confirm_Password.Name = "textBox_Confirm_Password";
            this.textBox_Confirm_Password.Size = new System.Drawing.Size(144, 20);
            this.textBox_Confirm_Password.TabIndex = 36;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(36, 172);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(94, 13);
            this.label34.TabIndex = 35;
            this.label34.Text = "Confirm Password:";
            // 
            // text_Limit_Hosts_Matching
            // 
            this.text_Limit_Hosts_Matching.Location = new System.Drawing.Point(136, 73);
            this.text_Limit_Hosts_Matching.Name = "text_Limit_Hosts_Matching";
            this.text_Limit_Hosts_Matching.Size = new System.Drawing.Size(144, 20);
            this.text_Limit_Hosts_Matching.TabIndex = 34;
            // 
            // text_Password
            // 
            this.text_Password.Location = new System.Drawing.Point(136, 104);
            this.text_Password.Name = "text_Password";
            this.text_Password.Size = new System.Drawing.Size(144, 20);
            this.text_Password.TabIndex = 33;
            // 
            // text_Login_Name
            // 
            this.text_Login_Name.Location = new System.Drawing.Point(136, 13);
            this.text_Login_Name.Name = "text_Login_Name";
            this.text_Login_Name.Size = new System.Drawing.Size(144, 20);
            this.text_Login_Name.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Limit to Hosts Matching:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Authentication Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Login Name:";
            // 
            // comboBox_Authentication_Type
            // 
            this.comboBox_Authentication_Type.Enabled = false;
            this.comboBox_Authentication_Type.FormattingEnabled = true;
            this.comboBox_Authentication_Type.Items.AddRange(new object[] {
            "No",
            "If availabre",
            "Require",
            "Require and Verify CA",
            "Require and Verify Identity"});
            this.comboBox_Authentication_Type.Location = new System.Drawing.Point(136, 43);
            this.comboBox_Authentication_Type.Name = "comboBox_Authentication_Type";
            this.comboBox_Authentication_Type.Size = new System.Drawing.Size(144, 21);
            this.comboBox_Authentication_Type.TabIndex = 46;
            // 
            // button_Expire_Password
            // 
            this.button_Expire_Password.Location = new System.Drawing.Point(136, 196);
            this.button_Expire_Password.Name = "button_Expire_Password";
            this.button_Expire_Password.Size = new System.Drawing.Size(144, 23);
            this.button_Expire_Password.TabIndex = 7;
            this.button_Expire_Password.Text = "Expire Password";
            this.button_Expire_Password.UseVisualStyleBackColor = true;
            // 
            // textBox_Authentication_String
            // 
            this.textBox_Authentication_String.Enabled = false;
            this.textBox_Authentication_String.Location = new System.Drawing.Point(136, 225);
            this.textBox_Authentication_String.Name = "textBox_Authentication_String";
            this.textBox_Authentication_String.Size = new System.Drawing.Size(144, 20);
            this.textBox_Authentication_String.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Authentication String:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "You may create multiple accounts with the same name to connect from diferent host" +
    ";";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(388, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "For the standard password and/or host based authenticacion, select \"Standard\".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "% and_widcards may be used";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Type a password to reset it.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(524, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Consider using a password with 8 or more characters with mixed case letters, numb" +
    "ers and punctuation marks.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(286, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Enter password again to confirm.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(286, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(203, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Authentication plugin specific parameters.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(74, 261);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(258, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "See plugin authentication for valid values and details.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(218, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(293, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Number of queries the account can execute within one hour.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 50;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(64, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "Max. Queries:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 20);
            this.textBox2.TabIndex = 53;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(60, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 54;
            this.label19.Text = "Max. Updates:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 20);
            this.textBox3.TabIndex = 56;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(41, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 13);
            this.label21.TabIndex = 57;
            this.label21.Text = "Max. Connections:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(142, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(66, 20);
            this.textBox4.TabIndex = 59;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 128);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(124, 13);
            this.label23.TabIndex = 60;
            this.label23.Text = "Concurrent Connections:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(218, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(297, 13);
            this.label18.TabIndex = 61;
            this.label18.Text = "Number of updates the account can execute within one hour.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(218, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(303, 13);
            this.label20.TabIndex = 62;
            this.label20.Text = "The number of times the account can execute within one hour.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(218, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(463, 13);
            this.label22.TabIndex = 63;
            this.label22.Text = "The number of simultaneous connections to the server the account can execute with" +
    "in one hour.";
            // 
            // groupBox_Roles
            // 
            this.groupBox_Roles.Controls.Add(this.checkedListBox1);
            this.groupBox_Roles.Location = new System.Drawing.Point(14, 12);
            this.groupBox_Roles.Name = "groupBox_Roles";
            this.groupBox_Roles.Size = new System.Drawing.Size(536, 204);
            this.groupBox_Roles.TabIndex = 0;
            this.groupBox_Roles.TabStop = false;
            this.groupBox_Roles.Text = "Roles";
            // 
            // groupBox_Global_Privileges
            // 
            this.groupBox_Global_Privileges.Controls.Add(this.checkedListBox2);
            this.groupBox_Global_Privileges.Location = new System.Drawing.Point(556, 12);
            this.groupBox_Global_Privileges.Name = "groupBox_Global_Privileges";
            this.groupBox_Global_Privileges.Size = new System.Drawing.Size(231, 374);
            this.groupBox_Global_Privileges.TabIndex = 1;
            this.groupBox_Global_Privileges.TabStop = false;
            this.groupBox_Global_Privileges.Text = "Global Privileges";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "DBA   => Grants the rights to perform all tasks.",
            "MaintenanceAdmin   => Grants rights needed to maintain server.",
            "ProcessAdmin   => Rights needed to assess, monitor, and kill any user process run" +
                "ning in server.",
            "UserAdmin   => Grants rights to create users logins and reset passwords.",
            "SecurityAdmin   => Rights to manager logins and grant and revoke server and datab" +
                "ase level permission.",
            "MonitorAdmin   => Minimum set of rights needed to monitor server.",
            "DBManager   => Grants full rights on all databases.",
            "DBDesiger   => Rights to create and reverse engineer any database schema.",
            "ReplicationAdmin    => Rights needed to setup and manage replication.",
            "BackupAdmin   => Minimal rights needed to backup any database.",
            "Custom   => Custom role."});
            this.checkedListBox1.Location = new System.Drawing.Point(7, 21);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(523, 169);
            this.checkedListBox1.TabIndex = 0;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "ALTER",
            "ALTER ROUTINE",
            "CREATE",
            "CREATE ROUTINE",
            "CREATE TABLESPACE",
            "CREATE TEMPORARY TABLES",
            "CREATE USER",
            "CREATE VIEW",
            "DELETE",
            "DROP",
            "EVENT",
            "EXECUTE",
            "FILE",
            "GRANT OPTION",
            "INDEX",
            "INSERT",
            "LOCK TABLES",
            "PROCESS",
            "REFERENCES",
            "RELOAD",
            "REPLICATION CLIENT",
            "REPLICATION SLAVE",
            "SELECT",
            "SHOW DATABASES",
            "SHOW VIEW",
            "SHUTDOWN",
            "SUPER",
            "TRIGGER",
            "UPDATE"});
            this.checkedListBox2.Location = new System.Drawing.Point(8, 20);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(223, 364);
            this.checkedListBox2.TabIndex = 0;
            // 
            // Form_Usuarios_Privilegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 598);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.button_Revert);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add_Account);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Usuarios_Privilegios";
            this.Text = "Form_Usuarios_Privilegios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Login.ResumeLayout(false);
            this.tabPage_Login.PerformLayout();
            this.tabPage_Account_Limits.ResumeLayout(false);
            this.tabPage_Account_Limits.PerformLayout();
            this.tabPage_Administrative_Roles.ResumeLayout(false);
            this.groupBox_Roles.ResumeLayout(false);
            this.groupBox_Global_Privileges.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Login;
        private System.Windows.Forms.TabPage tabPage_Account_Limits;
        private System.Windows.Forms.TabPage tabPage_Administrative_Roles;
        private System.Windows.Forms.TabPage tabPage_Schema_Privileges;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button button_Add_Account;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_Revert;
        private System.Windows.Forms.TextBox textBox_Confirm_Password;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox text_Limit_Hosts_Matching;
        private System.Windows.Forms.TextBox text_Password;
        private System.Windows.Forms.TextBox text_Login_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Authentication_Type;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Authentication_String;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Expire_Password;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox_Global_Privileges;
        private System.Windows.Forms.GroupBox groupBox_Roles;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
    }
}