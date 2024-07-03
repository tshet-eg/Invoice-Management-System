
using InvoiceManagementSystem.Database;

namespace InvoiceManagementSystem.Validations
{
    public class ProductValidation
    {
        //Product ID Validition 
        public static bool ProductIdValidation(string productID)
        {
            foreach (var item in EntityCollection.ProductList)
            {
                //Comparing product ID of recieved one and already existing ones 
                if (item.ProductID == productID)
                {
                    return true;
                }
            }
            return false;
            
        }
    }
}
