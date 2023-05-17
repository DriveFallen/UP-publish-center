using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Издательский_центр
{
    public partial class Form_Authorization : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DriveFallen\SQLEXPRESS; Initial catalog=Издательский_центр; Integrated Security=True");
        public Form_Authorization()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string strLogIn = "Select [Name],[Surname],[Role],[Login] from [Users] where login = @login and password = @password";
            SqlCommand sqlCommandlogIn = new SqlCommand(strLogIn, con);
            SqlParameter sqlParameterlogin = new SqlParameter("@login", textBoxLogin.Text);
            SqlParameter sqlParameterPassword = new SqlParameter("@password", textBoxPassword.Text);
            sqlCommandlogIn.Parameters.Add(sqlParameterlogin);
            sqlCommandlogIn.Parameters.Add(sqlParameterPassword);

            try
            {
                con.Open();
                using (SqlDataReader reader = sqlCommandlogIn.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        List<string> list = new List<string>();
                        while (reader.Read())
                        {
                            list.Add(reader.GetString(0));
                            list.Add(reader.GetString(1));
                            list.Add(reader.GetString(2));
                            list.Add(reader.GetString(3));
                        }

                        Form_main form_main = new Form_main();

                        form_main._name = list[0];
                        form_main._surname = list[1];
                        form_main._role = list[2];
                        form_main.pictureBox1.ImageLocation = list[3] + ".jpg";
                        form_main.form_authorization = this;

                        form_main.Show();
                        this.Hide();
                        textBoxLogin.Text = string.Empty;
                        textBoxPassword.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Проверьте логин или пароль!", "Ошибка входа!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } 
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void textBoxPassword_MouseMove(object sender, MouseEventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void textBoxPassword_MouseLeave(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
