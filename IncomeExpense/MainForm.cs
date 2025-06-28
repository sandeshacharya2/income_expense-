using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncomeExpense
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
            displayUsername();
        }
        public void displayUsername()
        {
            string getUsername = Session.Username;

            if (!string.IsNullOrEmpty(getUsername))
            {
                greetUser.Text = "Welcome, " +
                    char.ToUpper(getUsername[0]) + getUsername.Substring(1);
            }
            else
            {
                greetUser.Text = "Welcome, User";
            }
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboardUserForm1.Visible = true;
            categoriesForm1.Visible = false;
            incomeForm1.Visible = false;
            expenseForm1.Visible = false;

            DashboardUserForm dForm = dashboardUserForm1 as DashboardUserForm;
            if (dForm != null)
            {

                dForm.refreshData();
            }
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void category_addBtn_Click(object sender, EventArgs e)
        {

        }

        private void categoriesForm1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void addCategory_btn_Click(object sender, EventArgs e)
        {
            dashboardUserForm1.Visible = false;
            categoriesForm1.Visible = true;
            incomeForm1.Visible = false;
            expenseForm1.Visible = false;

            CategoriesForm c1 = categoriesForm1 as CategoriesForm;

            if (c1 != null)
            {
                c1.refreshData();
            }
        }


        private void incomeForm1_Load(object sender, EventArgs e)
        {

        }

        private void expenseForm1_Load(object sender, EventArgs e)
        {

        }

        private void income_btn_Click(object sender, EventArgs e)
        {
            dashboardUserForm1.Visible = false;
            categoriesForm1.Visible = false;
            incomeForm1.Visible = true;
            expenseForm1.Visible = false;

            IncomeForm iForm= incomeForm1 as IncomeForm;
            if (iForm != null)
            {
                iForm.refreshData();
            }

        }

        private void expense_btn_Click(object sender, EventArgs e)
        {
            dashboardUserForm1.Visible = false;
            categoriesForm1.Visible = false;
            incomeForm1.Visible = false;
            expenseForm1.Visible = true;
            ExpenseForm c1 = expenseForm1 as ExpenseForm;
            if (c1 != null)
            {
                c1.refreshData();
            }
        }
        public void displayUsernames()
        {
            string getUsername = Form1.username;
            greetUser.Text = "Welcome,"+ getUsername.Substring(0,1).ToUpper()+getUsername.Substring(1);
        }
            
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dashboardUserForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
