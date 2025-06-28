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
    public partial class RegisterForm : Form
    {
        SqlConnection connect= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\expenses.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public RegisterForm()
        {
            InitializeComponent();
        }
        public bool checkConnetion()
        {
            return(connect.State== ConnectionState.Closed)? true: false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
                }

        private void register_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_cPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginform = new Form1();
            loginform.Show();
            this.Hide();
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (register_username.Text == "" || register_password.Text == "" || register_cPassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (register_password.Text.Length < 8)
            {
                MessageBox.Show("Invalid password. At least 8 characters are needed.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (register_password.Text != register_cPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkConnetion())
            {
                try
                {
                    connect.Open();

                    string selectUsername = "SELECT * FROM users WHERE username = @usern";
                    using (SqlCommand checkuser = new SqlCommand(selectUsername, connect))
                    {
                        checkuser.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkuser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            string tempUsern = char.ToUpper(register_username.Text[0]) + register_username.Text.Substring(1);
                            MessageBox.Show(tempUsern + " already exists.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new user
                    string insertData = "INSERT INTO users (username, password, date_create) VALUES (@usern, @pass, @date)";
                    using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                    {
                        insertUser.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                        insertUser.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                        insertUser.Parameters.AddWithValue("@date", DateTime.Today);

                        insertUser.ExecuteNonQuery();
                        MessageBox.Show("Registered successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Navigate to login
                        Form1 loginForm = new Form1();
                        loginForm.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Registration failed!\n\nError: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

    }
}

