using PSDProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Repository
{
    public class CartRepository
    {

        public static List<Cart> getAllCarts()
        {
            return DBSingleton.getInstance().Carts.ToList();
        }

        public static List<Cart> getAllCartsByUserId(int id)
        {
            List<Cart> allCart = DBSingleton.getInstance().Carts.ToList();
            List<Cart> returnCart = new List<Cart>();
            foreach(Cart cart in allCart)
            {
                if (cart.UserID == id)
                {
                    returnCart.Add(cart);
                }
            }

            return returnCart;
        }

        public static void addCart(Cart cart)
        {
            DBSingleton.getInstance().Carts.Add(cart);
            DBSingleton.getInstance().SaveChanges();
        }

        public static void clearAllUserCart(int userId)
        {
            List<Cart> carts = DBSingleton.getInstance().Carts.ToList();
            foreach(Cart c in carts)
            {
                if(userId == c.UserID)
                {
                    DBSingleton.getInstance().Carts.Remove(c);
                }
            }
            DBSingleton.getInstance().SaveChanges();
        }

        public static Cart getCartByIds(int userId, int makeupId)
        {
            List<Cart> carts = getAllCarts();
            foreach (Cart c in carts)
            {
                if (userId == c.UserID && makeupId == c.MakeupID)
                {
                    return c;
                }
            }
            return null;
        }

        public static Cart getCartById(int cartId)
        {
            return DBSingleton.getInstance().Carts.Find(cartId);
        }

        public static void updateCart(int userId, int makeupId, int cartId, int quantity)
        {
            Cart c = getCartById(cartId);
            c.UserID = userId;
            c.MakeupID = makeupId;
            c.Quantity = quantity;
            DBSingleton.getInstance().SaveChanges();
        }
    }
}