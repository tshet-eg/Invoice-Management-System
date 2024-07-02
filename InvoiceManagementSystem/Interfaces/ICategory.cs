using System.Collections.Generic;

namespace InvoiceManagementSystem.Interfaces
{
    public interface ICategory
    {
        void AddCategory(Models.Category category);
        void EditCategory(string categoryId, string name, string description, float tax);
        void DeleteCategory(string categoryId);
        List<Models.Category> DisplayCategory();
        Models.Category GetCategory(string categoryId);

    }
}
