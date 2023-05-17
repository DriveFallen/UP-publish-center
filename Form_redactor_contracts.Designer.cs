namespace Издательский_центр
{
    partial class Form_redactor_contracts
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
            this.dataGridViewContracts = new System.Windows.Forms.DataGridView();
            this.iDContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contracttermDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractclosedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.datestopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.издательский_центрDataSet = new Издательский_центр.Издательский_центрDataSet();
            this.contractsTableAdapter = new Издательский_центр.Издательский_центрDataSetTableAdapters.ContractsTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.checkBoxCloseUpdate = new System.Windows.Forms.CheckBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDateEndUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDateTermUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDateStartUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIdContractUpdate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(1386, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(37, 36);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "X";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridViewContracts
            // 
            this.dataGridViewContracts.AutoGenerateColumns = false;
            this.dataGridViewContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDContractDataGridViewTextBoxColumn,
            this.datestartDataGridViewTextBoxColumn,
            this.contracttermDataGridViewTextBoxColumn,
            this.contractclosedDataGridViewCheckBoxColumn,
            this.datestopDataGridViewTextBoxColumn});
            this.dataGridViewContracts.DataSource = this.contractsBindingSource;
            this.dataGridViewContracts.Location = new System.Drawing.Point(613, 54);
            this.dataGridViewContracts.Name = "dataGridViewContracts";
            this.dataGridViewContracts.Size = new System.Drawing.Size(810, 699);
            this.dataGridViewContracts.TabIndex = 8;
            this.dataGridViewContracts.SelectionChanged += new System.EventHandler(this.dataGridViewContracts_SelectionChanged);
            // 
            // iDContractDataGridViewTextBoxColumn
            // 
            this.iDContractDataGridViewTextBoxColumn.DataPropertyName = "ID_Contract";
            this.iDContractDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.iDContractDataGridViewTextBoxColumn.Name = "iDContractDataGridViewTextBoxColumn";
            this.iDContractDataGridViewTextBoxColumn.Width = 66;
            // 
            // datestartDataGridViewTextBoxColumn
            // 
            this.datestartDataGridViewTextBoxColumn.DataPropertyName = "Date_start";
            this.datestartDataGridViewTextBoxColumn.HeaderText = "Дата подписания";
            this.datestartDataGridViewTextBoxColumn.Name = "datestartDataGridViewTextBoxColumn";
            this.datestartDataGridViewTextBoxColumn.Width = 111;
            // 
            // contracttermDataGridViewTextBoxColumn
            // 
            this.contracttermDataGridViewTextBoxColumn.DataPropertyName = "Contract_term";
            this.contracttermDataGridViewTextBoxColumn.HeaderText = "Длительность лет";
            this.contracttermDataGridViewTextBoxColumn.Name = "contracttermDataGridViewTextBoxColumn";
            this.contracttermDataGridViewTextBoxColumn.Width = 114;
            // 
            // contractclosedDataGridViewCheckBoxColumn
            // 
            this.contractclosedDataGridViewCheckBoxColumn.DataPropertyName = "Contract_closed";
            this.contractclosedDataGridViewCheckBoxColumn.HeaderText = "Закрыт";
            this.contractclosedDataGridViewCheckBoxColumn.Name = "contractclosedDataGridViewCheckBoxColumn";
            this.contractclosedDataGridViewCheckBoxColumn.Width = 51;
            // 
            // datestopDataGridViewTextBoxColumn
            // 
            this.datestopDataGridViewTextBoxColumn.DataPropertyName = "Date_stop";
            this.datestopDataGridViewTextBoxColumn.HeaderText = "Дата окончания";
            this.datestopDataGridViewTextBoxColumn.Name = "datestopDataGridViewTextBoxColumn";
            this.datestopDataGridViewTextBoxColumn.Width = 105;
            // 
            // contractsBindingSource
            // 
            this.contractsBindingSource.DataMember = "Contracts";
            this.contractsBindingSource.DataSource = this.издательский_центрDataSet;
            // 
            // издательский_центрDataSet
            // 
            this.издательский_центрDataSet.DataSetName = "Издательский_центрDataSet";
            this.издательский_центрDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractsTableAdapter
            // 
            this.contractsTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUpdate);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 741);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPageUpdate.Controls.Add(this.checkBoxCloseUpdate);
            this.tabPageUpdate.Controls.Add(this.buttonUpdate);
            this.tabPageUpdate.Controls.Add(this.label5);
            this.tabPageUpdate.Controls.Add(this.textBoxDateEndUpdate);
            this.tabPageUpdate.Controls.Add(this.label6);
            this.tabPageUpdate.Controls.Add(this.textBoxDateTermUpdate);
            this.tabPageUpdate.Controls.Add(this.label7);
            this.tabPageUpdate.Controls.Add(this.textBoxDateStartUpdate);
            this.tabPageUpdate.Controls.Add(this.label8);
            this.tabPageUpdate.Controls.Add(this.textBoxIdContractUpdate);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 32);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(588, 705);
            this.tabPageUpdate.TabIndex = 1;
            this.tabPageUpdate.Text = "Изменить";
            // 
            // checkBoxCloseUpdate
            // 
            this.checkBoxCloseUpdate.AutoSize = true;
            this.checkBoxCloseUpdate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCloseUpdate.Location = new System.Drawing.Point(204, 336);
            this.checkBoxCloseUpdate.Name = "checkBoxCloseUpdate";
            this.checkBoxCloseUpdate.Size = new System.Drawing.Size(183, 30);
            this.checkBoxCloseUpdate.TabIndex = 18;
            this.checkBoxCloseUpdate.Text = "Контракт закрыт ";
            this.checkBoxCloseUpdate.UseVisualStyleBackColor = true;
            this.checkBoxCloseUpdate.CheckedChanged += new System.EventHandler(this.textBoxContractUpdate_TextChanged);
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
            this.label5.Location = new System.Drawing.Point(214, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Дата окончания";
            // 
            // textBoxDateEndUpdate
            // 
            this.textBoxDateEndUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateEndUpdate.Location = new System.Drawing.Point(187, 412);
            this.textBoxDateEndUpdate.MaxLength = 12;
            this.textBoxDateEndUpdate.Name = "textBoxDateEndUpdate";
            this.textBoxDateEndUpdate.Size = new System.Drawing.Size(216, 31);
            this.textBoxDateEndUpdate.TabIndex = 15;
            this.textBoxDateEndUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDateEndUpdate.TextChanged += new System.EventHandler(this.textBoxContractUpdate_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(190, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Длительность в годах";
            // 
            // textBoxDateTermUpdate
            // 
            this.textBoxDateTermUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateTermUpdate.Location = new System.Drawing.Point(231, 274);
            this.textBoxDateTermUpdate.MaxLength = 50;
            this.textBoxDateTermUpdate.Name = "textBoxDateTermUpdate";
            this.textBoxDateTermUpdate.Size = new System.Drawing.Size(122, 31);
            this.textBoxDateTermUpdate.TabIndex = 13;
            this.textBoxDateTermUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDateTermUpdate.TextChanged += new System.EventHandler(this.textBoxContractUpdate_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(211, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Дата подписания";
            // 
            // textBoxDateStartUpdate
            // 
            this.textBoxDateStartUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDateStartUpdate.Location = new System.Drawing.Point(187, 191);
            this.textBoxDateStartUpdate.MaxLength = 50;
            this.textBoxDateStartUpdate.Name = "textBoxDateStartUpdate";
            this.textBoxDateStartUpdate.Size = new System.Drawing.Size(216, 29);
            this.textBoxDateStartUpdate.TabIndex = 11;
            this.textBoxDateStartUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDateStartUpdate.TextChanged += new System.EventHandler(this.textBoxContractUpdate_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(262, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Номер";
            // 
            // textBoxIdContractUpdate
            // 
            this.textBoxIdContractUpdate.Enabled = false;
            this.textBoxIdContractUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIdContractUpdate.Location = new System.Drawing.Point(200, 106);
            this.textBoxIdContractUpdate.MaxLength = 11;
            this.textBoxIdContractUpdate.Name = "textBoxIdContractUpdate";
            this.textBoxIdContractUpdate.Size = new System.Drawing.Size(187, 31);
            this.textBoxIdContractUpdate.TabIndex = 9;
            this.textBoxIdContractUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIdContractUpdate.TextChanged += new System.EventHandler(this.textBoxContractUpdate_TextChanged);
            // 
            // Form_redactor_contracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1435, 761);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridViewContracts);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_redactor_contracts";
            this.Text = "Form_redactor_contracts";
            this.Load += new System.EventHandler(this.Form_redactor_contracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridViewContracts;
        private Издательский_центрDataSet издательский_центрDataSet;
        private System.Windows.Forms.BindingSource contractsBindingSource;
        private Издательский_центрDataSetTableAdapters.ContractsTableAdapter contractsTableAdapter;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDateEndUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDateTermUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDateStartUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxIdContractUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contracttermDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn contractclosedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestopDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox checkBoxCloseUpdate;
    }
}