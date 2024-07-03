using InvoiceManagementSystem.Database;
using InvoiceManagementSystem.Models;

namespace InvoiceManagementSystem.Validations
{
    public class CategoryValidation
    {
        public static bool CheckAvailability(string categoryId)
        {
            foreach (Category category in EntityCollection.CategoryList)
            {
                if (category.CategoryID == categoryId)
                    return true;
            }
            return false;
        }
    }
}
