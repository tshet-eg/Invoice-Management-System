using InvoiceManagementSystem.Database;

namespace InvoiceManagementSystem.Validations
{
    public class Category
    {
        public static bool CheckAvailability(string categoryId)
        {
            foreach (Models.Category category in EntityCollection.CategoryList)
            {
                if (category.CategoryID == categoryId)
                    return true;
            }
            return false;
        }
    }
}
