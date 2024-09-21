using PSDProject.Handler;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Controller
{
    public class TransactionController
    {

        public static List<TransactionHeader> getCustomerTransactionHeaders(int id)
        {
            return TransactionHandler.getCustomerTransactionHeaders(id);
        }

        public static List<TransactionHeader> getAllTransactionHeaders()
        {
            return TransactionHandler.getAllTransactionHeaders();
        }


        public static List<TransactionDetail> getSelectedTransactionDetail(int id)
        {
            return TransactionHandler.getSelectedTransactionDetail(id);
        }

        public static void handleTransaction(int id)
        {
            TransactionHandler.handleTransaction(id);
        }

        public static void makeOrder(int id)
        {
            TransactionHandler.makeOrder(id);
        }

        public static List<TransactionHeader> getAllHandledTransactions()
        {
            return TransactionHandler.getAllHandledTransactions();
        }

        public static List<TransactionHeader> getAllUnhandledTransactions()
        {
            return TransactionHandler.getAllUnhandledTransactions();
        }
    }
}