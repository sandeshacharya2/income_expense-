using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace IncomeExpense
{
    internal class IncomeData
    {
        // Connection string 
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer\Documents\expenses.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

                                                            //incoem properties
        public int ID { get; set; }
        public string Item { get; set; }         
        public string Category { get; set; }     
        public string Cost { get; set; }
        public string Description { get; set; }
        public string DateIncome { get; set; }

                                            //fetching the data from databse
        public List<IncomeData> incomeListData()
        {
            List<IncomeData> listData = new List<IncomeData>();

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                string selectData = "SELECT * FROM income WHERE user_id = @userId";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                   
                    cmd.Parameters.AddWithValue("@userId", Session.UserId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        IncomeData iData = new IncomeData();

                        iData.ID = (int)reader["id"];
                        iData.Category = reader["category"].ToString();
                        iData.Item = reader["item"].ToString();
                        iData.Cost = reader["income"].ToString();
                        iData.Description = reader["description"].ToString();
                        iData.DateIncome = ((DateTime)reader["date_income"]).ToString("MM-dd-yyyy");

                        listData.Add(iData);
                    }
                }
            }

            return listData;
        }

    }
}
