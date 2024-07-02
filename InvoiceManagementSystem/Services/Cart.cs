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

        public string AddtoCart(string customerId, string productId, int quantity)
        {
           return _cart.AddtoCart(customerId, productId, quantity);
        }

        public void ClearCartItemsOfUser(string customerId)
        {
            _cart.ClearCartItemsOfUser(customerId);
        }

        public List<Models.Cart> DisplayCartItemsOfUser(string customerId)
        {
            return _cart.DisplayCartItemsOfUser(customerId);
        }

        public List<Models.Cart> DisplayAllCartData()
        {
            return _cart.DisplayAllCartItems();
        }

        public void EditCartItem(string cartId, int newQuantity)
        {
            _cart.EditCartItem(cartId, newQuantity);
        }

        public void DeleteCartItem(string cartId)
        {
            _cart.DeleteCartItem(cartId);
        }
    }
}
