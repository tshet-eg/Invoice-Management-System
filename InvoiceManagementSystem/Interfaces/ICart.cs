using System.Collections.Generic;

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
        string AddtoCart(string customerId, string productId, int quantity);
        void EditCartItem(string cartId, int newQuantity);
        void DeleteCartItem(string cartId);
        void ClearCartItemsOfUser(string customerId);
        List<Models.Cart> DisplayCartItemsOfUser(string customerId);
    }
}
