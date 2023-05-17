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
    public partial class Form_redactor_contracts : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DriveFallen\SQLEXPRESS; Initial catalog=Издательский_центр; Integrated Security=True");
        public Form_main form_main;

        public Form_redactor_contracts()
        {
            InitializeComponent();
        }

        private void Form_redactor_contracts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "издательский_центрDataSet.Contracts". При необходимости она может быть перемещена или удалена.
            this.contractsTableAdapter.Fill(this.издательский_центрDataSet.Contracts);

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            form_main.Show();
        }

        private void dataGridViewContracts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewContracts.SelectedRows)
                {
                    textBoxIdContractUpdate.Text = row.Cells[0].Value.ToString();
                    textBoxDateStartUpdate.Text = row.Cells[1].Value.ToString();
                    textBoxDateTermUpdate.Text = row.Cells[2].Value.ToString();
                    checkBoxCloseUpdate.Checked = (bool)row.Cells[3].Value;
                    textBoxDateEndUpdate.Text = row.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void textBoxContractUpdate_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIdContractUpdate.Text != string.Empty && textBoxDateStartUpdate.Text != string.Empty && textBoxDateTermUpdate.Text != string.Empty)
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
            string strCom = "UPDATE [dbo].[Contracts] " +
                "SET [Date_start] = @start " +
                ", [Contract_term] = @term " +
                ", [Contract_closed] = @close " +
                ", [Date_stop] = @stop " +
                "WHERE [ID_Contract] = @id";

            SqlCommand com = new SqlCommand(strCom, con);
            SqlParameter id = new SqlParameter("@id", textBoxIdContractUpdate.Text);
            SqlParameter start = new SqlParameter("@start", textBoxDateStartUpdate.Text);
            SqlParameter term = new SqlParameter("@term", textBoxDateTermUpdate.Text);
            SqlParameter close = new SqlParameter("@close", checkBoxCloseUpdate.Checked);
            SqlParameter stop = new SqlParameter("@stop", textBoxDateEndUpdate.Text);

            com.Parameters.Add(id);
            com.Parameters.Add(start);
            com.Parameters.Add(term);
            com.Parameters.Add(close);
            com.Parameters.Add(stop);

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

            textBoxIdContractUpdate.Text = "";
            textBoxDateStartUpdate.Text = "";
            textBoxDateTermUpdate.Text = "";
            checkBoxCloseUpdate.Checked = false;
            textBoxDateEndUpdate.Text = "";

            this.contractsTableAdapter.Fill(this.издательский_центрDataSet.Contracts);
        }
    }
}
