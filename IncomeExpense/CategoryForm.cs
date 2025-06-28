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

namespace IncomeExpense
{
    public partial class CategoryForm : Form

    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\expenses.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public CategoryForm()
        {

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)

            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();
                    string insertData = "INSERT INTO categories (category, type, status, date_insert) " +
                                        "VALUES(@cat, @type, @status, @date)";
                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", category_category.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", category_type.SelectedItem);
                        cmd.Parameters.AddWithValue("@status", category_status.SelectedItem);
                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connect.Close();
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
