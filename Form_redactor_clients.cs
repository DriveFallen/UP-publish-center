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
    public partial class Form_redactor_clients : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DriveFallen\SQLEXPRESS; Initial catalog=Издательский_центр; Integrated Security=True");
        public Form_main form_main;
        public int option;
        public string oldName;
        public Form_redactor_clients()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            form_main.Show();
            this.Close();
        }

        private void Form_redactor_clients_Load(object sender, EventArgs e)
        {
            this.clientsTableAdapter.Fill(this.издательский_центрDataSet.Clients);

            tabControl1.Controls.Remove(tabPageAdd);
            tabControl1.Controls.Remove(tabPageUpdate);
            tabControl1.Controls.Remove(tabPageDelete);

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
                    textBoxNameUpdate.Text = row.Cells[0].Value.ToString();
                    textBoxAddressUpdate.Text = row.Cells[1].Value.ToString();
                    textBoxPhoneUpdate.Text = row.Cells[2].Value.ToString();
                    textBoxFullnameUpdate.Text = row.Cells[3].Value.ToString();

                    oldName = row.Cells[0].Value.ToString();

                    textBoxNameDelete.Text = row.Cells[0].Value.ToString();
                    textBoxAddressDelete.Text = row.Cells[1].Value.ToString();
                    textBoxPhoneDelete.Text = row.Cells[2].Value.ToString();
                    textBoxFullnameDelete.Text = row.Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string strCom = "INSERT INTO [dbo].[Clients] ([Company_name],[Address],[Phone],[Contact_fullname]) " +
           "VALUES (@name, @address, @phone, @contact_fullname)";

            SqlCommand com = new SqlCommand(strCom, con);
            SqlParameter Company_name = new SqlParameter("@name", textBoxNameAdd.Text);
            SqlParameter Address = new SqlParameter("@address", textBoxAddressAdd.Text);
            SqlParameter Phone = new SqlParameter("@phone", textBoxPhoneAdd.Text);
            SqlParameter Contact_fullname = new SqlParameter("@contact_fullname", textBoxFullnameAdd.Text);

            com.Parameters.Add(Company_name);
            com.Parameters.Add(Address);
            com.Parameters.Add(Phone);
            com.Parameters.Add(Contact_fullname);

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

            textBoxNameAdd.Text = "";
            textBoxAddressAdd.Text = "";
            textBoxPhoneAdd.Text = "";
            textBoxFullnameAdd.Text = "";

            this.clientsTableAdapter.Fill(this.издательский_центрDataSet.Clients);
        }

        private void textBoxAdd_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNameAdd.Text != string.Empty
                && textBoxAddressAdd.Text != string.Empty
                && textBoxPhoneAdd.Text != string.Empty
                && textBoxFullnameAdd.Text != string.Empty)
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
            string strCom = "UPDATE [dbo].[Clients] " +
                "SET [Company_name] = @name " +
                ",[Address] = @address " +
                ",[Phone] = @phone " +
                ",[Contact_fullname] = @fullname " +
                "WHERE [Company_name] = @oldName";

            SqlCommand com = new SqlCommand(strCom, con);
            SqlParameter oldname = new SqlParameter("@oldName", oldName);
            SqlParameter Company_name = new SqlParameter("@name", textBoxNameUpdate.Text);
            SqlParameter Address = new SqlParameter("@address", textBoxAddressUpdate.Text);
            SqlParameter Phone = new SqlParameter("@phone", textBoxPhoneUpdate.Text);
            SqlParameter Contact_fullname = new SqlParameter("@fullname", textBoxFullnameUpdate.Text);

            com.Parameters.Add(oldname);
            com.Parameters.Add(Company_name);
            com.Parameters.Add(Address);
            com.Parameters.Add(Phone);
            com.Parameters.Add(Contact_fullname);

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

            textBoxNameUpdate.Text = "";
            textBoxAddressUpdate.Text = "";
            textBoxPhoneUpdate.Text = "";
            textBoxFullnameUpdate.Text = "";

            this.clientsTableAdapter.Fill(this.издательский_центрDataSet.Clients);
        }

        private void textBoxUpdate_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNameUpdate.Text != string.Empty
                && textBoxAddressUpdate.Text != string.Empty
                && textBoxPhoneUpdate.Text != string.Empty
                && textBoxFullnameUpdate.Text != string.Empty)
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
            string strCom = "DELETE FROM [dbo].[Clients] WHERE [Company_name] = @name";

            SqlCommand com = new SqlCommand(strCom, con);
            SqlParameter Company_name = new SqlParameter("@name", textBoxNameDelete.Text);

            com.Parameters.Add(Company_name);

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

            textBoxNameDelete.Text = "";
            textBoxAddressDelete.Text = "";
            textBoxPhoneDelete.Text = "";
            textBoxFullnameDelete.Text = "";

            this.clientsTableAdapter.Fill(this.издательский_центрDataSet.Clients);
        }

        private void textBoxDelete_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNameDelete.Text != string.Empty)
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
    }
}
