using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace IncomeExpense
{
    internal class ExpensesData
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\expenses.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public int ID { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public string Cost { get; set; }
        public string Description { get; set; }
        public string DateExpense { get; set; }

        public List<ExpensesData> expensesListData(int userId)
        {
            List<ExpensesData> listData = new List<ExpensesData>();

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT * FROM expenses WHERE user_id = @userId";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ExpensesData eData = new ExpensesData();

                        eData.ID = (int)reader["id"];
                        eData.Category = reader["category"].ToString();
                        eData.Item = reader["item"].ToString();
                        eData.Cost = reader["cost"].ToString();
                        eData.Description = reader["description"].ToString();
                        eData.DateExpense = ((DateTime)reader["date_expense"]).ToString("MM-dd-yyyy");

                        listData.Add(eData);
                    }
                }
            }

            return listData;
        }
    }
}
