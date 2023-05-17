using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Издательский_центр
{
    public partial class Form_redactor_books : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DriveFallen\SQLEXPRESS; Initial catalog=Издательский_центр; Integrated Security=True");
        public Form_main form_main;
        public int option;
        public Form_redactor_books()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            form_main.Show();
            this.Close();
        }

        private void buttonRefill_Click(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.издательский_центрDataSet.Books);
        }

        private void Form_redactor_books_Load(object sender, EventArgs e)
        {
            this.booksTableAdapter.Fill(this.издательский_центрDataSet.Books);
            tabControl1.Controls.Remove(tabPageAdd);
            tabControl1.Controls.Remove(tabPageUpdate);
            tabControl1.Controls.Remove(tabPageDelete);

            string strCom = "SELECT [Fullname] FROM [dbo].[Writers]";
            SqlCommand AllAuthors = new SqlCommand(strCom, con);

            try
            {
                con.Open();
                SqlDataReader dataReader = AllAuthors.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBoxAuthorsAdd.Items.Add(dataReader.GetString(0));
                    comboBoxAuthorsUpdate.Items.Add(dataReader.GetString(0));
                }
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

        private void dataGridViewWriters_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewBooks.SelectedRows)
                {
                    textBoxIdUpdate.Text = row.Cells[0].Value.ToString();
                    textBoxNameUpdate.Text = row.Cells[1].Value.ToString();
                    textBoxCountUpdate.Text = row.Cells[2].Value.ToString();
                    textBoxDateStartUpdate.Text = row.Cells[3].Value.ToString();
                    textBoxPriceUpdate.Text = row.Cells[4].Value.ToString().Substring(0, row.Cells[4].Value.ToString().Length - 5);
                    textBoxPriceSellUpdate.Text = row.Cells[5].Value.ToString().Substring(0, row.Cells[5].Value.ToString().Length - 5);
                    textBoxHonorarUpdate.Text = row.Cells[6].Value.ToString().Substring(0, row.Cells[6].Value.ToString().Length - 5);

                    textBoxIdDelete.Text = row.Cells[0].Value.ToString();
                    textBoxNameDelete.Text = row.Cells[1].Value.ToString();
                    textBoxCountDelete.Text = row.Cells[2].Value.ToString();
                    textBoxDateStartDelete.Text = row.Cells[3].Value.ToString();
                    textBoxPriceDelete.Text = row.Cells[4].Value.ToString();
                    textBoxPriceSellDelete.Text = row.Cells[5].Value.ToString();
                    textBoxHonorarDelete.Text = row.Cells[6].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void textBoxAdd_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxAuthorsAdd.Text != string.Empty
                && textBoxNameAdd.Text != string.Empty
                && textBoxCountAdd.Text != string.Empty
                && textBoxDateStartAdd.Text != string.Empty
                && textBoxPriceAdd.Text != string.Empty
                && textBoxPriceSellAdd.Text != string.Empty
                && textBoxHonorarAdd.Text != string.Empty)
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string strCom = "INSERT INTO [dbo].[Books] ([Name],[Copys],[Date_output],[Price_cost],[Price_sale],[Honorarium]) " +
            "VALUES (@name, @copy, @dateOut, @priceCost, @priceSale, @honorar) " +
            "INSERT INTO [dbo].[Writers_Books] " +
            "([ID_Writer],[ID_Book]) VALUES " +
            "((SELECT [ID_Writer] FROM [dbo].[Writers] WHERE [Fullname] = @fullname), " +
            "(SELECT [ID_Book] FROM [dbo].[Books] WHERE [Name] = @name))";

            SqlCommand com = new SqlCommand(strCom, con);
            SqlParameter name = new SqlParameter("@name", textBoxNameAdd.Text);
            SqlParameter copy = new SqlParameter("@copy", textBoxCountAdd.Text);
            SqlParameter dateOut = new SqlParameter("@dateOut", textBoxDateStartAdd.Text);
            SqlParameter priceCost = new SqlParameter("@priceCost", textBoxPriceAdd.Text);
            SqlParameter priceSale = new SqlParameter("@priceSale", textBoxPriceSellAdd.Text);
            SqlParameter honorar = new SqlParameter("@honorar", textBoxHonorarAdd.Text);
            SqlParameter fullname = new SqlParameter("@fullname", comboBoxAuthorsAdd.Text);


            com.Parameters.Add(name);
            com.Parameters.Add(copy);
            com.Parameters.Add(dateOut);
            com.Parameters.Add(priceCost);
            com.Parameters.Add(priceSale);
            com.Parameters.Add(honorar);
            com.Parameters.Add(fullname);

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

            comboBoxAuthorsAdd.Text = "";
            textBoxNameAdd.Text = "";
            textBoxCountAdd.Text = "";
            textBoxDateStartAdd.Text = "";
            textBoxPriceAdd.Text = "";
            textBoxPriceSellAdd.Text = "";
            textBoxHonorarAdd.Text = "";

            this.booksTableAdapter.Fill(this.издательский_центрDataSet.Books);
        }

        private void textBoxUpdate_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxAuthorsUpdate.Text != string.Empty
                && textBoxIdUpdate.Text != string.Empty
                && textBoxNameUpdate.Text != string.Empty
                && textBoxCountUpdate.Text != string.Empty
                && textBoxDateStartUpdate.Text != string.Empty
                && textBoxPriceUpdate.Text != string.Empty
                && textBoxPriceSellUpdate.Text != string.Empty
                && textBoxHonorarUpdate.Text != string.Empty)
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string strCom = "UPDATE [dbo].[Books] " +
                "SET [Name] = @name " +
                ", [Copys] = @copy " +
                ", [Date_output] = @dateOut " +
                ", [Price_cost] = @priceCost " +
                ", [Price_sale] = @priceSale " +
                ", [Honorarium] = @honorar " +
                "WHERE [ID_Book] = @id " +
                "UPDATE [dbo].[Writers_Books] " +
                "SET [ID_Writer] = (SELECT [ID_Writer] FROM [dbo].[Writers] WHERE [Fullname] = @fullname) " +
                "WHERE [ID_Book] = @id";

            SqlCommand com = new SqlCommand(strCom, con);
            SqlParameter id = new SqlParameter("@id", textBoxIdUpdate.Text);
            SqlParameter name = new SqlParameter("@name", textBoxNameUpdate.Text);
            SqlParameter copy = new SqlParameter("@copy", textBoxCountUpdate.Text);
            SqlParameter dateOut = new SqlParameter("@dateOut", textBoxDateStartUpdate.Text);
            SqlParameter priceCost = new SqlParameter("@priceCost", textBoxPriceUpdate.Text);
            SqlParameter priceSale = new SqlParameter("@priceSale", textBoxPriceSellUpdate.Text);
            SqlParameter honorar = new SqlParameter("@honorar", textBoxHonorarUpdate.Text);
            SqlParameter fullname = new SqlParameter("@fullname", comboBoxAuthorsUpdate.Text);


            com.Parameters.Add(id);
            com.Parameters.Add(name);
            com.Parameters.Add(copy);
            com.Parameters.Add(dateOut);
            com.Parameters.Add(priceCost);
            com.Parameters.Add(priceSale);
            com.Parameters.Add(honorar);
            com.Parameters.Add(fullname);

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

            comboBoxAuthorsUpdate.Text = "";
            textBoxIdUpdate.Text = "";
            textBoxNameUpdate.Text = "";
            textBoxCountUpdate.Text = "";
            textBoxDateStartUpdate.Text = "";
            textBoxPriceUpdate.Text = "";
            textBoxPriceSellUpdate.Text = "";
            textBoxHonorarUpdate.Text = "";

            this.booksTableAdapter.Fill(this.издательский_центрDataSet.Books);
        }

        private void textBoxDelete_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIdDelete.Text != string.Empty
               && textBoxNameDelete.Text != string.Empty
               && textBoxCountDelete.Text != string.Empty
               && textBoxDateStartDelete.Text != string.Empty
               && textBoxPriceDelete.Text != string.Empty
               && textBoxPriceSellDelete.Text != string.Empty
               && textBoxHonorarDelete.Text != string.Empty)
            {
                buttonDelete.BackColor = Color.Lime;
                buttonDelete.Enabled = true;
            }
            else
            {
                buttonDelete.BackColor = Color.Red;
                buttonDelete.Enabled = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string strCom = "DELETE FROM [dbo].[Books] " +
                "WHERE [ID_Book] = @id";

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

            textBoxIdDelete.Text = "";
            textBoxNameDelete.Text = "";
            textBoxCountDelete.Text = "";
            textBoxDateStartDelete.Text = "";
            textBoxPriceDelete.Text = "";
            textBoxPriceSellDelete.Text = "";
            textBoxHonorarDelete.Text = "";

            this.booksTableAdapter.Fill(this.издательский_центрDataSet.Books);
        }
    }
}
