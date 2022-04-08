using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class PrintAccountDB : IPrintAccountDB
    {
        string ConnectionString { get; }

        public PrintAccountDB()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        }
        public bool AddChfByUsername(string username, double amount)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConnectionString))
                {
                    string query = @"UPDATE PrintAccount 
                                       SET Amount = Amount + @AmountToAdd;
                                       WHERE Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("Username", username);
                    cmd.Parameters.AddWithValue("AmountToAdd", amount);

                    cn.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public double GetChfByUsername(string username)
        {
            double amount = -1.0;
            try
            {
                using (SqlConnection cn = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT Amount FROM Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("Username", username);

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            if (dr["Amount"] != DBNull.Value)
                                amount = (double)dr["Amount"];
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return amount;
        }
    }
}
