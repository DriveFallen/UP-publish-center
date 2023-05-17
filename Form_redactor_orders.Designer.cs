namespace Издательский_центр
{
    partial class Form_redactor_orders
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
            this.buttonRefill = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxCountAdd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxDateEndAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDateStartAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCountUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDateEndUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDateStartUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxIdUpdate = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNameBookDelete = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxCountDelete = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDateEndDelete = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxDateStartDelete = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxClientDelete = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxIdDelete = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.iDOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.издательский_центрDataSet = new Издательский_центр.Издательский_центрDataSet();
            this.ordersTableAdapter = new Издательский_центр.Издательский_центрDataSetTableAdapters.OrdersTableAdapter();
            this.comboBoxClientsAdd = new System.Windows.Forms.ComboBox();
            this.comboBoxBooksAdd = new System.Windows.Forms.ComboBox();
            this.comboBoxBooksUpdate = new System.Windows.Forms.ComboBox();
            this.comboBoxClientsUpdate = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.buttonClose.Location = new System.Drawing.Point(1411, 11);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(31, 31);
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
            this.buttonRefill.TabIndex = 15;
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
            this.tabControl1.TabIndex = 14;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPageAdd.Controls.Add(this.comboBoxBooksAdd);
            this.tabPageAdd.Controls.Add(this.comboBoxClientsAdd);
            this.tabPageAdd.Controls.Add(this.label15);
            this.tabPageAdd.Controls.Add(this.label14);
            this.tabPageAdd.Controls.Add(this.textBoxCountAdd);
            this.tabPageAdd.Controls.Add(this.label13);
            this.tabPageAdd.Controls.Add(this.textBoxDateEndAdd);
            this.tabPageAdd.Controls.Add(this.label4);
            this.tabPageAdd.Controls.Add(this.textBoxDateStartAdd);
            this.tabPageAdd.Controls.Add(this.label3);
            this.tabPageAdd.Controls.Add(this.buttonAdd);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 32);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(588, 705);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Добавить";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(230, 404);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 23);
            this.label15.TabIndex = 27;
            this.label15.Text = "Название книги";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(228, 344);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 23);
            this.label14.TabIndex = 25;
            this.label14.Text = "Количество книг";
            // 
            // textBoxCountAdd
            // 
            this.textBoxCountAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountAdd.Location = new System.Drawing.Point(232, 370);
            this.textBoxCountAdd.MaxLength = 11;
            this.textBoxCountAdd.Name = "textBoxCountAdd";
            this.textBoxCountAdd.Size = new System.Drawing.Size(135, 31);
            this.textBoxCountAdd.TabIndex = 24;
            this.textBoxCountAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCountAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(226, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 23);
            this.label13.TabIndex = 23;
            this.label13.Text = "Дата завершения";
            // 
            // textBoxDateEndAdd
            // 
            this.textBoxDateEndAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateEndAdd.Location = new System.Drawing.Point(210, 310);
            this.textBoxDateEndAdd.MaxLength = 11;
            this.textBoxDateEndAdd.Name = "textBoxDateEndAdd";
            this.textBoxDateEndAdd.Size = new System.Drawing.Size(184, 31);
            this.textBoxDateEndAdd.TabIndex = 22;
            this.textBoxDateEndAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDateEndAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Дата оформления";
            // 
            // textBoxDateStartAdd
            // 
            this.textBoxDateStartAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateStartAdd.Location = new System.Drawing.Point(210, 250);
            this.textBoxDateStartAdd.MaxLength = 11;
            this.textBoxDateStartAdd.Name = "textBoxDateStartAdd";
            this.textBoxDateStartAdd.Size = new System.Drawing.Size(184, 31);
            this.textBoxDateStartAdd.TabIndex = 20;
            this.textBoxDateStartAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDateStartAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Клиент";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Red;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAdd.Location = new System.Drawing.Point(187, 565);
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
            this.tabPageUpdate.Controls.Add(this.comboBoxBooksUpdate);
            this.tabPageUpdate.Controls.Add(this.comboBoxClientsUpdate);
            this.tabPageUpdate.Controls.Add(this.label1);
            this.tabPageUpdate.Controls.Add(this.label5);
            this.tabPageUpdate.Controls.Add(this.textBoxCountUpdate);
            this.tabPageUpdate.Controls.Add(this.label6);
            this.tabPageUpdate.Controls.Add(this.textBoxDateEndUpdate);
            this.tabPageUpdate.Controls.Add(this.label7);
            this.tabPageUpdate.Controls.Add(this.textBoxDateStartUpdate);
            this.tabPageUpdate.Controls.Add(this.label8);
            this.tabPageUpdate.Controls.Add(this.label9);
            this.tabPageUpdate.Controls.Add(this.textBoxIdUpdate);
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
            this.label1.Location = new System.Drawing.Point(224, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Название книги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Количество книг";
            // 
            // textBoxCountUpdate
            // 
            this.textBoxCountUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountUpdate.Location = new System.Drawing.Point(226, 383);
            this.textBoxCountUpdate.MaxLength = 11;
            this.textBoxCountUpdate.Name = "textBoxCountUpdate";
            this.textBoxCountUpdate.Size = new System.Drawing.Size(135, 31);
            this.textBoxCountUpdate.TabIndex = 36;
            this.textBoxCountUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCountUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "Дата завершения";
            // 
            // textBoxDateEndUpdate
            // 
            this.textBoxDateEndUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateEndUpdate.Location = new System.Drawing.Point(204, 323);
            this.textBoxDateEndUpdate.MaxLength = 11;
            this.textBoxDateEndUpdate.Name = "textBoxDateEndUpdate";
            this.textBoxDateEndUpdate.Size = new System.Drawing.Size(184, 31);
            this.textBoxDateEndUpdate.TabIndex = 34;
            this.textBoxDateEndUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDateEndUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "Дата оформления";
            // 
            // textBoxDateStartUpdate
            // 
            this.textBoxDateStartUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateStartUpdate.Location = new System.Drawing.Point(204, 263);
            this.textBoxDateStartUpdate.MaxLength = 11;
            this.textBoxDateStartUpdate.Name = "textBoxDateStartUpdate";
            this.textBoxDateStartUpdate.Size = new System.Drawing.Size(184, 31);
            this.textBoxDateStartUpdate.TabIndex = 32;
            this.textBoxDateStartUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDateStartUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 23);
            this.label8.TabIndex = 31;
            this.label8.Text = "Клиент";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 29;
            this.label9.Text = "Номер";
            // 
            // textBoxIdUpdate
            // 
            this.textBoxIdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIdUpdate.Location = new System.Drawing.Point(199, 143);
            this.textBoxIdUpdate.MaxLength = 50;
            this.textBoxIdUpdate.Name = "textBoxIdUpdate";
            this.textBoxIdUpdate.Size = new System.Drawing.Size(184, 31);
            this.textBoxIdUpdate.TabIndex = 28;
            this.textBoxIdUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIdUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
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
            this.tabPageDelete.Controls.Add(this.label10);
            this.tabPageDelete.Controls.Add(this.textBoxNameBookDelete);
            this.tabPageDelete.Controls.Add(this.label11);
            this.tabPageDelete.Controls.Add(this.textBoxCountDelete);
            this.tabPageDelete.Controls.Add(this.label12);
            this.tabPageDelete.Controls.Add(this.textBoxDateEndDelete);
            this.tabPageDelete.Controls.Add(this.label16);
            this.tabPageDelete.Controls.Add(this.textBoxDateStartDelete);
            this.tabPageDelete.Controls.Add(this.label17);
            this.tabPageDelete.Controls.Add(this.textBoxClientDelete);
            this.tabPageDelete.Controls.Add(this.label18);
            this.tabPageDelete.Controls.Add(this.textBoxIdDelete);
            this.tabPageDelete.Controls.Add(this.buttonDelete);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 32);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDelete.Size = new System.Drawing.Size(588, 705);
            this.tabPageDelete.TabIndex = 2;
            this.tabPageDelete.Text = "Удалить";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 23);
            this.label10.TabIndex = 39;
            this.label10.Text = "Название книги";
            // 
            // textBoxNameBookDelete
            // 
            this.textBoxNameBookDelete.Enabled = false;
            this.textBoxNameBookDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameBookDelete.Location = new System.Drawing.Point(99, 432);
            this.textBoxNameBookDelete.MaxLength = 11;
            this.textBoxNameBookDelete.Name = "textBoxNameBookDelete";
            this.textBoxNameBookDelete.Size = new System.Drawing.Size(405, 31);
            this.textBoxNameBookDelete.TabIndex = 38;
            this.textBoxNameBookDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(224, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 23);
            this.label11.TabIndex = 37;
            this.label11.Text = "Количество книг";
            // 
            // textBoxCountDelete
            // 
            this.textBoxCountDelete.Enabled = false;
            this.textBoxCountDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountDelete.Location = new System.Drawing.Point(228, 372);
            this.textBoxCountDelete.MaxLength = 11;
            this.textBoxCountDelete.Name = "textBoxCountDelete";
            this.textBoxCountDelete.Size = new System.Drawing.Size(135, 31);
            this.textBoxCountDelete.TabIndex = 36;
            this.textBoxCountDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(222, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 23);
            this.label12.TabIndex = 35;
            this.label12.Text = "Дата завершения";
            // 
            // textBoxDateEndDelete
            // 
            this.textBoxDateEndDelete.Enabled = false;
            this.textBoxDateEndDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateEndDelete.Location = new System.Drawing.Point(206, 312);
            this.textBoxDateEndDelete.MaxLength = 11;
            this.textBoxDateEndDelete.Name = "textBoxDateEndDelete";
            this.textBoxDateEndDelete.Size = new System.Drawing.Size(184, 31);
            this.textBoxDateEndDelete.TabIndex = 34;
            this.textBoxDateEndDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(220, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(159, 23);
            this.label16.TabIndex = 33;
            this.label16.Text = "Дата оформления";
            // 
            // textBoxDateStartDelete
            // 
            this.textBoxDateStartDelete.Enabled = false;
            this.textBoxDateStartDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateStartDelete.Location = new System.Drawing.Point(206, 252);
            this.textBoxDateStartDelete.MaxLength = 11;
            this.textBoxDateStartDelete.Name = "textBoxDateStartDelete";
            this.textBoxDateStartDelete.Size = new System.Drawing.Size(184, 31);
            this.textBoxDateStartDelete.TabIndex = 32;
            this.textBoxDateStartDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(257, 166);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 23);
            this.label17.TabIndex = 31;
            this.label17.Text = "Клиент";
            // 
            // textBoxClientDelete
            // 
            this.textBoxClientDelete.Enabled = false;
            this.textBoxClientDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxClientDelete.Location = new System.Drawing.Point(99, 192);
            this.textBoxClientDelete.MaxLength = 11;
            this.textBoxClientDelete.Name = "textBoxClientDelete";
            this.textBoxClientDelete.Size = new System.Drawing.Size(405, 31);
            this.textBoxClientDelete.TabIndex = 30;
            this.textBoxClientDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(259, 106);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 23);
            this.label18.TabIndex = 29;
            this.label18.Text = "Номер";
            // 
            // textBoxIdDelete
            // 
            this.textBoxIdDelete.Enabled = false;
            this.textBoxIdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIdDelete.Location = new System.Drawing.Point(201, 132);
            this.textBoxIdDelete.MaxLength = 50;
            this.textBoxIdDelete.Name = "textBoxIdDelete";
            this.textBoxIdDelete.Size = new System.Drawing.Size(184, 31);
            this.textBoxIdDelete.TabIndex = 28;
            this.textBoxIdDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIdDelete.TextChanged += new System.EventHandler(this.textBoxDelete_TextChanged);
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
            this.iDOrderDataGridViewTextBoxColumn,
            this.clientnameDataGridViewTextBoxColumn,
            this.datestartDataGridViewTextBoxColumn,
            this.dateendDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewBooks.DataSource = this.ordersBindingSource;
            this.dataGridViewBooks.Location = new System.Drawing.Point(614, 61);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(845, 692);
            this.dataGridViewBooks.TabIndex = 13;
            this.dataGridViewBooks.SelectionChanged += new System.EventHandler(this.dataGridViewBooks_SelectionChanged);
            // 
            // iDOrderDataGridViewTextBoxColumn
            // 
            this.iDOrderDataGridViewTextBoxColumn.DataPropertyName = "ID_Order";
            this.iDOrderDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.iDOrderDataGridViewTextBoxColumn.Name = "iDOrderDataGridViewTextBoxColumn";
            this.iDOrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDOrderDataGridViewTextBoxColumn.Width = 66;
            // 
            // clientnameDataGridViewTextBoxColumn
            // 
            this.clientnameDataGridViewTextBoxColumn.DataPropertyName = "Client_name";
            this.clientnameDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.clientnameDataGridViewTextBoxColumn.Name = "clientnameDataGridViewTextBoxColumn";
            this.clientnameDataGridViewTextBoxColumn.Width = 68;
            // 
            // datestartDataGridViewTextBoxColumn
            // 
            this.datestartDataGridViewTextBoxColumn.DataPropertyName = "Date_start";
            this.datestartDataGridViewTextBoxColumn.HeaderText = "Дата оформления";
            this.datestartDataGridViewTextBoxColumn.Name = "datestartDataGridViewTextBoxColumn";
            this.datestartDataGridViewTextBoxColumn.Width = 114;
            // 
            // dateendDataGridViewTextBoxColumn
            // 
            this.dateendDataGridViewTextBoxColumn.DataPropertyName = "Date_end";
            this.dateendDataGridViewTextBoxColumn.HeaderText = "Дата завершения";
            this.dateendDataGridViewTextBoxColumn.Name = "dateendDataGridViewTextBoxColumn";
            this.dateendDataGridViewTextBoxColumn.Width = 113;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество книг";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.Width = 107;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название книги";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 105;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.издательский_центрDataSet;
            // 
            // издательский_центрDataSet
            // 
            this.издательский_центрDataSet.DataSetName = "Издательский_центрDataSet";
            this.издательский_центрDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxClientsAdd
            // 
            this.comboBoxClientsAdd.FormattingEnabled = true;
            this.comboBoxClientsAdd.Location = new System.Drawing.Point(210, 190);
            this.comboBoxClientsAdd.Name = "comboBoxClientsAdd";
            this.comboBoxClientsAdd.Size = new System.Drawing.Size(184, 31);
            this.comboBoxClientsAdd.TabIndex = 28;
            // 
            // comboBoxBooksAdd
            // 
            this.comboBoxBooksAdd.FormattingEnabled = true;
            this.comboBoxBooksAdd.Location = new System.Drawing.Point(208, 430);
            this.comboBoxBooksAdd.Name = "comboBoxBooksAdd";
            this.comboBoxBooksAdd.Size = new System.Drawing.Size(186, 31);
            this.comboBoxBooksAdd.TabIndex = 29;
            // 
            // comboBoxBooksUpdate
            // 
            this.comboBoxBooksUpdate.FormattingEnabled = true;
            this.comboBoxBooksUpdate.Location = new System.Drawing.Point(197, 443);
            this.comboBoxBooksUpdate.Name = "comboBoxBooksUpdate";
            this.comboBoxBooksUpdate.Size = new System.Drawing.Size(186, 31);
            this.comboBoxBooksUpdate.TabIndex = 41;
            this.comboBoxBooksUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // comboBoxClientsUpdate
            // 
            this.comboBoxClientsUpdate.FormattingEnabled = true;
            this.comboBoxClientsUpdate.Location = new System.Drawing.Point(199, 203);
            this.comboBoxClientsUpdate.Name = "comboBoxClientsUpdate";
            this.comboBoxClientsUpdate.Size = new System.Drawing.Size(184, 31);
            this.comboBoxClientsUpdate.TabIndex = 40;
            this.comboBoxClientsUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // Form_redactor_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1478, 765);
            this.Controls.Add(this.buttonRefill);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_redactor_orders";
            this.Text = "Form_redactor_orders";
            this.Load += new System.EventHandler(this.Form_redactor_orders_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRefill;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxCountAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxDateEndAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDateStartAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private Издательский_центрDataSet издательский_центрDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private Издательский_центрDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCountUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDateEndUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDateStartUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxIdUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNameBookDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxCountDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDateEndDelete;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxDateStartDelete;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxClientDelete;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxIdDelete;
        private System.Windows.Forms.ComboBox comboBoxBooksAdd;
        private System.Windows.Forms.ComboBox comboBoxClientsAdd;
        private System.Windows.Forms.ComboBox comboBoxBooksUpdate;
        private System.Windows.Forms.ComboBox comboBoxClientsUpdate;
    }
}