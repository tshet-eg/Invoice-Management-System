using System.Collections.Generic;
using InvoiceManagementSystem.Models;
namespace InvoiceManagementSystem.Interfaces
{
    //methods of entire cart
    public interface ICartOperations
    {
        List<Models.Cart> DisplayAllCartItems();
    }



    //methods of individual customer
    public interface ICart : ICartOperations
    {
        void AddtoCart(string customerId, string productId, int quantity);
        void EditCartItem(string cartId, int newQuantity);
        void DeleteCartItem(string cartId);
        void ClearCartItemsOfUser(string customerId);
        List<Cart> DisplayCartItemsOfUser(string customerId);
    }
}
