using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SapDB:ISapDB
    {
        string ConnectionString { get; }
        public SapDB()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        }
		/// <summary>
		/// Permet de connaitre la correspondance d'une card id pour un username
		/// </summary>
		/// <param name="cardId"></param>
		/// <returns></returns>
        public string GetUsernameByCardId(int cardId)
        {
			string result = null;

			try
			{
				using (SqlConnection cn = new SqlConnection(ConnectionString))
				{
					string query = @"SELECT Username FROM SAP
							WHERE CardId = @cardId";
					SqlCommand cmd = new SqlCommand(query, cn);
					cmd.Parameters.AddWithValue("@cardId", cardId);
					cn.Open();

					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						if (dr.Read())
						{
							result = dr["Username"].ToString();

						}
					}
				}
			}
			catch (Exception e)
			{
				throw e;
			}

			return result;
		}
    }
}
