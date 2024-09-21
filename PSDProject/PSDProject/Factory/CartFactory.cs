using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PSDProject.Factory
{
    public class CartFactory
    {
        

        public static Cart createCart(int cartId, int userId, int makeupId, int quantity)
        {
            Cart cart = new Cart();
            cart.UserID = userId;
            cart.CartID = cartId;
            cart.MakeupID = makeupId;
            cart.Quantity = quantity;
            return cart;
        }
    }
}