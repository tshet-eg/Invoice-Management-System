using InvoiceManagementSystem.Database;
using InvoiceManagementSystem.Interfaces;
using System.Collections.Generic;
namespace InvoiceManagementSystem.Repositories
{
    public class Cart : ICart
    {
        public void AddtoCart(string customerId, string productId, int quantity)
        {
            foreach (Models.ProductsModel product in DBEntity.ProductList)
            {
                if (product.ProductID == productId)
                {
                    Models.Cart newCartItem = new Models.Cart(customerId, product, quantity);
                    DBEntity.Cart.Add(newCartItem);
                }
            }
        }

        public void ClearCartItemsOfUser(string customerId)
        {
            DBEntity.Cart.RemoveAll(x => x.CustomerID == customerId);
        }

        public List<Models.Cart> DisplayCartItemsOfUser(string customerId)
        {
            List<Models.Cart> cartItemList = new List<Models.Cart>();
            foreach (Models.Cart cartItem in DBEntity.Cart)
            {
                if (cartItem.CustomerID == customerId)
                {
                    cartItemList.Add(cartItem);
                }
            }
            return cartItemList;
        }

        public List<Models.Cart> DisplayAllCartItems()
        {
            return DBEntity.Cart;
        }




    }
}
