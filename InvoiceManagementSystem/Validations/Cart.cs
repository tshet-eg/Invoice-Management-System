using InvoiceManagementSystem.Database;

namespace InvoiceManagementSystem.Validations
{
    public class Cart
    {
        public static bool VerifyCartId(string cartId)
        {
            foreach (Models.Cart cartItem in EntityCollection.Cart)
                if (cartItem.CartID == cartId)
                    return true;
            return false;
        }
    }
}
