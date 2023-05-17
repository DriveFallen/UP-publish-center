namespace Издательский_центр
{
    partial class Form_redactor_users
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
            this.components = new System.ComponentModel.Container();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.comboBoxRoleAdd = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSurnameAdd = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPasswordAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLoginAdd = new System.Windows.Forms.TextBox();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.comboBoxRoleUpdate = new System.Windows.Forms.ComboBox();
            this.textBoxSurnameUpdate = new System.Windows.Forms.TextBox();
            this.textBoxNameUpdate = new System.Windows.Forms.TextBox();
            this.textBoxPasswordUpdate = new System.Windows.Forms.TextBox();
            this.textBoxLoginUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.comboBoxLoginDelete = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridViewWriters = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.издательский_центрDataSet = new Издательский_центр.Издательский_центрDataSet();
            this.usersTableAdapter = new Издательский_центр.Издательский_центрDataSetTableAdapters.UsersTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(1586, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(37, 36);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "X";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Controls.Add(this.tabPageUpdate);
            this.tabControl1.Controls.Add(this.tabPageDelete);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(10, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 741);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPageAdd.Controls.Add(this.comboBoxRoleAdd);
            this.tabPageAdd.Controls.Add(this.label13);
            this.tabPageAdd.Controls.Add(this.textBoxSurnameAdd);
            this.tabPageAdd.Controls.Add(this.buttonAdd);
            this.tabPageAdd.Controls.Add(this.label4);
            this.tabPageAdd.Controls.Add(this.label3);
            this.tabPageAdd.Controls.Add(this.textBoxNameAdd);
            this.tabPageAdd.Controls.Add(this.label2);
            this.tabPageAdd.Controls.Add(this.textBoxPasswordAdd);
            this.tabPageAdd.Controls.Add(this.label1);
            this.tabPageAdd.Controls.Add(this.textBoxLoginAdd);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 32);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(588, 705);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Добавить";
            // 
            // comboBoxRoleAdd
            // 
            this.comboBoxRoleAdd.AutoCompleteCustomSource.AddRange(new string[] {
            "Admin",
            "Writer"});
            this.comboBoxRoleAdd.FormattingEnabled = true;
            this.comboBoxRoleAdd.Items.AddRange(new object[] {
            "Admin",
            "Writer"});
            this.comboBoxRoleAdd.Location = new System.Drawing.Point(201, 452);
            this.comboBoxRoleAdd.Name = "comboBoxRoleAdd";
            this.comboBoxRoleAdd.Size = new System.Drawing.Size(179, 31);
            this.comboBoxRoleAdd.TabIndex = 11;
            this.comboBoxRoleAdd.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoleAdd_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(249, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 24);
            this.label13.TabIndex = 10;
            this.label13.Text = "Фамилия";
            // 
            // textBoxSurnameAdd
            // 
            this.textBoxSurnameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurnameAdd.Location = new System.Drawing.Point(131, 367);
            this.textBoxSurnameAdd.MaxLength = 50;
            this.textBoxSurnameAdd.Name = "textBoxSurnameAdd";
            this.textBoxSurnameAdd.Size = new System.Drawing.Size(326, 31);
            this.textBoxSurnameAdd.TabIndex = 9;
            this.textBoxSurnameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSurnameAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Red;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAdd.Location = new System.Drawing.Point(176, 540);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(235, 72);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(267, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Роль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(270, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя";
            // 
            // textBoxNameAdd
            // 
            this.textBoxNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameAdd.Location = new System.Drawing.Point(131, 289);
            this.textBoxNameAdd.MaxLength = 50;
            this.textBoxNameAdd.Name = "textBoxNameAdd";
            this.textBoxNameAdd.Size = new System.Drawing.Size(326, 31);
            this.textBoxNameAdd.TabIndex = 4;
            this.textBoxNameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNameAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(257, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // textBoxPasswordAdd
            // 
            this.textBoxPasswordAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPasswordAdd.Location = new System.Drawing.Point(131, 205);
            this.textBoxPasswordAdd.MaxLength = 50;
            this.textBoxPasswordAdd.Name = "textBoxPasswordAdd";
            this.textBoxPasswordAdd.Size = new System.Drawing.Size(326, 29);
            this.textBoxPasswordAdd.TabIndex = 2;
            this.textBoxPasswordAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPasswordAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(262, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // textBoxLoginAdd
            // 
            this.textBoxLoginAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLoginAdd.Location = new System.Drawing.Point(131, 120);
            this.textBoxLoginAdd.MaxLength = 50;
            this.textBoxLoginAdd.Name = "textBoxLoginAdd";
            this.textBoxLoginAdd.Size = new System.Drawing.Size(326, 31);
            this.textBoxLoginAdd.TabIndex = 0;
            this.textBoxLoginAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoginAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPageUpdate.Controls.Add(this.comboBoxRoleUpdate);
            this.tabPageUpdate.Controls.Add(this.textBoxSurnameUpdate);
            this.tabPageUpdate.Controls.Add(this.textBoxNameUpdate);
            this.tabPageUpdate.Controls.Add(this.textBoxPasswordUpdate);
            this.tabPageUpdate.Controls.Add(this.textBoxLoginUpdate);
            this.tabPageUpdate.Controls.Add(this.label5);
            this.tabPageUpdate.Controls.Add(this.buttonUpdate);
            this.tabPageUpdate.Controls.Add(this.label6);
            this.tabPageUpdate.Controls.Add(this.label7);
            this.tabPageUpdate.Controls.Add(this.label8);
            this.tabPageUpdate.Controls.Add(this.label14);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 32);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(588, 705);
            this.tabPageUpdate.TabIndex = 1;
            this.tabPageUpdate.Text = "Изменить";
            // 
            // comboBoxRoleUpdate
            // 
            this.comboBoxRoleUpdate.AutoCompleteCustomSource.AddRange(new string[] {
            "Admin",
            "Writer"});
            this.comboBoxRoleUpdate.FormattingEnabled = true;
            this.comboBoxRoleUpdate.Items.AddRange(new object[] {
            "Admin",
            "Writer"});
            this.comboBoxRoleUpdate.Location = new System.Drawing.Point(201, 452);
            this.comboBoxRoleUpdate.Name = "comboBoxRoleUpdate";
            this.comboBoxRoleUpdate.Size = new System.Drawing.Size(179, 31);
            this.comboBoxRoleUpdate.TabIndex = 27;
            this.comboBoxRoleUpdate.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoleUpdate_SelectedIndexChanged);
            // 
            // textBoxSurnameUpdate
            // 
            this.textBoxSurnameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurnameUpdate.Location = new System.Drawing.Point(130, 367);
            this.textBoxSurnameUpdate.MaxLength = 50;
            this.textBoxSurnameUpdate.Name = "textBoxSurnameUpdate";
            this.textBoxSurnameUpdate.Size = new System.Drawing.Size(326, 31);
            this.textBoxSurnameUpdate.TabIndex = 26;
            this.textBoxSurnameUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSurnameUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // textBoxNameUpdate
            // 
            this.textBoxNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameUpdate.Location = new System.Drawing.Point(130, 289);
            this.textBoxNameUpdate.MaxLength = 50;
            this.textBoxNameUpdate.Name = "textBoxNameUpdate";
            this.textBoxNameUpdate.Size = new System.Drawing.Size(326, 31);
            this.textBoxNameUpdate.TabIndex = 24;
            this.textBoxNameUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNameUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // textBoxPasswordUpdate
            // 
            this.textBoxPasswordUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPasswordUpdate.Location = new System.Drawing.Point(130, 205);
            this.textBoxPasswordUpdate.MaxLength = 50;
            this.textBoxPasswordUpdate.Name = "textBoxPasswordUpdate";
            this.textBoxPasswordUpdate.Size = new System.Drawing.Size(326, 29);
            this.textBoxPasswordUpdate.TabIndex = 23;
            this.textBoxPasswordUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPasswordUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // textBoxLoginUpdate
            // 
            this.textBoxLoginUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLoginUpdate.Location = new System.Drawing.Point(130, 120);
            this.textBoxLoginUpdate.MaxLength = 50;
            this.textBoxLoginUpdate.Name = "textBoxLoginUpdate";
            this.textBoxLoginUpdate.Size = new System.Drawing.Size(326, 31);
            this.textBoxLoginUpdate.TabIndex = 22;
            this.textBoxLoginUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoginUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(249, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Фамилия";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Red;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUpdate.Location = new System.Drawing.Point(176, 540);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(235, 72);
            this.buttonUpdate.TabIndex = 19;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(267, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Роль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(270, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Имя";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(257, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Пароль";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(262, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 24);
            this.label14.TabIndex = 12;
            this.label14.Text = "Логин";
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabPageDelete.Controls.Add(this.comboBoxLoginDelete);
            this.tabPageDelete.Controls.Add(this.buttonDelete);
            this.tabPageDelete.Controls.Add(this.label15);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 32);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDelete.Size = new System.Drawing.Size(588, 705);
            this.tabPageDelete.TabIndex = 2;
            this.tabPageDelete.Text = "Удалить";
            // 
            // comboBoxLoginDelete
            // 
            this.comboBoxLoginDelete.FormattingEnabled = true;
            this.comboBoxLoginDelete.Location = new System.Drawing.Point(146, 327);
            this.comboBoxLoginDelete.Name = "comboBoxLoginDelete";
            this.comboBoxLoginDelete.Size = new System.Drawing.Size(287, 31);
            this.comboBoxLoginDelete.TabIndex = 20;
            this.comboBoxLoginDelete.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoginDelete_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDelete.Location = new System.Drawing.Point(176, 378);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(235, 72);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(264, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 24);
            this.label15.TabIndex = 12;
            this.label15.Text = "Логин";
            // 
            // dataGridViewWriters
            // 
            this.dataGridViewWriters.AutoGenerateColumns = false;
            this.dataGridViewWriters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewWriters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWriters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridViewWriters.DataSource = this.usersBindingSource;
            this.dataGridViewWriters.Location = new System.Drawing.Point(612, 54);
            this.dataGridViewWriters.Name = "dataGridViewWriters";
            this.dataGridViewWriters.Size = new System.Drawing.Size(1011, 741);
            this.dataGridViewWriters.TabIndex = 8;
            this.dataGridViewWriters.SelectionChanged += new System.EventHandler(this.dataGridViewWriters_SelectionChanged);
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 63;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 81;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Роль";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 57;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.издательский_центрDataSet;
            // 
            // издательский_центрDataSet
            // 
            this.издательский_центрDataSet.DataSetName = "Издательский_центрDataSet";
            this.издательский_центрDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // Form_redactor_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1633, 806);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridViewWriters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_redactor_users";
            this.Text = "Form_redactor_users";
            this.Load += new System.EventHandler(this.Form_redactor_users_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNameAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPasswordAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLoginAdd;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.DataGridView dataGridViewWriters;
        private Издательский_центрDataSet издательский_центрDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Издательский_центрDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSurnameAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxSurnameUpdate;
        private System.Windows.Forms.TextBox textBoxNameUpdate;
        private System.Windows.Forms.TextBox textBoxPasswordUpdate;
        private System.Windows.Forms.TextBox textBoxLoginUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxRoleAdd;
        private System.Windows.Forms.ComboBox comboBoxRoleUpdate;
        private System.Windows.Forms.ComboBox comboBoxLoginDelete;
    }
}