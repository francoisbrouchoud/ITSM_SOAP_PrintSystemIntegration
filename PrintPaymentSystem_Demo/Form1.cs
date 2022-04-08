using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrintPaymentSystem_Demo.ServicePrintPayment;

namespace PrintPaymentSystem_Demo
{
    public partial class Form1 : Form
    {
        private PrintPaymentServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new PrintPaymentServiceClient();

        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            decimal amount = client.GetChfByUsername(account);
            decimal quantity = client.GetQuantityByUsername(account);
            if(amount < 0)
                MessageBox.Show($"{account} n'existe pas");
            else
                MessageBox.Show($"{account} possède CHF {amount} et peut imprimer {quantity} feuilles.");

        }

        private void btnAddAmount_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;

            decimal amount = Convert.ToDecimal(txtAmount.Text);
            int cardId;
            if(int.TryParse(account, out cardId))
            {
                client.AddChfByCardId(cardId, amount);
                MessageBox.Show($"Nous avons ajouté CHF {amount} au compte avec le numéro de carte suivante {cardId}.");
            }
            else
            {
                client.AddChfByUsername(account, amount);
                MessageBox.Show($"Nous avons ajouté CHF {amount} au compte avec le nom d'utilisateur suivant {account}.");
            }
        }
    }
}
