using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public class TransactionHeaderRepository
    {

        public static List<TransactionHeader> getAllTransactionHeaders()
        {
            return DBSingleton.getInstance().TransactionHeaders.ToList();
        }

        public static void addTransactionHeader(TransactionHeader th)
        {
            DBSingleton.getInstance().TransactionHeaders.Add(th);
            DBSingleton.getInstance().SaveChanges();
        }

        public static List<TransactionHeader> getCustomerTransactionHeaders(int id)
        {
            List<TransactionHeader> th = getAllTransactionHeaders();
            List<TransactionHeader> returnTh = new List<TransactionHeader>();
            foreach(TransactionHeader t in th)
            {
                if(t.UserID == id)
                {
                    returnTh.Add(t);
                }
            }
            return returnTh;
        }

        public static TransactionHeader getTransactionHeaderById(int id)
        {
            List<TransactionHeader> th = getAllTransactionHeaders();
            foreach(TransactionHeader t in th)
            {
                if(t.TransactionID == id)
                {
                    return t;
                }
            }
            return null;
        }

        public static void handleTransaction(int id)
        {
            TransactionHeader th = getTransactionHeaderById(id);
            th.TransactionID = th.TransactionID;
            th.UserID = th.UserID;
            th.TransactionDate = th.TransactionDate; 
            th.Status = "Handled";
            DBSingleton.getInstance().SaveChanges();
        }
    }
}