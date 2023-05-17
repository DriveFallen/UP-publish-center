namespace Издательский_центр
{
    partial class Form_redactor_clients
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
            this.buttonRefill = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxFullnameAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPhoneAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddressAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameAdd = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFullnameUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPhoneUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAddressUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNameUpdate = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxFullnameDelete = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPhoneDelete = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAddressDelete = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNameDelete = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.companynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactfullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.издательский_центрDataSet = new Издательский_центр.Издательский_центрDataSet();
            this.buttonClose = new System.Windows.Forms.Button();
            this.clientsTableAdapter = new Издательский_центр.Издательский_центрDataSetTableAdapters.ClientsTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefill
            // 
            this.buttonRefill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonRefill.Location = new System.Drawing.Point(614, 12);
            this.buttonRefill.Name = "buttonRefill";
            this.buttonRefill.Size = new System.Drawing.Size(106, 32);
            this.buttonRefill.TabIndex = 16;
            this.buttonRefill.Text = "Обновить";
            this.buttonRefill.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Controls.Add(this.tabPageUpdate);
            this.tabControl1.Controls.Add(this.tabPageDelete);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 741);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPageAdd.Controls.Add(this.label13);
            this.tabPageAdd.Controls.Add(this.textBoxFullnameAdd);
            this.tabPageAdd.Controls.Add(this.label4);
            this.tabPageAdd.Controls.Add(this.textBoxPhoneAdd);
            this.tabPageAdd.Controls.Add(this.label3);
            this.tabPageAdd.Controls.Add(this.textBoxAddressAdd);
            this.tabPageAdd.Controls.Add(this.label2);
            this.tabPageAdd.Controls.Add(this.textBoxNameAdd);
            this.tabPageAdd.Controls.Add(this.buttonAdd);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 32);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(588, 705);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Добавить";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(234, 414);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 23);
            this.label13.TabIndex = 31;
            this.label13.Text = "ФИО Контакта";
            // 
            // textBoxFullnameAdd
            // 
            this.textBoxFullnameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFullnameAdd.Location = new System.Drawing.Point(52, 440);
            this.textBoxFullnameAdd.MaxLength = 11;
            this.textBoxFullnameAdd.Name = "textBoxFullnameAdd";
            this.textBoxFullnameAdd.Size = new System.Drawing.Size(485, 31);
            this.textBoxFullnameAdd.TabIndex = 30;
            this.textBoxFullnameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFullnameAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Телефон";
            // 
            // textBoxPhoneAdd
            // 
            this.textBoxPhoneAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhoneAdd.Location = new System.Drawing.Point(177, 380);
            this.textBoxPhoneAdd.MaxLength = 11;
            this.textBoxPhoneAdd.Name = "textBoxPhoneAdd";
            this.textBoxPhoneAdd.Size = new System.Drawing.Size(235, 31);
            this.textBoxPhoneAdd.TabIndex = 28;
            this.textBoxPhoneAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPhoneAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Адрес";
            // 
            // textBoxAddressAdd
            // 
            this.textBoxAddressAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddressAdd.Location = new System.Drawing.Point(52, 320);
            this.textBoxAddressAdd.MaxLength = 11;
            this.textBoxAddressAdd.Name = "textBoxAddressAdd";
            this.textBoxAddressAdd.Size = new System.Drawing.Size(485, 31);
            this.textBoxAddressAdd.TabIndex = 26;
            this.textBoxAddressAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAddressAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Название";
            // 
            // textBoxNameAdd
            // 
            this.textBoxNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameAdd.Location = new System.Drawing.Point(52, 260);
            this.textBoxNameAdd.MaxLength = 50;
            this.textBoxNameAdd.Name = "textBoxNameAdd";
            this.textBoxNameAdd.Size = new System.Drawing.Size(485, 31);
            this.textBoxNameAdd.TabIndex = 24;
            this.textBoxNameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNameAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Red;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAdd.Location = new System.Drawing.Point(174, 591);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(235, 72);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPageUpdate.Controls.Add(this.label1);
            this.tabPageUpdate.Controls.Add(this.textBoxFullnameUpdate);
            this.tabPageUpdate.Controls.Add(this.label5);
            this.tabPageUpdate.Controls.Add(this.textBoxPhoneUpdate);
            this.tabPageUpdate.Controls.Add(this.label6);
            this.tabPageUpdate.Controls.Add(this.textBoxAddressUpdate);
            this.tabPageUpdate.Controls.Add(this.label7);
            this.tabPageUpdate.Controls.Add(this.textBoxNameUpdate);
            this.tabPageUpdate.Controls.Add(this.buttonUpdate);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 32);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(588, 705);
            this.tabPageUpdate.TabIndex = 1;
            this.tabPageUpdate.Text = "Изменить";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "ФИО Контакта";
            // 
            // textBoxFullnameUpdate
            // 
            this.textBoxFullnameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFullnameUpdate.Location = new System.Drawing.Point(52, 440);
            this.textBoxFullnameUpdate.MaxLength = 11;
            this.textBoxFullnameUpdate.Name = "textBoxFullnameUpdate";
            this.textBoxFullnameUpdate.Size = new System.Drawing.Size(485, 31);
            this.textBoxFullnameUpdate.TabIndex = 30;
            this.textBoxFullnameUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFullnameUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Телефон";
            // 
            // textBoxPhoneUpdate
            // 
            this.textBoxPhoneUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhoneUpdate.Location = new System.Drawing.Point(177, 380);
            this.textBoxPhoneUpdate.MaxLength = 11;
            this.textBoxPhoneUpdate.Name = "textBoxPhoneUpdate";
            this.textBoxPhoneUpdate.Size = new System.Drawing.Size(235, 31);
            this.textBoxPhoneUpdate.TabIndex = 28;
            this.textBoxPhoneUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPhoneUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Адрес";
            // 
            // textBoxAddressUpdate
            // 
            this.textBoxAddressUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddressUpdate.Location = new System.Drawing.Point(52, 320);
            this.textBoxAddressUpdate.MaxLength = 11;
            this.textBoxAddressUpdate.Name = "textBoxAddressUpdate";
            this.textBoxAddressUpdate.Size = new System.Drawing.Size(485, 31);
            this.textBoxAddressUpdate.TabIndex = 26;
            this.textBoxAddressUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAddressUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Название";
            // 
            // textBoxNameUpdate
            // 
            this.textBoxNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameUpdate.Location = new System.Drawing.Point(52, 260);
            this.textBoxNameUpdate.MaxLength = 50;
            this.textBoxNameUpdate.Name = "textBoxNameUpdate";
            this.textBoxNameUpdate.Size = new System.Drawing.Size(485, 31);
            this.textBoxNameUpdate.TabIndex = 24;
            this.textBoxNameUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNameUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Red;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUpdate.Location = new System.Drawing.Point(173, 561);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(235, 72);
            this.buttonUpdate.TabIndex = 17;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabPageDelete.Controls.Add(this.label8);
            this.tabPageDelete.Controls.Add(this.textBoxFullnameDelete);
            this.tabPageDelete.Controls.Add(this.label9);
            this.tabPageDelete.Controls.Add(this.textBoxPhoneDelete);
            this.tabPageDelete.Controls.Add(this.label10);
            this.tabPageDelete.Controls.Add(this.textBoxAddressDelete);
            this.tabPageDelete.Controls.Add(this.label11);
            this.tabPageDelete.Controls.Add(this.textBoxNameDelete);
            this.tabPageDelete.Controls.Add(this.buttonDelete);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 32);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDelete.Size = new System.Drawing.Size(588, 705);
            this.tabPageDelete.TabIndex = 2;
            this.tabPageDelete.Text = "Удалить";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 23);
            this.label8.TabIndex = 34;
            this.label8.Text = "ФИО Контакта";
            // 
            // textBoxFullnameDelete
            // 
            this.textBoxFullnameDelete.Enabled = false;
            this.textBoxFullnameDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFullnameDelete.Location = new System.Drawing.Point(52, 440);
            this.textBoxFullnameDelete.MaxLength = 11;
            this.textBoxFullnameDelete.Name = "textBoxFullnameDelete";
            this.textBoxFullnameDelete.Size = new System.Drawing.Size(485, 31);
            this.textBoxFullnameDelete.TabIndex = 33;
            this.textBoxFullnameDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFullnameDelete.TextChanged += new System.EventHandler(this.textBoxDelete_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "Телефон";
            // 
            // textBoxPhoneDelete
            // 
            this.textBoxPhoneDelete.Enabled = false;
            this.textBoxPhoneDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhoneDelete.Location = new System.Drawing.Point(177, 380);
            this.textBoxPhoneDelete.MaxLength = 11;
            this.textBoxPhoneDelete.Name = "textBoxPhoneDelete";
            this.textBoxPhoneDelete.Size = new System.Drawing.Size(235, 31);
            this.textBoxPhoneDelete.TabIndex = 31;
            this.textBoxPhoneDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPhoneDelete.TextChanged += new System.EventHandler(this.textBoxDelete_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(265, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "Адрес";
            // 
            // textBoxAddressDelete
            // 
            this.textBoxAddressDelete.Enabled = false;
            this.textBoxAddressDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddressDelete.Location = new System.Drawing.Point(52, 320);
            this.textBoxAddressDelete.MaxLength = 11;
            this.textBoxAddressDelete.Name = "textBoxAddressDelete";
            this.textBoxAddressDelete.Size = new System.Drawing.Size(485, 31);
            this.textBoxAddressDelete.TabIndex = 29;
            this.textBoxAddressDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAddressDelete.TextChanged += new System.EventHandler(this.textBoxDelete_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(250, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 23);
            this.label11.TabIndex = 28;
            this.label11.Text = "Название";
            // 
            // textBoxNameDelete
            // 
            this.textBoxNameDelete.Enabled = false;
            this.textBoxNameDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameDelete.Location = new System.Drawing.Point(52, 260);
            this.textBoxNameDelete.MaxLength = 50;
            this.textBoxNameDelete.Name = "textBoxNameDelete";
            this.textBoxNameDelete.Size = new System.Drawing.Size(485, 31);
            this.textBoxNameDelete.TabIndex = 27;
            this.textBoxNameDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNameDelete.TextChanged += new System.EventHandler(this.textBoxDelete_TextChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDelete.Location = new System.Drawing.Point(174, 560);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(235, 72);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AutoGenerateColumns = false;
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companynameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.contactfullnameDataGridViewTextBoxColumn});
            this.dataGridViewBooks.DataSource = this.clientsBindingSource;
            this.dataGridViewBooks.Location = new System.Drawing.Point(614, 61);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(845, 692);
            this.dataGridViewBooks.TabIndex = 14;
            this.dataGridViewBooks.SelectionChanged += new System.EventHandler(this.dataGridViewBooks_SelectionChanged);
            // 
            // companynameDataGridViewTextBoxColumn
            // 
            this.companynameDataGridViewTextBoxColumn.DataPropertyName = "Company_name";
            this.companynameDataGridViewTextBoxColumn.HeaderText = "Название компании";
            this.companynameDataGridViewTextBoxColumn.Name = "companynameDataGridViewTextBoxColumn";
            this.companynameDataGridViewTextBoxColumn.Width = 123;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 63;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 77;
            // 
            // contactfullnameDataGridViewTextBoxColumn
            // 
            this.contactfullnameDataGridViewTextBoxColumn.DataPropertyName = "Contact_fullname";
            this.contactfullnameDataGridViewTextBoxColumn.HeaderText = "ФИО Контакта";
            this.contactfullnameDataGridViewTextBoxColumn.Name = "contactfullnameDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.издательский_центрDataSet;
            // 
            // издательский_центрDataSet
            // 
            this.издательский_центрDataSet.DataSetName = "Издательский_центрDataSet";
            this.издательский_центрDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(1422, 6);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(37, 36);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "X";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // Form_redactor_clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1465, 762);
            this.Controls.Add(this.buttonRefill);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_redactor_clients";
            this.Text = "Form_redactor_clients";
            this.Load += new System.EventHandler(this.Form_redactor_clients_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRefill;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button buttonClose;
        private Издательский_центрDataSet издательский_центрDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private Издательский_центрDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn companynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactfullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxFullnameAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPhoneAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddressAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFullnameUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPhoneUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAddressUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNameUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxFullnameDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPhoneDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxAddressDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNameDelete;
    }
}