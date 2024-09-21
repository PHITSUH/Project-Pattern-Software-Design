using PSDProject.Factory;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Handler
{
    public class TransactionHandler
    {
        public static int generateId()
        {
            if(TransactionHeaderRepository.getAllTransactionHeaders().LastOrDefault() == null)
            {
                return 1;
            }
            return TransactionHeaderRepository.getAllTransactionHeaders().LastOrDefault().TransactionID + 1;
        }
        public static void makeOrder(int userId)
        {
            int transactionId = generateId();
            TransactionHeader th = TransactionHeaderFactory.createTransactionHeader(transactionId, userId, DateTime.Now, "Unhandled");
            TransactionHeaderRepository.addTransactionHeader(th);
            List<Cart> carts = CartRepository.getAllCartsByUserId(userId);
            foreach(Cart c in carts)
            {
                TransactionDetail td = TransactionDetailFactory.createTransactionDetail(transactionId, c.MakeupID, c.Quantity);
                TransactionDetailRepository.addTransactionDetail(td);
            }
            CartRepository.clearAllUserCart(userId);
        }

        public static List<TransactionHeader> getAllHandledTransactions()
        {
            List<TransactionHeader> th = TransactionHeaderRepository.getAllTransactionHeaders();
            List<TransactionHeader> returnTh = new List<TransactionHeader>();
            foreach(TransactionHeader t  in th)
            {
                if (t.Status.Equals("Handled"))
                {
                    returnTh.Add(t);
                }
            }
            return returnTh;
        }

        public static List<TransactionHeader> getAllUnhandledTransactions()
        {
            List<TransactionHeader> th = TransactionHeaderRepository.getAllTransactionHeaders();
            List<TransactionHeader> returnTh = new List<TransactionHeader>();
            foreach (TransactionHeader t in th)
            {
                if (t.Status.Equals("Unhandled"))
                {
                    returnTh.Add(t);
                }
            }
            return returnTh;
        }

        public static void handleTransaction(int id)
        {
            TransactionHeaderRepository.handleTransaction(id);
        }

        public static List<TransactionHeader> getAllTransactionHeaders()
        {
            return TransactionHeaderRepository.getAllTransactionHeaders();
        }

        public static List<TransactionHeader> getCustomerTransactionHeaders(int id)
        {
            return TransactionHeaderRepository.getCustomerTransactionHeaders(id);
        }

        public static List<TransactionDetail> getSelectedTransactionDetail(int id)
        {
            return TransactionDetailRepository.getSelectedTransactionDetail(id);
        }
    }
}