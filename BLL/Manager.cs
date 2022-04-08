using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Manager : IManager
    {
        private const double rate = 0.08;
        ISapDB SapDb { get; }
        IPrintAccountDB PrintAccountDb { get; }
        public Manager(ISapDB sapDb, IPrintAccountDB printAccountDb)
        {
            SapDb = sapDb;
            PrintAccountDb = printAccountDb;
        }
        private double ConvertChfToQuantity(double amoutChf)
        {
            return amoutChf / rate;
        }

        public void AddChfByUsername(string username, double amountChf)
        {

            PrintAccountDb.AddChfByUsername(username, amountChf);
        }

        public void AddChfByCardId(int cardId, double amountChf)
        {
            string username = SapDb.GetUsernameByCardId(cardId);
            PrintAccountDb.AddChfByUsername(username, amountChf);
        }

        public double GetQuantityByUsername(string username)
        {
            double amount = PrintAccountDb.GetChfByUsername(username);
            return ConvertChfToQuantity(amount);
        }

        public double GetChfbyUsername(string username)
        {
            return PrintAccountDb.GetChfByUsername(username);
        }


    }
}
