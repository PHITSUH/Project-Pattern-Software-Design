using PSDProject.Factory;
using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace PSDProject.Handler
{
    public class CartHandler
    {

        public static void clearAllUserCart(int id)
        {
            CartRepository.clearAllUserCart(id);
        }

        public static List<Cart> getAllCartsByUserId(int id)
        {
            return CartRepository.getAllCartsByUserId(id);
        }

        public static int generateId()
        {
            if (CartRepository.getAllCarts().LastOrDefault() == null)
            {
                return 1;
            }

            return CartRepository.getAllCarts().LastOrDefault().CartID + 1;
        }

        public static void addMakeupToCart(int userId, int makeupId, int quantity)
        {
            Cart c = CartRepository.getCartByIds(userId, makeupId);
            if (c != null)
            {
                CartRepository.updateCart(userId, makeupId, c.CartID, c.Quantity + quantity);
                return;
            }
            addCart(userId, makeupId, quantity);
        }
        public static void addCart(int userId, int makeupId, int quantity)
        {
            int id = generateId();
            Cart cart = CartFactory.createCart(id, userId, makeupId, quantity);
            CartRepository.addCart(cart);
        }
    }
}