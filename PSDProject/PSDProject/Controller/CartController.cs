using PSDProject.Handler;
using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Controller
{
    public class CartController
    {

        public static void clearAllUserCart(int id)
        {
            CartHandler.clearAllUserCart(id);
        }

        public static void addMakeupToCart(int id, int makeupId, int quantity)
        {
            CartHandler.addMakeupToCart(id, makeupId, quantity);
        }
        public static List<Cart> getAllCartsByUserId(int id)
        {
            return CartHandler.getAllCartsByUserId(id);
        }

        public static string validateOrder(int quantity, string makeupSelected)
        {
            if(quantity == 0)
            {
                return "Quantity must be more than 0";
            }
            if(makeupSelected == "")
            {
                return "Must select a makeup";
            }
            return null;
        }
    }
}