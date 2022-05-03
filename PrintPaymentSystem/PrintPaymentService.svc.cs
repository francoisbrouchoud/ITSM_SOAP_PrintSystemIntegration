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
    public class PrintPaymentService : IPrintPaymentService
    {
        private IManager manager;
        public PrintPaymentService()
        {
            ISapDB sapDB = new SapDB();
            IPrintAccountDB printAccountDB = new PrintAccountDB();
            manager = new Manager(sapDB, printAccountDB);
        }

        /// <summary>
        /// Permet d'ajouter un montant en CHF à partir du cardId
        /// </summary>
        /// <param name="cardId">le numéro de la carte</param>
        /// <param name="chf">le montant en CHF à ajouter</param>
        public void AddChfByCardId(int cardId, decimal chf)
        {
            manager.AddChfByCardId(cardId, chf);
        }

        /// <summary>
        /// Permet d'ajouter un montant en CHF à partir d'un utilisateur
        /// </summary>
        /// <param name="username">le nom de l'utilisateur</param>
        /// <param name="chf">le montant en CHF à ajouter</param>
        public void AddChfByUsername(string username, decimal chf)
        {
            manager.AddChfByUsername(username, chf);
        }

        /// <summary>
        /// Permet de connaître le montant en CHF du compte à partir d'un utilisateur
        /// </summary>
        /// <param name="username">le nom de l'utilisateur</param>
        /// <returns>Le montant en CHF disponible sur le compte. Si le montant est négatif, cela signifie que le compte n'a pas été trouvé.</returns>
        public decimal GetChfByUsername(string username)
        {
            return manager.GetChfbyUsername(username);
        }

        /// <summary>
        /// Permet de connaître le nombre d'impressions disponnibles pour le compte à partir d'un utilisateur
        /// </summary>
        /// <param name="username">le nom de l'utilisateur</param>
        /// <returns>Le nombre d'impressions disponible sur le compte. Si le nombre est négatif, cela signifie que le compte n'a pas été trouvé.</returns>
        public decimal GetQuantityByUsername(string username)
        {
            return manager.GetQuantityByUsername(username);
        }

        
    }
}
