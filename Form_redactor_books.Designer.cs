namespace Издательский_центр
{
    partial class Form_redactor_books
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAuthorsAdd = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxHonorarAdd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPriceSellAdd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxPriceAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDateStartAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCountAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameAdd = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBoxAuthorsUpdate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHonorarUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPriceSellUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPriceUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDateStartUpdate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCountUpdate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNameUpdate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxIdUpdate = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxHonorarDelete = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxPriceSellDelete = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxPriceDelete = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxDateStartDelete = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxCountDelete = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxNameDelete = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxIdDelete = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.iDBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateoutputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricecostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricesaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.honorariumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.издательский_центрDataSet = new Издательский_центр.Издательский_центрDataSet();
            this.booksTableAdapter = new Издательский_центр.Издательский_центрDataSetTableAdapters.BooksTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(1422, 6);
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
            this.buttonRefill.TabIndex = 12;
            this.buttonRefill.Text = "Обновить";
            this.buttonRefill.UseVisualStyleBackColor = false;
            this.buttonRefill.Click += new System.EventHandler(this.buttonRefill_Click);
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
            this.tabControl1.TabIndex = 11;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPageAdd.Controls.Add(this.label1);
            this.tabPageAdd.Controls.Add(this.comboBoxAuthorsAdd);
            this.tabPageAdd.Controls.Add(this.label15);
            this.tabPageAdd.Controls.Add(this.textBoxHonorarAdd);
            this.tabPageAdd.Controls.Add(this.label14);
            this.tabPageAdd.Controls.Add(this.textBoxPriceSellAdd);
            this.tabPageAdd.Controls.Add(this.label13);
            this.tabPageAdd.Controls.Add(this.textBoxPriceAdd);
            this.tabPageAdd.Controls.Add(this.label4);
            this.tabPageAdd.Controls.Add(this.textBoxDateStartAdd);
            this.tabPageAdd.Controls.Add(this.label3);
            this.tabPageAdd.Controls.Add(this.textBoxCountAdd);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Автор";
            // 
            // comboBoxAuthorsAdd
            // 
            this.comboBoxAuthorsAdd.FormattingEnabled = true;
            this.comboBoxAuthorsAdd.Location = new System.Drawing.Point(174, 159);
            this.comboBoxAuthorsAdd.Name = "comboBoxAuthorsAdd";
            this.comboBoxAuthorsAdd.Size = new System.Drawing.Size(235, 31);
            this.comboBoxAuthorsAdd.TabIndex = 28;
            this.comboBoxAuthorsAdd.SelectedIndexChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(253, 493);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 23);
            this.label15.TabIndex = 27;
            this.label15.Text = "Гонорар";
            // 
            // textBoxHonorarAdd
            // 
            this.textBoxHonorarAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHonorarAdd.Location = new System.Drawing.Point(213, 519);
            this.textBoxHonorarAdd.MaxLength = 11;
            this.textBoxHonorarAdd.Name = "textBoxHonorarAdd";
            this.textBoxHonorarAdd.Size = new System.Drawing.Size(155, 31);
            this.textBoxHonorarAdd.TabIndex = 26;
            this.textBoxHonorarAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHonorarAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(228, 433);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 23);
            this.label14.TabIndex = 25;
            this.label14.Text = "Цена продажи";
            // 
            // textBoxPriceSellAdd
            // 
            this.textBoxPriceSellAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceSellAdd.Location = new System.Drawing.Point(213, 459);
            this.textBoxPriceSellAdd.MaxLength = 11;
            this.textBoxPriceSellAdd.Name = "textBoxPriceSellAdd";
            this.textBoxPriceSellAdd.Size = new System.Drawing.Size(155, 31);
            this.textBoxPriceSellAdd.TabIndex = 24;
            this.textBoxPriceSellAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPriceSellAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(227, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 23);
            this.label13.TabIndex = 23;
            this.label13.Text = "Себестоимость";
            // 
            // textBoxPriceAdd
            // 
            this.textBoxPriceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceAdd.Location = new System.Drawing.Point(213, 399);
            this.textBoxPriceAdd.MaxLength = 11;
            this.textBoxPriceAdd.Name = "textBoxPriceAdd";
            this.textBoxPriceAdd.Size = new System.Drawing.Size(155, 31);
            this.textBoxPriceAdd.TabIndex = 22;
            this.textBoxPriceAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPriceAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Дата выхода";
            // 
            // textBoxDateStartAdd
            // 
            this.textBoxDateStartAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateStartAdd.Location = new System.Drawing.Point(201, 339);
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
            this.label3.Location = new System.Drawing.Point(240, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Количество";
            // 
            // textBoxCountAdd
            // 
            this.textBoxCountAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountAdd.Location = new System.Drawing.Point(239, 279);
            this.textBoxCountAdd.MaxLength = 11;
            this.textBoxCountAdd.Name = "textBoxCountAdd";
            this.textBoxCountAdd.Size = new System.Drawing.Size(106, 31);
            this.textBoxCountAdd.TabIndex = 18;
            this.textBoxCountAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCountAdd.TextChanged += new System.EventHandler(this.textBoxAdd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Название";
            // 
            // textBoxNameAdd
            // 
            this.textBoxNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameAdd.Location = new System.Drawing.Point(49, 219);
            this.textBoxNameAdd.MaxLength = 50;
            this.textBoxNameAdd.Name = "textBoxNameAdd";
            this.textBoxNameAdd.Size = new System.Drawing.Size(485, 31);
            this.textBoxNameAdd.TabIndex = 16;
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
            this.tabPageUpdate.Controls.Add(this.label22);
            this.tabPageUpdate.Controls.Add(this.comboBoxAuthorsUpdate);
            this.tabPageUpdate.Controls.Add(this.label5);
            this.tabPageUpdate.Controls.Add(this.textBoxHonorarUpdate);
            this.tabPageUpdate.Controls.Add(this.label6);
            this.tabPageUpdate.Controls.Add(this.textBoxPriceSellUpdate);
            this.tabPageUpdate.Controls.Add(this.label7);
            this.tabPageUpdate.Controls.Add(this.textBoxPriceUpdate);
            this.tabPageUpdate.Controls.Add(this.label8);
            this.tabPageUpdate.Controls.Add(this.textBoxDateStartUpdate);
            this.tabPageUpdate.Controls.Add(this.label9);
            this.tabPageUpdate.Controls.Add(this.textBoxCountUpdate);
            this.tabPageUpdate.Controls.Add(this.label10);
            this.tabPageUpdate.Controls.Add(this.textBoxNameUpdate);
            this.tabPageUpdate.Controls.Add(this.label11);
            this.tabPageUpdate.Controls.Add(this.textBoxIdUpdate);
            this.tabPageUpdate.Controls.Add(this.buttonUpdate);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 32);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(588, 705);
            this.tabPageUpdate.TabIndex = 1;
            this.tabPageUpdate.Text = "Изменить";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(267, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 23);
            this.label22.TabIndex = 43;
            this.label22.Text = "Автор";
            // 
            // comboBoxAuthorsUpdate
            // 
            this.comboBoxAuthorsUpdate.FormattingEnabled = true;
            this.comboBoxAuthorsUpdate.Location = new System.Drawing.Point(180, 59);
            this.comboBoxAuthorsUpdate.Name = "comboBoxAuthorsUpdate";
            this.comboBoxAuthorsUpdate.Size = new System.Drawing.Size(235, 31);
            this.comboBoxAuthorsUpdate.TabIndex = 42;
            this.comboBoxAuthorsUpdate.SelectedIndexChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "Гонорар";
            // 
            // textBoxHonorarUpdate
            // 
            this.textBoxHonorarUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHonorarUpdate.Location = new System.Drawing.Point(217, 479);
            this.textBoxHonorarUpdate.MaxLength = 11;
            this.textBoxHonorarUpdate.Name = "textBoxHonorarUpdate";
            this.textBoxHonorarUpdate.Size = new System.Drawing.Size(155, 31);
            this.textBoxHonorarUpdate.TabIndex = 40;
            this.textBoxHonorarUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHonorarUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Цена продажи";
            // 
            // textBoxPriceSellUpdate
            // 
            this.textBoxPriceSellUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceSellUpdate.Location = new System.Drawing.Point(217, 419);
            this.textBoxPriceSellUpdate.MaxLength = 11;
            this.textBoxPriceSellUpdate.Name = "textBoxPriceSellUpdate";
            this.textBoxPriceSellUpdate.Size = new System.Drawing.Size(155, 31);
            this.textBoxPriceSellUpdate.TabIndex = 38;
            this.textBoxPriceSellUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPriceSellUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "Себестоимость";
            // 
            // textBoxPriceUpdate
            // 
            this.textBoxPriceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceUpdate.Location = new System.Drawing.Point(217, 359);
            this.textBoxPriceUpdate.MaxLength = 11;
            this.textBoxPriceUpdate.Name = "textBoxPriceUpdate";
            this.textBoxPriceUpdate.Size = new System.Drawing.Size(155, 31);
            this.textBoxPriceUpdate.TabIndex = 36;
            this.textBoxPriceUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPriceUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 23);
            this.label8.TabIndex = 35;
            this.label8.Text = "Дата выхода";
            // 
            // textBoxDateStartUpdate
            // 
            this.textBoxDateStartUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateStartUpdate.Location = new System.Drawing.Point(205, 299);
            this.textBoxDateStartUpdate.MaxLength = 11;
            this.textBoxDateStartUpdate.Name = "textBoxDateStartUpdate";
            this.textBoxDateStartUpdate.Size = new System.Drawing.Size(184, 31);
            this.textBoxDateStartUpdate.TabIndex = 34;
            this.textBoxDateStartUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDateStartUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "Количество";
            // 
            // textBoxCountUpdate
            // 
            this.textBoxCountUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountUpdate.Location = new System.Drawing.Point(243, 239);
            this.textBoxCountUpdate.MaxLength = 11;
            this.textBoxCountUpdate.Name = "textBoxCountUpdate";
            this.textBoxCountUpdate.Size = new System.Drawing.Size(106, 31);
            this.textBoxCountUpdate.TabIndex = 32;
            this.textBoxCountUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCountUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 23);
            this.label10.TabIndex = 31;
            this.label10.Text = "Название";
            // 
            // textBoxNameUpdate
            // 
            this.textBoxNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameUpdate.Location = new System.Drawing.Point(53, 179);
            this.textBoxNameUpdate.MaxLength = 50;
            this.textBoxNameUpdate.Name = "textBoxNameUpdate";
            this.textBoxNameUpdate.Size = new System.Drawing.Size(485, 31);
            this.textBoxNameUpdate.TabIndex = 30;
            this.textBoxNameUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNameUpdate.TextChanged += new System.EventHandler(this.textBoxUpdate_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(262, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "Номер";
            // 
            // textBoxIdUpdate
            // 
            this.textBoxIdUpdate.Enabled = false;
            this.textBoxIdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIdUpdate.Location = new System.Drawing.Point(217, 119);
            this.textBoxIdUpdate.MaxLength = 1000;
            this.textBoxIdUpdate.Name = "textBoxIdUpdate";
            this.textBoxIdUpdate.Size = new System.Drawing.Size(155, 31);
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
            this.tabPageDelete.Controls.Add(this.label12);
            this.tabPageDelete.Controls.Add(this.textBoxHonorarDelete);
            this.tabPageDelete.Controls.Add(this.label16);
            this.tabPageDelete.Controls.Add(this.textBoxPriceSellDelete);
            this.tabPageDelete.Controls.Add(this.label17);
            this.tabPageDelete.Controls.Add(this.textBoxPriceDelete);
            this.tabPageDelete.Controls.Add(this.label18);
            this.tabPageDelete.Controls.Add(this.textBoxDateStartDelete);
            this.tabPageDelete.Controls.Add(this.label19);
            this.tabPageDelete.Controls.Add(this.textBoxCountDelete);
            this.tabPageDelete.Controls.Add(this.label20);
            this.tabPageDelete.Controls.Add(this.textBoxNameDelete);
            this.tabPageDelete.Controls.Add(this.label21);
            this.tabPageDelete.Controls.Add(this.textBoxIdDelete);
            this.tabPageDelete.Controls.Add(this.buttonDelete);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 32);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDelete.Size = new System.Drawing.Size(588, 705);
            this.tabPageDelete.TabIndex = 2;
            this.tabPageDelete.Text = "Удалить";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(253, 448);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 23);
            this.label12.TabIndex = 41;
            this.label12.Text = "Гонорар";
            // 
            // textBoxHonorarDelete
            // 
            this.textBoxHonorarDelete.Enabled = false;
            this.textBoxHonorarDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHonorarDelete.Location = new System.Drawing.Point(213, 474);
            this.textBoxHonorarDelete.MaxLength = 11;
            this.textBoxHonorarDelete.Name = "textBoxHonorarDelete";
            this.textBoxHonorarDelete.Size = new System.Drawing.Size(155, 31);
            this.textBoxHonorarDelete.TabIndex = 40;
            this.textBoxHonorarDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHonorarDelete.TextChanged += new System.EventHandler(this.textBoxDelete_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(228, 388);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 23);
            this.label16.TabIndex = 39;
            this.label16.Text = "Цена продажи";
            // 
            // textBoxPriceSellDelete
            // 
            this.textBoxPriceSellDelete.Enabled = false;
            this.textBoxPriceSellDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceSellDelete.Location = new System.Drawing.Point(213, 414);
            this.textBoxPriceSellDelete.MaxLength = 11;
            this.textBoxPriceSellDelete.Name = "textBoxPriceSellDelete";
            this.textBoxPriceSellDelete.Size = new System.Drawing.Size(155, 31);
            this.textBoxPriceSellDelete.TabIndex = 38;
            this.textBoxPriceSellDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPriceSellDelete.TextChanged += new System.EventHandler(this.textBoxDelete_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(227, 328);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 23);
            this.label17.TabIndex = 37;
            this.label17.Text = "Себестоимость";
            // 
            // textBoxPriceDelete
            // 
            this.textBoxPriceDelete.Enabled = false;
            this.textBoxPriceDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPriceDelete.Location = new System.Drawing.Point(213, 354);
            this.textBoxPriceDelete.MaxLength = 11;
            this.textBoxPriceDelete.Name = "textBoxPriceDelete";
            this.textBoxPriceDelete.Size = new System.Drawing.Size(155, 31);
            this.textBoxPriceDelete.TabIndex = 36;
            this.textBoxPriceDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPriceDelete.TextChanged += new System.EventHandler(this.textBoxDelete_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(235, 268);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 23);
            this.label18.TabIndex = 35;
            this.label18.Text = "Дата выхода";
            // 
            // textBoxDateStartDelete
            // 
            this.textBoxDateStartDelete.Enabled = false;
            this.textBoxDateStartDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateStartDelete.Location = new System.Drawing.Point(201, 294);
            this.textBoxDateStartDelete.MaxLength = 11;
            this.textBoxDateStartDelete.Name = "textBoxDateStartDelete";
            this.textBoxDateStartDelete.Size = new System.Drawing.Size(184, 31);
            this.textBoxDateStartDelete.TabIndex = 34;
            this.textBoxDateStartDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDateStartDelete.TextChanged += new System.EventHandler(this.textBoxDelete_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(240, 208);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 23);
            this.label19.TabIndex = 33;
            this.label19.Text = "Количество";
            // 
            // textBoxCountDelete
            // 
            this.textBoxCountDelete.Enabled = false;
            this.textBoxCountDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountDelete.Location = new System.Drawing.Point(239, 234);
            this.textBoxCountDelete.MaxLength = 11;
            this.textBoxCountDelete.Name = "textBoxCountDelete";
            this.textBoxCountDelete.Size = new System.Drawing.Size(106, 31);
            this.textBoxCountDelete.TabIndex = 32;
            this.textBoxCountDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCountDelete.TextChanged += new System.EventHandler(this.textBoxDelete_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(247, 148);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 23);
            this.label20.TabIndex = 31;
            this.label20.Text = "Название";
            // 
            // textBoxNameDelete
            // 
            this.textBoxNameDelete.Enabled = false;
            this.textBoxNameDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameDelete.Location = new System.Drawing.Point(49, 174);
            this.textBoxNameDelete.MaxLength = 50;
            this.textBoxNameDelete.Name = "textBoxNameDelete";
            this.textBoxNameDelete.Size = new System.Drawing.Size(485, 31);
            this.textBoxNameDelete.TabIndex = 30;
            this.textBoxNameDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNameDelete.TextChanged += new System.EventHandler(this.textBoxDelete_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(255, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 23);
            this.label21.TabIndex = 29;
            this.label21.Text = "Номер";
            // 
            // textBoxIdDelete
            // 
            this.textBoxIdDelete.Enabled = false;
            this.textBoxIdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIdDelete.Location = new System.Drawing.Point(213, 114);
            this.textBoxIdDelete.MaxLength = 11;
            this.textBoxIdDelete.Name = "textBoxIdDelete";
            this.textBoxIdDelete.Size = new System.Drawing.Size(155, 31);
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
            this.iDBookDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.copysDataGridViewTextBoxColumn,
            this.dateoutputDataGridViewTextBoxColumn,
            this.pricecostDataGridViewTextBoxColumn,
            this.pricesaleDataGridViewTextBoxColumn,
            this.honorariumDataGridViewTextBoxColumn});
            this.dataGridViewBooks.DataSource = this.booksBindingSource;
            this.dataGridViewBooks.Location = new System.Drawing.Point(614, 61);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(845, 692);
            this.dataGridViewBooks.TabIndex = 10;
            this.dataGridViewBooks.SelectionChanged += new System.EventHandler(this.dataGridViewWriters_SelectionChanged);
            // 
            // iDBookDataGridViewTextBoxColumn
            // 
            this.iDBookDataGridViewTextBoxColumn.DataPropertyName = "ID_Book";
            this.iDBookDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.iDBookDataGridViewTextBoxColumn.Name = "iDBookDataGridViewTextBoxColumn";
            this.iDBookDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDBookDataGridViewTextBoxColumn.Width = 66;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 82;
            // 
            // copysDataGridViewTextBoxColumn
            // 
            this.copysDataGridViewTextBoxColumn.DataPropertyName = "Copys";
            this.copysDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.copysDataGridViewTextBoxColumn.Name = "copysDataGridViewTextBoxColumn";
            this.copysDataGridViewTextBoxColumn.Width = 91;
            // 
            // dateoutputDataGridViewTextBoxColumn
            // 
            this.dateoutputDataGridViewTextBoxColumn.DataPropertyName = "Date_output";
            this.dateoutputDataGridViewTextBoxColumn.HeaderText = "Дата выхода";
            this.dateoutputDataGridViewTextBoxColumn.Name = "dateoutputDataGridViewTextBoxColumn";
            this.dateoutputDataGridViewTextBoxColumn.Width = 90;
            // 
            // pricecostDataGridViewTextBoxColumn
            // 
            this.pricecostDataGridViewTextBoxColumn.DataPropertyName = "Price_cost";
            this.pricecostDataGridViewTextBoxColumn.HeaderText = "Себестоимость";
            this.pricecostDataGridViewTextBoxColumn.Name = "pricecostDataGridViewTextBoxColumn";
            this.pricecostDataGridViewTextBoxColumn.Width = 111;
            // 
            // pricesaleDataGridViewTextBoxColumn
            // 
            this.pricesaleDataGridViewTextBoxColumn.DataPropertyName = "Price_sale";
            this.pricesaleDataGridViewTextBoxColumn.HeaderText = "Цена продажи";
            this.pricesaleDataGridViewTextBoxColumn.Name = "pricesaleDataGridViewTextBoxColumn";
            this.pricesaleDataGridViewTextBoxColumn.Width = 96;
            // 
            // honorariumDataGridViewTextBoxColumn
            // 
            this.honorariumDataGridViewTextBoxColumn.DataPropertyName = "Honorarium";
            this.honorariumDataGridViewTextBoxColumn.HeaderText = "Гонорар";
            this.honorariumDataGridViewTextBoxColumn.Name = "honorariumDataGridViewTextBoxColumn";
            this.honorariumDataGridViewTextBoxColumn.Width = 74;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.издательский_центрDataSet;
            // 
            // издательский_центрDataSet
            // 
            this.издательский_центрDataSet.DataSetName = "Издательский_центрDataSet";
            this.издательский_центрDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // Form_redactor_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1466, 761);
            this.Controls.Add(this.buttonRefill);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_redactor_books";
            this.Text = "ё";
            this.Load += new System.EventHandler(this.Form_redactor_books_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRefill;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private Издательский_центрDataSet издательский_центрDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private Издательский_центрDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn copysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateoutputDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricecostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricesaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn honorariumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxHonorarAdd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxPriceSellAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxPriceAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDateStartAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCountAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHonorarUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPriceSellUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPriceUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDateStartUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCountUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNameUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxIdUpdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxHonorarDelete;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxPriceSellDelete;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxPriceDelete;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxDateStartDelete;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxCountDelete;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxNameDelete;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxIdDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAuthorsAdd;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBoxAuthorsUpdate;
    }
}