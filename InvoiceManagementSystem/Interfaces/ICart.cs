using System.Collections.Generic;

namespace InvoiceManagementSystem.Interfaces
{
    public interface ICart
    {
        void AddtoCart(string customerId,string productId,int quantity);
        void ClearCartItemsOfUser(string customerId);

        List<Models.Cart> DisplayCartItemsOfUser(string customerId);
        List<Models.Cart> DisplayAllCartItems();
    }
}
