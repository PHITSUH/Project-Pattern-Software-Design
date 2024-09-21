using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public class TransactionDetailRepository
    {
        public static void addTransactionDetail(TransactionDetail td)
        {
            DBSingleton.getInstance().TransactionDetails.Add(td);
            DBSingleton.getInstance().SaveChanges();
        }

        public static List<TransactionDetail> getAllTransactionDetails()
        {
            return DBSingleton.getInstance().TransactionDetails.ToList();
        }

        public static List<TransactionDetail> getSelectedTransactionDetail(int id)
        {
            List<TransactionDetail> td = getAllTransactionDetails();
            List<TransactionDetail> returnTd = new List<TransactionDetail>();
            foreach(TransactionDetail t in td) {
                if(t.TransactionID == id) returnTd.Add(t);
            }

            return returnTd;
        }
    }
}