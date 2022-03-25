using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class SapDB
    {
        string ConnectionString { get; }
        public SapDB()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        }
        public string getUsernameByUid(int uid)
        {
            return null;
        }
    }
}
