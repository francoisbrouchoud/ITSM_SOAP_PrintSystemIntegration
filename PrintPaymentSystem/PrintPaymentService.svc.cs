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
        /// Permet d'ajouter des sous à partir de la carte id
        /// </summary>
        /// <param name="cardId">le numero de carte</param>
        /// <param name="chf">le montant à ajouter</param>
        public void AddChfByCardId(int cardId, decimal chf)
        {
            manager.AddChfByCardId(cardId, chf);
        }

        /// <summary>
        /// Permet d'ajouter des sous à partir de l'utilisateur
        /// </summary>
        /// <param name="username">le nom de l'utilisateur</param>
        /// <param name="chf">le montant à ajouter</param>
        public void AddChfByUsername(string username, decimal chf)
        {
            manager.AddChfByUsername(username, chf);
        }

        /// <summary>
        /// Permet de connaître le montant du compte 
        /// </summary>
        /// <param name="username">le nom de l'utilisateur</param>
        /// <returns>le nombre d'argent qu'il y a sur le compte. Si c'est un nombre négatif ça veut dire que nous n'avons pas trouver le compte.</returns>
        public decimal GetChfByUsername(string username)
        {
            return manager.GetChfbyUsername(username);
        }

        /// <summary>
        /// Permet de connaître le nombre d'impression disponnible pour le compte
        /// </summary>
        /// <param name="username">le nom de l'utilisateur</param>
        /// <returns>le nombre de photocopie disponnible sur le compte. Si c'est un nombre négatif ça veut dire que nous n'avons pas trouver le compte.</returns>
        public decimal GetQuantityByUsername(string username)
        {
            return manager.GetQuantityByUsername(username);
        }

        
    }
}
