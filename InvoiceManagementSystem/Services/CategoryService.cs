using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Models;
using System.Collections.Generic;

namespace InvoiceManagementSystem.Services
{
    public class CategoryService
    {
        private readonly ICategory _category;

        //Constructor injection
        public CategoryService(ICategory category)
        {
            _category = category;
        }
        public string AddCategory(Category category)
        {
            string categoryID = _category.AddCategory(category);
            return categoryID;
        }
        public void EditCategory(string categoryId, string name, string description, float tax)
        {
            _category.EditCategory(categoryId, name, description, tax);
        }
        public List<Category> DisplayCategory()
        {
            List<Category> list = _category.DisplayCategory();
            return list;

        }
        public bool DeleteCategory(string categoryId)
        {
            bool isPresent = Validations.CategoryValidation.CheckAvailability(categoryId);
            if (isPresent)
            {
                _category.DeleteCategory(categoryId);
            }
            return isPresent;
        }

        public Category GetCategory(string categoryId)
        {
            Category categoryFound = _category.GetCategory(categoryId);
            return categoryFound;
        }
    }
}
