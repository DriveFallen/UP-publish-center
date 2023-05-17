using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Издательский_центр
{
    public partial class Form_redactor_writers : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DriveFallen\SQLEXPRESS; Initial catalog=Издательский_центр; Integrated Security=True");
        public Form_main form_main;
        public int option;
        string oldPassport;

        public Form_redactor_writers()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            form_main.Show();
        }

        private void Form_redactor_writers_Load(object sender, EventArgs e)
        {
            this.writersTableAdapter.Fill(this.издательский_центрDataSet.Writers);

            tabControl1.Controls.Remove(tabPageAdd);
            tabControl1.Controls.Remove(tabPageUpdate);
            tabControl1.Controls.Remove(tabPageDelete);

            switch (option)
            {
                case 1:
                    tabControl1.Controls.Add(tabPageAdd);
                    break;
                case 2:
                    tabControl1.Controls.Add(tabPageUpdate);
                    break;
                case 3:
                    tabControl1.Controls.Add(tabPageDelete);
                    break;
            }
        }

        private void dataGridViewWriters_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewWriters.SelectedRows)
                {
                    oldPassport = row.Cells[0].Value.ToString();
                    textBoxPassportUpdate.Text = row.Cells[0].Value.ToString();
                    textBoxFullnameUpdate.Text = row.Cells[1].Value.ToString();
                    textBoxAddressUpdate.Text = row.Cells[2].Value.ToString();
                    textBoxPhoneUpdate.Text = row.Cells[3].Value.ToString();

                    textBoxPassportDelete.Text = row.Cells[0].Value.ToString();
                    textBoxFullnameDelete.Text = row.Cells[1].Value.ToString();
                    textBoxAddressDelete.Text = row.Cells[2].Value.ToString();
                    textBoxPhoneDelete.Text = row.Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void textBoxAdd_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassportAdd.Text != string.Empty 
                && textBoxFullnameAdd.Text != string.Empty 
                && textBoxAddressAdd.Text != string.Empty 
                && textBoxPhoneAdd.Text != string.Empty)
            {
                buttonAdd.Enabled = true;
                buttonAdd.BackColor = Color.Lime;
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonAdd.BackColor = Color.Red;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string strCom = "INSERT INTO [dbo].[Writers]" +
                "([Passport_number],[Fullname],[Address],[Phone])" +
                "VALUES" +
                "(@passport, @fullname, @address, @phone)" +
                "INSERT INTO[dbo].[Contracts]" +
                "([ID_Contract],[Date_start],[Contract_term],[Contract_closed],[Date_stop])" +
                "VALUES" +
                "((SELECT MAX([ID_Writer]) FROM [dbo].[Writers]), CURRENT_TIMESTAMP, 1, 0, NULL)";

            SqlCommand com = new SqlCommand(strCom, con);
            SqlParameter passport = new SqlParameter("@passport", textBoxPassportAdd.Text);
            SqlParameter fullname = new SqlParameter("@fullname", textBoxFullnameAdd.Text);
            SqlParameter address = new SqlParameter("@address", textBoxAddressAdd.Text);
            SqlParameter phone = new SqlParameter("@phone", textBoxPhoneAdd.Text);
            com.Parameters.Add(passport);
            com.Parameters.Add(fullname);
            com.Parameters.Add(address);
            com.Parameters.Add(phone);

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

            textBoxPassportAdd.Text = "";
            textBoxFullnameAdd.Text = "";
            textBoxAddressAdd.Text = "";
            textBoxPhoneAdd.Text = "";

            this.writersTableAdapter.Fill(this.издательский_центрDataSet.Writers);
        }

        private void textBoxUpdate_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassportUpdate.Text != string.Empty && textBoxFullnameUpdate.Text != string.Empty && textBoxAddressUpdate.Text != string.Empty && textBoxPhoneUpdate.Text != string.Empty)
            {
                buttonUpdate.Enabled = true;
                buttonUpdate.BackColor = Color.Lime;
            }
            else
            {
                buttonUpdate.Enabled = false;
                buttonUpdate.BackColor = Color.Red;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string strCom = "UPDATE [dbo].[Writers] " +
                "SET [Passport_number] = @passport " +
                ", [Fullname] = @fullname " +
                ", [Address] = @address " +
                ", [Phone] = @phone " +
                "WHERE [Passport_number] = @oldPassport";

            SqlCommand com = new SqlCommand(strCom, con);
            SqlParameter oldpassport = new SqlParameter("@oldPassport", oldPassport);
            SqlParameter passport = new SqlParameter("@passport", textBoxPassportUpdate.Text);
            SqlParameter fullname = new SqlParameter("@fullname", textBoxFullnameUpdate.Text);
            SqlParameter address = new SqlParameter("@address", textBoxAddressUpdate.Text);
            SqlParameter phone = new SqlParameter("@phone", textBoxPhoneUpdate.Text);

            com.Parameters.Add(oldpassport);
            com.Parameters.Add(passport);
            com.Parameters.Add(fullname);
            com.Parameters.Add(address);
            com.Parameters.Add(phone);

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

            textBoxPassportUpdate.Text = "";
            textBoxFullnameUpdate.Text = "";
            textBoxAddressUpdate.Text = "";
            textBoxPhoneUpdate.Text = "";

            this.writersTableAdapter.Fill(this.издательский_центрDataSet.Writers);
        }

        private void textBoxDelete_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassportDelete.Text != string.Empty)
            {
                buttonDelete.Enabled = true;
                buttonDelete.BackColor = Color.Lime;
            }
            else
            {
                buttonDelete.Enabled = false;
                buttonDelete.BackColor = Color.Red;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string strCom = "DELETE FROM [dbo].[Contracts] " +
                "WHERE[ID_Contract] = (SELECT[ID_Writer] FROM[dbo].[Writers] WHERE [Passport_number] = @passport) " +
                "DELETE FROM[dbo].[Writers] " +
                "WHERE[ID_Writer] = (SELECT[ID_Writer] FROM [dbo].[Writers] WHERE [Passport_number] = @passport)";

            SqlCommand com = new SqlCommand(strCom, con);
            SqlParameter passport = new SqlParameter("@passport", textBoxPassportDelete.Text);
            com.Parameters.Add(passport);

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

            textBoxPassportDelete.Text = "";
            textBoxFullnameDelete.Text = "";
            textBoxAddressDelete.Text = "";
            textBoxPhoneDelete.Text = "";

            this.writersTableAdapter.Fill(this.издательский_центрDataSet.Writers);
        }

        private void buttonRefill_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательский_центрDataSet.Writers". При необходимости она может быть перемещена или удалена.
            this.writersTableAdapter.Fill(this.издательский_центрDataSet.Writers);
        }
    }
}
