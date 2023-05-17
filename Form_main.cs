using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.IO;
using WSLib;

namespace Издательский_центр
{
    public partial class Form_main : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DriveFallen\SQLEXPRESS; Initial catalog=Издательский_центр; Integrated Security=True");
        public Form_Authorization form_authorization;
        public string _name;
        public string _surname;
        public string _role;

        // скрытие всех вкладок
        public void tabPageHide()
        {
            tabControlFunctions.Controls.Remove(tabPageExport);
            tabControlFunctions.Controls.Remove(tabPageOrders);
            tabControlFunctions.Controls.Remove(tabPageWriters);
            tabControlFunctions.Controls.Remove(tabPageContracts);
            tabControlFunctions.Controls.Remove(tabPageBooks);
            tabControlFunctions.Controls.Remove(tabPageUsers);
            tabControlFunctions.Controls.Remove(tabPageClients);
        }

        // обновление всех таблиц
        private void refillAllTables()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательский_центрDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.издательский_центрDataSet.Clients);
            this.contractsTableAdapter.Fill(this.издательский_центрDataSet.Contracts);
            this.usersTableAdapter.Fill(this.издательский_центрDataSet.Users);
            this.booksTableAdapter.Fill(this.издательский_центрDataSet.Books);
            this.writersTableAdapter.Fill(this.издательский_центрDataSet.Writers);
            this.ordersTableAdapter.Fill(this.издательский_центрDataSet.Orders);
        }

        public Form_main()
        {
            InitializeComponent();
            tabPageHide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            ;
            form_authorization.Show();
            this.Close();
        }

        private void Form_main_Activated(object sender, EventArgs e)
        {
            refillAllTables();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            refillAllTables();

            string sqlAllTables = "USE [Издательский_центр] SELECT * FROM sys.tables";
            SqlCommand AllTables = new SqlCommand(sqlAllTables, con);

            try
            {
                con.Open();
                SqlDataReader dataReader = AllTables.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBoxTables.Items.Add(dataReader.GetString(0));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            labelName.Text += _name;
            labelSurname.Text += _surname;
            labelRole.Text += _role;

            switch (_role)
            {
                case "Admin":
                    tabControlFunctions.Controls.Add(tabPageExport);
                    tabControlFunctions.Controls.Add(tabPageOrders);
                    tabControlFunctions.Controls.Add(tabPageWriters);
                    tabControlFunctions.Controls.Add(tabPageContracts);
                    tabControlFunctions.Controls.Add(tabPageBooks);
                    tabControlFunctions.Controls.Add(tabPageUsers);
                    tabControlFunctions.Controls.Add(tabPageClients);
                    break;
                case "Writer":
                    tabControlFunctions.Controls.Add(tabPageContracts);
                    tabControlFunctions.Controls.Add(tabPageBooks);
                    break;
                case "Manager":
                    tabControlFunctions.Controls.Add(tabPageExport);
                    tabControlFunctions.Controls.Add(tabPageOrders);
                    tabControlFunctions.Controls.Add(tabPageWriters);
                    tabControlFunctions.Controls.Add(tabPageContracts);
                    tabControlFunctions.Controls.Add(tabPageBooks);
                    break;
                default:
                    break;
            }
        }

        private void buttonRefillTables_Click(object sender, EventArgs e)
        {
            refillAllTables();
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlExportTable = "select * from [" + comboBoxTables.Text + "]";
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sqlExportTable, con);
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                DataSet ds = new DataSet();
                sda.Fill(ds, "rtv");
                dataGridViewExport.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        private void button_export_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            for (int i = 0; i < dataGridViewExport.RowCount - 1; i++)
            {
                for (int j = 0; j < dataGridViewExport.ColumnCount; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridViewExport[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
            exApp.UserControl = true;
        }

        private void buttonAddWriters_Click(object sender, EventArgs e)
        {
            Form_redactor_writers form = new Form_redactor_writers();
            form.option = 1;
            form.form_main = this;
            form.Show();
            this.Hide();
        }

        private void buttonUpdateWriters_Click(object sender, EventArgs e)
        {
            Form_redactor_writers form = new Form_redactor_writers();
            form.option = 2;
            form.form_main = this;
            form.Show();
            this.Hide();
        }

        private void buttonDeleteWriters_Click(object sender, EventArgs e)
        {
            Form_redactor_writers form = new Form_redactor_writers();
            form.option = 3;
            form.form_main = this;
            form.Show();
            this.Hide();
        }

        private void buttonAddUsers_Click(object sender, EventArgs e)
        {
            Form_redactor_users form = new Form_redactor_users();
            form.option = 1;
            form.form_main = this;
            form.Show();
            this.Hide();
        }

        private void buttonUpdateUsers_Click(object sender, EventArgs e)
        {
            Form_redactor_users form = new Form_redactor_users();
            form.option = 2;
            form.form_main = this;
            form.Show();
            this.Hide();
        }

        private void buttonDeleteUsers_Click(object sender, EventArgs e)
        {
            Form_redactor_users form = new Form_redactor_users();
            form.option = 3;
            form.form_main = this;
            form.Show();
            this.Hide();
        }

        private void buttonUpdateContracts_Click(object sender, EventArgs e)
        {
            Form_redactor_contracts form = new Form_redactor_contracts();
            form.form_main = this;
            form.Show();
            this.Hide();
        }

        private void buttonAddBooks_Click(object sender, EventArgs e)
        {
            Form_redactor_books form = new Form_redactor_books();
            form.form_main = this;
            form.option = 1;
            form.Show();
            this.Hide();
        }

        private void buttonUpdateBooks_Click(object sender, EventArgs e)
        {
            Form_redactor_books form = new Form_redactor_books();
            form.form_main = this;
            form.option = 2;
            form.Show();
            this.Hide();
        }

        private void buttonDeleteBooks_Click(object sender, EventArgs e)
        {
            Form_redactor_books form = new Form_redactor_books();
            form.form_main = this;
            form.option = 3;
            form.Show();
            this.Hide();
        }

        private void buttonAddOrders_Click(object sender, EventArgs e)
        {
            Form_redactor_orders form = new Form_redactor_orders();
            form.form_main = this;
            form.option = 1;
            form.Show();
            this.Hide();
        }

        private void buttonUpdateOrders_Click(object sender, EventArgs e)
        {
            Form_redactor_orders form = new Form_redactor_orders();
            form.form_main = this;
            form.option = 2;
            form.Show();
            this.Hide();
        }

        private void buttonDeleteOrders_Click(object sender, EventArgs e)
        {
            Form_redactor_orders form = new Form_redactor_orders();
            form.form_main = this;
            form.option = 3;
            form.Show();
            this.Hide();
        }

        private void buttonClientsAdd_Click(object sender, EventArgs e)
        {
            Form_redactor_clients form = new Form_redactor_clients();
            form.form_main = this;
            form.option = 1;
            form.Show();
            this.Hide();
        }

        private void buttonClientsUpdate_Click(object sender, EventArgs e)
        {
            Form_redactor_clients form = new Form_redactor_clients();
            form.form_main = this;
            form.option = 2;
            form.Show();
            this.Hide();
        }

        private void buttonClientsDelete_Click(object sender, EventArgs e)
        {
            Form_redactor_clients form = new Form_redactor_clients();
            form.form_main = this;
            form.option = 3;
            form.Show();
            this.Hide();
        }
    }
}
