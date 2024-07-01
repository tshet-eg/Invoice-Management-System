using InvoiceManagementSystem.Interfaces;
using System.Collections.Generic;

namespace InvoiceManagementSystem.Services
{
    public class Cart
    {
        private ICart _cart;
        public Cart(ICart cart)
        {
            _cart = cart;
        }
        public void AddtoCart(string customerId, string productId, int quantity)
        {
            _cart.AddtoCart(customerId, productId, quantity);
        }
        public void ClearCartItemsOfUser(string customerId)
        {
            _cart.ClearCartItemsOfUser(customerId);
        }
        public List<Models.Cart> DisplayCartItemsOfUser(string customerId)
        {
            return _cart.DisplayCartItemsOfUser(customerId);
        } public List<Models.Cart> DisplayAllCartData()
        {
            return _cart.DisplayAllCartItems();
        }
    }
}
