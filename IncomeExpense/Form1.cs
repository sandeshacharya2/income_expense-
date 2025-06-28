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
    public partial class Form1 : Form
    {
        string stringConnection = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\expenses.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm= new RegisterForm();
            regForm.Show();
            this.Hide();

        }


        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }


        public static string username;


        private void login_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        // only aunthinticated user data will be shown
                        Session.UserId = Convert.ToInt32(table.Rows[0]["id"]); 
                        Session.Username = table.Rows[0]["username"].ToString();

                        MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username/password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void login_username_TextChanged(object sender, EventArgs e)
        {
            if (login_username.Text.Contains(" "))      // username fields should not be contain space
            {
                MessageBox.Show("Spaces are not allowed in username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                login_username.Text = login_username.Text.Replace(" ", "");
                login_username.SelectionStart = login_username.Text.Length; 
            }
        }

        private void login_btn_MouseEnter(object sender, EventArgs e)
        {
            login_btn.BackColor = Color.DarkGreen;  // trying to change back color 
        }

        private void login_btn_MouseLeave(object sender, EventArgs e)
        {
           login_btn.BackColor = Color.SeaGreen;
        }
    }
}
