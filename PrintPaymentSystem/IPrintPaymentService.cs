using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PrintPaymentSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPrintPaymentService" in both code and config file together.
    [ServiceContract]
    public interface IPrintPaymentService
    {
        [OperationContract]
        void AddChfByCardId(int cardId, decimal chf);
        [OperationContract]
        void AddChfByUsername(string username, decimal chf);
        [OperationContract]
        decimal GetQuantityByUsername(string username);
        [OperationContract]
        decimal GetChfByUsername(string username);
        

    }
}
