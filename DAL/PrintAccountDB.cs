﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PrintAccountDB:IPrintAccountDB
    {
        string ConnectionString { get; }

        public PrintAccountDB()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        }
        public bool AddChfByUsername(string username, decimal amount)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConnectionString))
                {
                    string query = @"UPDATE PrintAccount 
                                       SET Amount = Amount + @AmountToAdd
                                       FROM PrintAccount
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


        public decimal GetChfByUsername(string username)
        {
            decimal amount = -1;
            try
            {
                using (SqlConnection cn = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT Amount FROM PrintAccount WHERE Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("Username", username);

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            if (dr["Amount"] != DBNull.Value)
                                amount = (decimal)dr["Amount"];
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

