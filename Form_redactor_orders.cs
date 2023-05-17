using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Издательский_центр
{
    public partial class Form_redactor_orders : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DriveFallen\SQLEXPRESS; Initial catalog=Издательский_центр; Integrated Security=True");
        public Form_main form_main;
        public int option;
        public Form_redactor_orders()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            form_main.Show();
            this.Close();
        }

        private void Form_redactor_orders_Load(object sender, EventArgs e)
        {
            this.ordersTableAdapter.Fill(this.издательский_центрDataSet.Orders);

            tabControl1.Controls.Remove(tabPageAdd);
            tabControl1.Controls.Remove(tabPageUpdate);
            tabControl1.Controls.Remove(tabPageDelete);

            string strCom = "SELECT [Company_name] FROM [dbo].[Clients]";
            SqlCommand com = new SqlCommand(strCom, con);
            string strCom2 = "SELECT [Name] FROM [dbo].[Books]";
            SqlCommand com2 = new SqlCommand(strCom2, con);

            try
            {
                con.Open();

                SqlDataReader dataReader = com.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBoxClientsAdd.Items.Add(dataReader.GetString(0));
                    comboBoxClientsUpdate.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();

                SqlDataReader dataReader2 = com2.ExecuteReader();
                while (dataReader2.Read())
                {
                    comboBoxBooksAdd.Items.Add(dataReader2.GetString(0));
                    comboBoxBooksUpdate.Items.Add(dataReader2.GetString(0));
                }
                dataReader2.Close();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            switch (option)
            {
                case 1:
                    {
                        tabControl1.Controls.Add(tabPageAdd);
                    }
                    break;
                case 2:
                    {
                        tabControl1.Controls.Add(tabPageUpdate);
                    }
                    break;
                case 3:
                    {
                        tabControl1.Controls.Add(tabPageDelete);
                    }
                    break;
            }
        }

        private void dataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewBooks.SelectedRows)
                {
                    textBoxIdUpdate.Text = row.Cells[0].Value.ToString();
                    textBoxDateStartUpdate.Text = row.Cells[2].Value.ToString();
                    textBoxDateEndUpdate.Text = row.Cells[3].Value.ToString();
                    textBoxCountUpdate.Text = row.Cells[4].Value.ToString();

                    textBoxIdDelete.Text = row.Cells[0].Value.ToString();
                    textBoxClientDelete.Text = row.Cells[1].Value.ToString();
                    textBoxDateStartDelete.Text = row.Cells[2].Value.ToString();
                    textBoxDateEndDelete.Text = row.Cells[3].Value.ToString();
                    textBoxCountDelete.Text = row.Cells[4].Value.ToString();
                    textBoxNameBookDelete.Text = row.Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string strCom = "INSERT INTO [dbo].[Orders] " +
           "([Client_name],[Date_start],[Date_end],[Book],[Count]) " +
           "VALUES " +
           "(@Client_name, @Date_start, @Date_end, (SELECT [ID_Book] FROM [dbo].[Books] WHERE [Name] = @Book), @Count)";

            SqlCommand com = new SqlCommand(strCom, con);
            SqlParameter Client_name = new SqlParameter("@Client_name", comboBoxClientsAdd.Text);
            SqlParameter Date_start = new SqlParameter("@Date_start", textBoxDateStartAdd.Text);
            SqlParameter Date_end = new SqlParameter("@Date_end", textBoxDateEndAdd.Text);
            SqlParameter Book = new SqlParameter("@Book", comboBoxBooksAdd.Text);
            SqlParameter Count = new SqlParameter("@Count", textBoxCountAdd.Text);

            com.Parameters.Add(Client_name);
            com.Parameters.Add(Date_start);
            com.Parameters.Add(Date_end);
            com.Parameters.Add(Book);
            com.Parameters.Add(Count);

            try
            {
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            comboBoxClientsAdd.Text = "";
            textBoxDateStartAdd.Text = "";
            textBoxDateEndAdd.Text = "";
            textBoxCountAdd.Text = "";
            comboBoxBooksAdd.Text = "";

            this.ordersTableAdapter.Fill(this.издательский_центрDataSet.Orders);
        }

        private void textBoxAdd_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxClientsAdd.Text != string.Empty
                && textBoxDateStartAdd.Text != string.Empty
                && textBoxCountAdd.Text != string.Empty
                && comboBoxBooksAdd.Text != string.Empty)
            {
                buttonAdd.BackColor = Color.Lime;
                buttonAdd.Enabled = true;
            }
            else
            {
                buttonAdd.BackColor = Color.Red;
                buttonAdd.Enabled = false;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string strCom = "UPDATE [dbo].[Orders] SET " +
                "[Client_name] = @client " +
                ",[Date_start] = @dateStart " +
                ",[Date_end] = @dateEnd " +
                ",[Book] = @book " +
                ",[Count] = @count " +
                "WHERE [ID_Order] = @id";

            SqlCommand com = new SqlCommand(strCom, con);
            SqlParameter Client_name = new SqlParameter("@Client", comboBoxClientsAdd.Text);
            SqlParameter Date_start = new SqlParameter("@dateStart", textBoxDateStartAdd.Text);
            SqlParameter Date_end = new SqlParameter("@dateEnd", textBoxDateEndAdd.Text);
            SqlParameter Count = new SqlParameter("@count", textBoxCountAdd.Text);
            SqlParameter Book = new SqlParameter("@id", comboBoxBooksAdd.Text);

            com.Parameters.Add(Client_name);
            com.Parameters.Add(Date_start);
            com.Parameters.Add(Date_end);
            com.Parameters.Add(Count);
            com.Parameters.Add(Book);

            try
            {
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            textBoxIdUpdate.Text = "";
            comboBoxClientsUpdate.Text = "";
            textBoxDateStartUpdate.Text = "";
            textBoxDateEndUpdate.Text = "";
            textBoxCountUpdate.Text = "";
            comboBoxBooksUpdate.Text = "";

            this.ordersTableAdapter.Fill(this.издательский_центрDataSet.Orders);
        }

        private void textBoxUpdate_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxClientsUpdate.Text != string.Empty
                && textBoxDateStartUpdate.Text != string.Empty
                && textBoxCountUpdate.Text != string.Empty
                && comboBoxBooksUpdate.Text != string.Empty)
            {
                buttonUpdate.BackColor = Color.Lime;
                buttonUpdate.Enabled = true;
            }
            else
            {
                buttonUpdate.BackColor = Color.Red;
                buttonUpdate.Enabled = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string strCom = "DELETE FROM [dbo].[Orders] WHERE [ID_Order] = @id";

            SqlCommand com = new SqlCommand(strCom, con);
            SqlParameter id = new SqlParameter("@id", textBoxIdDelete.Text);

            com.Parameters.Add(id);

            try
            {
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            textBoxClientDelete.Text = "";
            textBoxDateStartDelete.Text = "";
            textBoxDateEndDelete.Text = "";
            textBoxCountDelete.Text = "";
            textBoxNameBookDelete.Text = "";

            this.ordersTableAdapter.Fill(this.издательский_центрDataSet.Orders);
        }

        private void textBoxDelete_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIdDelete.Text != string.Empty)
            {
                buttonAdd.BackColor = Color.Lime;
                buttonAdd.Enabled = true;
            }
            else
            {
                buttonAdd.BackColor = Color.Red;
                buttonAdd.Enabled = false;
            }
        }
    }
}
