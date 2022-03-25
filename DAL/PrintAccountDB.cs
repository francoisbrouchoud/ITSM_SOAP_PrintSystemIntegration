using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class PrintAccountDB
    {
        string ConnectionString { get; }

        public PrintAccountDB()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        }
        public void AddChfByUsername(string username, double amount)
        {

        }

        public double GetChfByUsername(string username)
        {
            return 0;
        }


    }
}
