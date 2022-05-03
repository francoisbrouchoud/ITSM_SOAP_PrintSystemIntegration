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
        private const decimal PRINT_PRICE_CHF = 0.08m;
        ISapDB SapDb { get; }
        IPrintAccountDB PrintAccountDb { get; }
        public Manager(ISapDB sapDb, IPrintAccountDB printAccountDb)
        {
            SapDb = sapDb;
            PrintAccountDb = printAccountDb;
        }

        /// <summary>
        /// Calcul permettant de convertir le montant en CHF en quantité d'impressions
        /// </summary>
        /// <param name="amoutChf"></param>
        /// <returns></returns>
        private decimal ConvertChfToQuantity(decimal amoutChf)
        {
            return amoutChf / PRINT_PRICE_CHF;
        }

        /// <summary>
        /// Ajoute un motant en CHF à partir d'un username
        /// </summary>
        /// <param name="username"></param>
        /// <param name="amountChf"></param>
        /// <returns></returns>
        public void AddChfByUsername(string username, decimal amountChf)
        {
            PrintAccountDb.AddChfByUsername(username, amountChf);
        }

        /// <summary>
        /// Ajoute un motant en CHF à partir du cardId
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="amountChf"></param>
        /// <returns></returns>
        public void AddChfByCardId(int cardId, decimal amountChf)
        {
            string username = SapDb.GetUsernameByCardId(cardId);
            PrintAccountDb.AddChfByUsername(username, amountChf);
        }

        /// <summary>
        /// Obtenir la quantité d'impressions disponible sur le compte à partir d'un username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public decimal GetQuantityByUsername(string username)
        {
            decimal amount = PrintAccountDb.GetChfByUsername(username);
            return ConvertChfToQuantity(amount);
        }

        /// <summary>
        /// Obtenir le montant en CHF sur le compte à partir d'un username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public decimal GetChfbyUsername(string username)
        {
            return PrintAccountDb.GetChfByUsername(username);
        }


    }
}
