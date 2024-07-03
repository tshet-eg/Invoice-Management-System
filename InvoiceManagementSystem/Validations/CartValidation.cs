using InvoiceManagementSystem.Database;
using InvoiceManagementSystem.Models;
namespace InvoiceManagementSystem.Validations
{
    public class CartValidation
    {
        public static bool VerifyCartId(string cartId)
        {
            foreach (Cart cartItem in EntityCollection.Cart)
                if (cartItem.CartID == cartId)
                    return true;
            return false;
        }
    }
}
