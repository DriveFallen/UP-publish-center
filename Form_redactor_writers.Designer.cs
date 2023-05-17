namespace Издательский_центр
{
    partial class Form_redactor_writers
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
            this.dataGridViewWriters = new System.Windows.Forms.DataGridView();
            this.passportnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.издательский_центрDataSet = new Издательский_центр.Издательский_центрDataSet();
            this.writersTableAdapter = new Издательский_центр.Издательский_центрDataSetTableAdapters.WritersTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPhoneAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddressAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFullnameAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassportAdd = new System.Windows.Forms.TextBox();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPhoneUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAddressUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFullnameUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPassportUpdate = new System.Windows.Forms.TextBox();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxPassportDelete = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRefill = new System.Windows.Forms.Button();
            this.textBoxFullnameDelete = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAddressDelete = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPhoneDelete = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewWriters
            // 
            this.dataGridViewWriters.AutoGenerateColumns = false;
            this.dataGridViewWriters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewWriters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWriters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.passportnumberDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridViewWriters.DataSource = this.writersBindingSource;
            this.dataGridViewWriters.Location = new System.Drawing.Point(614, 46);
            this.dataGridViewWriters.Name = "dataGridViewWriters";
            this.dataGridViewWriters.Size = new System.Drawing.Size(1011, 741);
            this.dataGridViewWriters.TabIndex = 1;
            this.dataGridViewWriters.SelectionChanged += new System.EventHandler(this.dataGridViewWriters_SelectionChanged);
            // 
            // passportnumberDataGridViewTextBoxColumn
            // 
            this.passportnumberDataGridViewTextBoxColumn.DataPropertyName = "Passport_number";
            this.passportnumberDataGridViewTextBoxColumn.HeaderText = "Серия/номер паспорта";
            this.passportnumberDataGridViewTextBoxColumn.Name = "passportnumberDataGridViewTextBoxColumn";
            this.passportnumberDataGridViewTextBoxColumn.Width = 137;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.Width = 59;
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
            // writersBindingSource
            // 
            this.writersBindingSource.DataMember = "Writers";
            this.writersBindingSource.DataSource = this.издательский_центрDataSet;
            // 
            // издательский_центрDataSet
            // 
            this.издательский_центрDataSet.DataSetName = "Издательский_центрDataSet";
            this.издательский_центрDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // writersTableAdapter
            // 
            this.writersTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Controls.Add(this.tabPageUpdate);
            this.tabControl1.Controls.Add(this.tabPageDelete);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 741);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPageAdd.Controls.Add(this.buttonAdd);
            this.tabPageAdd.Controls.Add(this.label4);
            this.tabPageAdd.Controls.Add(this.textBoxPhoneAdd);
            this.tabPageAdd.Controls.Add(this.label3);
            this.tabPageAdd.Controls.Add(this.textBoxAddressAdd);
            this.tabPageAdd.Controls.Add(this.label2);
            this.tabPageAdd.Controls.Add(this.textBoxFullnameAdd);
            this.tabPageAdd.Controls.Add(this.label1);
            this.tabPageAdd.Controls.Add(this.textBoxPassportAdd);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 32);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(588, 705);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Добавить";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Red;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAdd.Location = new System.Drawing.Point(172, 517);
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
            this.label4.Location = new System.Drawing.Point(202, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "         Телефон\r\n(+7XXXXXXXXXX)";
            // 
            // textBoxPhoneAdd
            // 
            this.textBoxPhoneAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhoneAdd.Location = new System.Drawing.Point(207, 429);
            this.textBoxPhoneAdd.MaxLength = 12;
            this.textBoxPhoneAdd.Name = "textBoxPhoneAdd";
            this.textBoxPhoneAdd.Size = new System.Drawing.Size(171, 31);
            this.textBoxPhoneAdd.TabIndex = 6;
            this.textBoxPhoneAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPhoneAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(223, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "        Адрес\r\n(50 символов)";
            // 
            // textBoxAddressAdd
            // 
            this.textBoxAddressAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddressAdd.Location = new System.Drawing.Point(41, 344);
            this.textBoxAddressAdd.MaxLength = 50;
            this.textBoxAddressAdd.Name = "textBoxAddressAdd";
            this.textBoxAddressAdd.Size = new System.Drawing.Size(507, 31);
            this.textBoxAddressAdd.TabIndex = 4;
            this.textBoxAddressAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAddressAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(222, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "        ФИО\r\n(50 символов)";
            // 
            // textBoxFullnameAdd
            // 
            this.textBoxFullnameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFullnameAdd.Location = new System.Drawing.Point(41, 261);
            this.textBoxFullnameAdd.MaxLength = 50;
            this.textBoxFullnameAdd.Name = "textBoxFullnameAdd";
            this.textBoxFullnameAdd.Size = new System.Drawing.Size(507, 29);
            this.textBoxFullnameAdd.TabIndex = 2;
            this.textBoxFullnameAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFullnameAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(183, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Серия/номер паспорта\r\n         (xxxx xxxxxx)";
            // 
            // textBoxPassportAdd
            // 
            this.textBoxPassportAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassportAdd.Location = new System.Drawing.Point(212, 176);
            this.textBoxPassportAdd.MaxLength = 11;
            this.textBoxPassportAdd.Name = "textBoxPassportAdd";
            this.textBoxPassportAdd.Size = new System.Drawing.Size(155, 31);
            this.textBoxPassportAdd.TabIndex = 0;
            this.textBoxPassportAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassportAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPageUpdate.Controls.Add(this.buttonUpdate);
            this.tabPageUpdate.Controls.Add(this.label5);
            this.tabPageUpdate.Controls.Add(this.textBoxPhoneUpdate);
            this.tabPageUpdate.Controls.Add(this.label6);
            this.tabPageUpdate.Controls.Add(this.textBoxAddressUpdate);
            this.tabPageUpdate.Controls.Add(this.label7);
            this.tabPageUpdate.Controls.Add(this.textBoxFullnameUpdate);
            this.tabPageUpdate.Controls.Add(this.label8);
            this.tabPageUpdate.Controls.Add(this.textBoxPassportUpdate);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 32);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(588, 705);
            this.tabPageUpdate.TabIndex = 1;
            this.tabPageUpdate.Text = "Изменить";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Red;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUpdate.Location = new System.Drawing.Point(172, 517);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(235, 72);
            this.buttonUpdate.TabIndex = 17;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(202, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 48);
            this.label5.TabIndex = 16;
            this.label5.Text = "         Телефон\r\n(+7XXXXXXXXXX)";
            // 
            // textBoxPhoneUpdate
            // 
            this.textBoxPhoneUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhoneUpdate.Location = new System.Drawing.Point(207, 429);
            this.textBoxPhoneUpdate.MaxLength = 12;
            this.textBoxPhoneUpdate.Name = "textBoxPhoneUpdate";
            this.textBoxPhoneUpdate.Size = new System.Drawing.Size(171, 31);
            this.textBoxPhoneUpdate.TabIndex = 15;
            this.textBoxPhoneUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPhoneUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(223, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 48);
            this.label6.TabIndex = 14;
            this.label6.Text = "        Адрес\r\n(50 символов)";
            // 
            // textBoxAddressUpdate
            // 
            this.textBoxAddressUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddressUpdate.Location = new System.Drawing.Point(41, 344);
            this.textBoxAddressUpdate.MaxLength = 50;
            this.textBoxAddressUpdate.Name = "textBoxAddressUpdate";
            this.textBoxAddressUpdate.Size = new System.Drawing.Size(507, 31);
            this.textBoxAddressUpdate.TabIndex = 13;
            this.textBoxAddressUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAddressUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(222, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 48);
            this.label7.TabIndex = 12;
            this.label7.Text = "        ФИО\r\n(50 символов)";
            // 
            // textBoxFullnameUpdate
            // 
            this.textBoxFullnameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFullnameUpdate.Location = new System.Drawing.Point(41, 261);
            this.textBoxFullnameUpdate.MaxLength = 50;
            this.textBoxFullnameUpdate.Name = "textBoxFullnameUpdate";
            this.textBoxFullnameUpdate.Size = new System.Drawing.Size(507, 29);
            this.textBoxFullnameUpdate.TabIndex = 11;
            this.textBoxFullnameUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFullnameUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(183, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 48);
            this.label8.TabIndex = 10;
            this.label8.Text = "Серия/номер паспорта\r\n         (xxxx xxxxxx)";
            // 
            // textBoxPassportUpdate
            // 
            this.textBoxPassportUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassportUpdate.Location = new System.Drawing.Point(212, 176);
            this.textBoxPassportUpdate.MaxLength = 11;
            this.textBoxPassportUpdate.Name = "textBoxPassportUpdate";
            this.textBoxPassportUpdate.Size = new System.Drawing.Size(155, 31);
            this.textBoxPassportUpdate.TabIndex = 9;
            this.textBoxPassportUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassportUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabPageDelete.Controls.Add(this.buttonDelete);
            this.tabPageDelete.Controls.Add(this.label9);
            this.tabPageDelete.Controls.Add(this.textBoxPhoneDelete);
            this.tabPageDelete.Controls.Add(this.label10);
            this.tabPageDelete.Controls.Add(this.textBoxAddressDelete);
            this.tabPageDelete.Controls.Add(this.label11);
            this.tabPageDelete.Controls.Add(this.textBoxFullnameDelete);
            this.tabPageDelete.Controls.Add(this.label12);
            this.tabPageDelete.Controls.Add(this.textBoxPassportDelete);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 32);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDelete.Size = new System.Drawing.Size(588, 705);
            this.tabPageDelete.TabIndex = 2;
            this.tabPageDelete.Text = "Удалить";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDelete.Location = new System.Drawing.Point(172, 517);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(235, 72);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(183, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 48);
            this.label12.TabIndex = 19;
            this.label12.Text = "Серия/номер паспорта\r\n         (xxxx xxxxxx)";
            // 
            // textBoxPassportDelete
            // 
            this.textBoxPassportDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassportDelete.Location = new System.Drawing.Point(212, 176);
            this.textBoxPassportDelete.MaxLength = 11;
            this.textBoxPassportDelete.Name = "textBoxPassportDelete";
            this.textBoxPassportDelete.Size = new System.Drawing.Size(155, 31);
            this.textBoxPassportDelete.TabIndex = 18;
            this.textBoxPassportDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassportDelete.TextChanged += new System.EventHandler(this.textBoxDelete_TextChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(1588, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(37, 36);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "X";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRefill
            // 
            this.buttonRefill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonRefill.Location = new System.Drawing.Point(614, 12);
            this.buttonRefill.Name = "buttonRefill";
            this.buttonRefill.Size = new System.Drawing.Size(106, 32);
            this.buttonRefill.TabIndex = 9;
            this.buttonRefill.Text = "Обновить";
            this.buttonRefill.UseVisualStyleBackColor = false;
            this.buttonRefill.Click += new System.EventHandler(this.buttonRefill_Click);
            // 
            // textBoxFullnameDelete
            // 
            this.textBoxFullnameDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFullnameDelete.Location = new System.Drawing.Point(41, 261);
            this.textBoxFullnameDelete.MaxLength = 50;
            this.textBoxFullnameDelete.Name = "textBoxFullnameDelete";
            this.textBoxFullnameDelete.Size = new System.Drawing.Size(507, 29);
            this.textBoxFullnameDelete.TabIndex = 20;
            this.textBoxFullnameDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(222, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 48);
            this.label11.TabIndex = 21;
            this.label11.Text = "        ФИО\r\n(50 символов)";
            // 
            // textBoxAddressDelete
            // 
            this.textBoxAddressDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddressDelete.Location = new System.Drawing.Point(41, 344);
            this.textBoxAddressDelete.MaxLength = 50;
            this.textBoxAddressDelete.Name = "textBoxAddressDelete";
            this.textBoxAddressDelete.Size = new System.Drawing.Size(507, 31);
            this.textBoxAddressDelete.TabIndex = 22;
            this.textBoxAddressDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(223, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 48);
            this.label10.TabIndex = 23;
            this.label10.Text = "        Адрес\r\n(50 символов)";
            // 
            // textBoxPhoneDelete
            // 
            this.textBoxPhoneDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhoneDelete.Location = new System.Drawing.Point(207, 429);
            this.textBoxPhoneDelete.MaxLength = 12;
            this.textBoxPhoneDelete.Name = "textBoxPhoneDelete";
            this.textBoxPhoneDelete.Size = new System.Drawing.Size(171, 31);
            this.textBoxPhoneDelete.TabIndex = 24;
            this.textBoxPhoneDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(202, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 48);
            this.label9.TabIndex = 25;
            this.label9.Text = "         Телефон\r\n(+7XXXXXXXXXX)";
            // 
            // Form_redactor_writers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1637, 799);
            this.Controls.Add(this.buttonRefill);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridViewWriters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_redactor_writers";
            this.Text = "Радктирование писателей";
            this.Load += new System.EventHandler(this.Form_redactor_writers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWriters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewWriters;
        private Издательский_центрDataSet издательский_центрDataSet;
        private System.Windows.Forms.BindingSource writersBindingSource;
        private Издательский_центрDataSetTableAdapters.WritersTableAdapter writersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.TabPage tabPageDelete;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPhoneAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddressAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFullnameAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassportAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPhoneUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAddressUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFullnameUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPassportUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxPassportDelete;
        private System.Windows.Forms.Button buttonRefill;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPhoneDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxAddressDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxFullnameDelete;
    }
}