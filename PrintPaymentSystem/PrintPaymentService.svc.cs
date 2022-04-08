using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTO;
using DAL;
using BLL;
namespace PrintPaymentSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PrintPaymentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PrintPaymentService.svc or PrintPaymentService.svc.cs at the Solution Explorer and start debugging.
    public class PrintPaymentService : IPrintPaymentService
    {
        private IManager manager;
        public PrintPaymentService()
        {
            ISapDB sapDB = new SapDB();
            IPrintAccountDB printAccountDB = new PrintAccountDB();
            manager = new Manager(sapDB, printAccountDB);
        }

        public void AddChfByCardId(int cardId, decimal chf)
        {
            manager.AddChfByCardId(cardId, chf);
        }

        public void AddChfByUsername(string username, decimal chf)
        {
            manager.AddChfByUsername(username, chf);
        }

        public decimal GetChfByUsername(string username)
        {
            return manager.GetChfbyUsername(username);
        }

        public decimal GetQuantityByUsername(string username)
        {
            return manager.GetQuantityByUsername(username);
        }

        
    }
}
