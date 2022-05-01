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


        private const decimal rate = 0.08m;
        ISapDB SapDb { get; }
        IPrintAccountDB PrintAccountDb { get; }
        public Manager(ISapDB sapDb, IPrintAccountDB printAccountDb)
        {
            SapDb = sapDb;
            PrintAccountDb = printAccountDb;
        }

        /// <summary>
        /// Calcule permetant de convertir les CHF en quantité
        /// </summary>
        /// <param name="amoutChf"></param>
        /// <returns></returns>
        private decimal ConvertChfToQuantity(decimal amoutChf)
        {
            return amoutChf / rate;
        }

        public void AddChfByUsername(string username, decimal amountChf)
        {
            PrintAccountDb.AddChfByUsername(username, amountChf);
        }

        public void AddChfByCardId(int cardId, decimal amountChf)
        {
            string username = SapDb.GetUsernameByCardId(cardId);
            PrintAccountDb.AddChfByUsername(username, amountChf);
        }

        public decimal GetQuantityByUsername(string username)
        {
            decimal amount = PrintAccountDb.GetChfByUsername(username);
            return ConvertChfToQuantity(amount);
        }

        public decimal GetChfbyUsername(string username)
        {
            return PrintAccountDb.GetChfByUsername(username);
        }


    }
}
