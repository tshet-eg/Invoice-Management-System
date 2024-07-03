using InvoiceManagementSystem.Models;
using System.Collections.Generic;

namespace InvoiceManagementSystem.Interfaces
{
    public interface ICategory
    {
        string AddCategory(Category category);
        void EditCategory(string categoryId, string name, string description, float tax);
        void DeleteCategory(string categoryId);
        List<Category> DisplayCategory();
        Category GetCategory(string categoryId);

    }
}
