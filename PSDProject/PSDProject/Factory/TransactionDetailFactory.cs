using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Factory
{
    public class TransactionDetailFactory
    {

        public static TransactionDetail createTransactionDetail(int transactionId, int makeupId, int quantity)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionID = transactionId;
            td.MakeupID = makeupId;
            td.Quantity = quantity;
            return td;
        }
    }
}