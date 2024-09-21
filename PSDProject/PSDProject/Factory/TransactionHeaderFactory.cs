using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Factory
{
    public class TransactionHeaderFactory
    {

        public static TransactionHeader createTransactionHeader(int transactionId, int userId, DateTime transactionDate, string status)
        {
            TransactionHeader th = new TransactionHeader();
            th.TransactionID = transactionId;
            th.UserID = userId;
            th.TransactionDate = transactionDate;
            th.Status = status;
            return th;
        }
    }
}