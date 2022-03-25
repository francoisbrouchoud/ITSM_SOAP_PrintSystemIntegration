using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PrintPaymentSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PrintPaymentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PrintPaymentService.svc or PrintPaymentService.svc.cs at the Solution Explorer and start debugging.
    public class PrintPaymentService : IPrintPaymentService
    {
        public void AddChfByUid(int uid, double chf)
        {
            throw new NotImplementedException();
        }

        public void AddChfByUsername(string username, double chf)
        {
            throw new NotImplementedException();
        }

        public double GetChfByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public double GetQuantityByUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}
