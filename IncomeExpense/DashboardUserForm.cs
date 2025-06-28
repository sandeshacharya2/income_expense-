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
using System.Data.SqlClient;

namespace IncomeExpense
{
    public partial class DashboardUserForm : UserControl
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\expenses.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public DashboardUserForm()
        {
            InitializeComponent();

            incomeTodayIncome();
            incomeYesterdayIncome();
            incomeThisMonth();
            incomeThisYear();
            incomeTotalIncome();

            expenseTodayExpanse();
            expenseYesterdayExpense();
            expenseThisMonth();
            expenseThisYear();
            expenseTotalExpense();
        }

        public void refreshData()               //refreshes data on any operations
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;

            }
            incomeTodayIncome();
            incomeYesterdayIncome();
            incomeThisMonth();
            incomeThisYear();
            incomeTotalIncome();

            expenseTodayExpanse();
            expenseYesterdayExpense();
            expenseThisMonth();
            expenseThisYear();
            expenseTotalExpense();
        }
        public void incomeTodayIncome()     // to show todays data
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string query = "SELECT SUM(income) FROM income WHERE date_income = @date_in AND user_id = @user_id";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_in", today);

                   
                    int userId = Session.UserId; // ensure the user is authenticated user 
                    cmd.Parameters.AddWithValue("@user_id", userId);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        decimal todayCost = Convert.ToDecimal(result);
                        income_totalIncome.Text = todayCost.ToString("C");  // formatting as currency 
                    }
                    else
                    {
                        income_totalIncome.Text = "$0.00";
                    }
                }
                connect.Close();
            }
        }



        public void incomeYesterdayIncome()     /// yesterday income 
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string query = "SELECT SUM(income) FROM income WHERE CONVERT(DATE, date_income) = DATEADD(day, -1, CAST(GETDATE() AS DATE)) AND user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                
                    cmd.Parameters.AddWithValue("@user_id", Session.UserId);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);
                        income_yesterdayIncome.Text = yesterdayCost.ToString("C");
                        
                    }
                    else
                    {
                        income_yesterdayIncome.Text = "$0.00";
                    }
                }

                connect.Close();
            }
        }


        public void incomeThisMonth()   // this month income 
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startMonth AND date_income <= @endMonth AND user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {                       
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);

                    
                    int userId = Session.UserId; 
                    cmd.Parameters.AddWithValue("@user_id", userId);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        decimal monthCost = Convert.ToDecimal(result);
                        income_thisMonthIncome.Text = monthCost.ToString("C");
                    }
                    else
                    {
                        income_thisMonthIncome.Text = "$0.00";
                    }
                }
                connect.Close();
            }
        }

        public void incomeThisYear()        // this month income
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);

                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startYear AND date_income <= @endYear AND user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);

                
                    cmd.Parameters.AddWithValue("@user_id", Session.UserId);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);
                        income_thisYearIncome.Text = yearCost.ToString("C");
                    }
                    else
                    {
                        income_thisYearIncome.Text = "$0.00";
                    }
                }

                connect.Close();
            }
        }


        public void incomeTotalIncome()     // all sum of income till now
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string query = "SELECT SUM(income) FROM income WHERE user_id = @user_id";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user_id", Session.UserId);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        decimal totalIncomes = Convert.ToDecimal(result);
                        totalIncome.Text = totalIncomes.ToString("C");
                    }
                    else
                    {
                        income_totalIncome.Text = "$0.00";
                    }
                }
                connect.Close();
            }
        }





        //Expenses
        public void expenseTodayExpanse()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                // connection open and retreiving expenses

                connect.Open();
                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense = @date_ex AND user_id = @user_id";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_ex", today);
                    cmd.Parameters.AddWithValue("@user_id", Session.UserId);  // authenticated user 
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        decimal todayCost = Convert.ToDecimal(result);
                        expense_today.Text = todayCost.ToString("C");
                    }
                    else
                    {
                        expense_today.Text = "$0.00";
                    }
                }
                connect.Close();
            }
        }



        public void expenseYesterdayExpense()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string query = "SELECT SUM(cost) FROM expenses WHERE CONVERT(DATE, date_expense) = DATEADD(day, -1, CAST(GETDATE() AS DATE)) AND user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user_id", Session.UserId);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);
                        expense_yesterday.Text = yesterdayCost.ToString("C");
                    }
                    else
                    {
                        expense_yesterday.Text = "$0.00";
                    }
                }

                connect.Close();
            }
        }



        public void expenseThisMonth()          // this month expenses
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startMonth AND date_expense <= @endMonth AND user_id = @user_id";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);
                    cmd.Parameters.AddWithValue("@user_id", Session.UserId);  

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        decimal monthCost = Convert.ToDecimal(result);
                        expense_thisMonth.Text = monthCost.ToString("C");
                    }
                    else
                    {
                        expense_thisMonth.Text = "$0.00";
                    }
                }

                connect.Close();
            }
        }

        public void expenseThisYear()           //this year expenses
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startYear AND date_expense <= @endYear AND user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);
                    cmd.Parameters.AddWithValue("@user_id", Session.UserId);  // Add user_id parameter

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        decimal yearCost = Convert.ToDecimal(result);
                        expense_thisYear.Text = yearCost.ToString("C");
                    }
                    else
                    {
                        expense_thisYear.Text = "$0.00";
                    }
                }
                connect.Close();
            }
        }


        public void expenseTotalExpense()           //total expenses
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string query = "SELECT SUM(cost) FROM expenses WHERE user_id = @user_id";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user_id", Session.UserId);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        decimal totalCost = Convert.ToDecimal(result);
                        totalExpense.Text = totalCost.ToString("C");
                    }
                    else
                    {
                        totalExpense.Text = "$0.00";
                    }
                }
                connect.Close();
            }
        }

        private void DashboardUserForm_Load(object sender, EventArgs e)
        {

        }

        private void expense_thisMonthExpense_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void totalIncome_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void income_totalIncome_Click(object sender, EventArgs e)
        {

        }
    }
}
