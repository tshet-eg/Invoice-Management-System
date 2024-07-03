using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Models;
using System.Collections.Generic;

namespace InvoiceManagementSystem.Services
{
    public class CartService
    {
        private  ICart _cart;
        public CartService(ICart cart)
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

        public List<Cart> DisplayCartItemsOfUser(string customerId)
        {
            return _cart.DisplayCartItemsOfUser(customerId);
        }

        public List<Cart> DisplayAllCartData()
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
