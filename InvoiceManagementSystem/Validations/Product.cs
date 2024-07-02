
using InvoiceManagementSystem.Database;

namespace InvoiceManagementSystem.Validations
{
    public class ProductValidation
    {
        public static bool ProductIdValidation(string productID)
        {
            foreach (var item in DBEntity.ProductList)
            {

                if (item.ProductID == productID)
                {
                    return true;
                }
            }
            return false;
            
        }
    }
}
