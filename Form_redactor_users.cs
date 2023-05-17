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
    public partial class Form_redactor_users : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DriveFallen\SQLEXPRESS; Initial catalog=Издательский_центр; Integrated Security=True");
        public Form_main form_main;
        public int option;
        public Form_redactor_users()
        {
            InitializeComponent();
        }

        private void Form_redactor_users_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.издательский_центрDataSet.Users);

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
                    for (int i = 0; i < dataGridViewWriters.Rows.Count-1; i++)
                    {
                        comboBoxLoginDelete.Items.Add(dataGridViewWriters.Rows[i].Cells[0].Value.ToString());
                    }
                    break;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            form_main.Show();
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string strCom = "INSERT INTO [dbo].[Users]" +
                "([Login],[Password],[Name],[Surname],[Role])" +
                "VALUES" +
                "(@login, @password, @name, @surname, @role)";

            SqlCommand com = new SqlCommand(strCom, con);
            SqlParameter login = new SqlParameter("@login", textBoxLoginAdd.Text);
            SqlParameter password = new SqlParameter("@password", textBoxPasswordAdd.Text);
            SqlParameter name = new SqlParameter("@name", textBoxNameAdd.Text);
            SqlParameter surname = new SqlParameter("@surname", textBoxSurnameAdd.Text);
            SqlParameter role = new SqlParameter("@role", comboBoxRoleAdd.Text);
            com.Parameters.Add(login);
            com.Parameters.Add(password);
            com.Parameters.Add(name);
            com.Parameters.Add(surname);
            com.Parameters.Add(role);

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

            textBoxLoginAdd.Text = "";
            textBoxPasswordAdd.Text = "";
            textBoxNameAdd.Text = "";
            textBoxSurnameAdd.Text = "";
            comboBoxRoleAdd.Text = "";

            this.usersTableAdapter.Fill(this.издательский_центрDataSet.Users);
        }
        private void textBoxAdd_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLoginAdd.Text != string.Empty && textBoxPasswordAdd.Text != string.Empty && textBoxNameAdd.Text != string.Empty && textBoxSurnameAdd.Text != string.Empty && comboBoxRoleAdd.Text != string.Empty)
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
        private void comboBoxRoleAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxLoginAdd.Text != string.Empty && textBoxPasswordAdd.Text != string.Empty && textBoxNameAdd.Text != string.Empty && textBoxSurnameAdd.Text != string.Empty && comboBoxRoleAdd.Text != string.Empty)
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string strCom = "UPDATE [dbo].[Users] SET " +
                "[Login] = @login, [Password] = @password, [Name] = @name, [Surname] = @surname, [Role] = @role" +
                " WHERE [Login] = @login";

            SqlCommand com = new SqlCommand(strCom, con);
            SqlParameter login = new SqlParameter("@login", textBoxLoginUpdate.Text);
            SqlParameter password = new SqlParameter("@password", textBoxPasswordUpdate.Text);
            SqlParameter name = new SqlParameter("@name", textBoxNameUpdate.Text);
            SqlParameter surname = new SqlParameter("@surname", textBoxSurnameUpdate.Text);
            SqlParameter role = new SqlParameter("@role", comboBoxRoleUpdate.Text);
            com.Parameters.Add(login);
            com.Parameters.Add(password);
            com.Parameters.Add(name);
            com.Parameters.Add(surname);
            com.Parameters.Add(role);

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

            textBoxLoginUpdate.Text = "";
            textBoxPasswordUpdate.Text = "";
            textBoxNameUpdate.Text = "";
            textBoxSurnameUpdate.Text = "";
            comboBoxRoleUpdate.Text = "";

            this.usersTableAdapter.Fill(this.издательский_центрDataSet.Users);
        }
        private void textBoxUpdate_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLoginUpdate.Text != string.Empty && textBoxPasswordUpdate.Text != string.Empty && textBoxNameUpdate.Text != string.Empty && textBoxSurnameUpdate.Text != string.Empty && comboBoxRoleUpdate.Text != string.Empty)
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
        private void comboBoxRoleUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBoxLoginUpdate.Text != string.Empty && textBoxPasswordUpdate.Text != string.Empty && textBoxNameUpdate.Text != string.Empty && textBoxSurnameUpdate.Text != string.Empty && comboBoxRoleUpdate.Text != string.Empty)
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
        private void dataGridViewWriters_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewWriters.SelectedRows)
            {
                textBoxLoginUpdate.Text = row.Cells[0].Value.ToString();
                textBoxPasswordUpdate.Text = row.Cells[1].Value.ToString();
                textBoxNameUpdate.Text = row.Cells[2].Value.ToString();
                textBoxSurnameUpdate.Text = row.Cells[3].Value.ToString();
                comboBoxRoleUpdate.Text = row.Cells[4].Value.ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string strCom = "DELETE FROM[dbo].[Users] WHERE [Login] = @login";

            SqlCommand com = new SqlCommand(strCom, con);
            SqlParameter login = new SqlParameter("@login", comboBoxLoginDelete.Text);
            com.Parameters.Add(login);
       
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

            comboBoxLoginDelete.Text = "";

           this.usersTableAdapter.Fill(this.издательский_центрDataSet.Users);
        }
        private void comboBoxLoginDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLoginDelete.Text != string.Empty)
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
    }
}
