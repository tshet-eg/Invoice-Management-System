using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Models;
using InvoiceManagementSystem.Repositories;
using System.Collections.Generic;

namespace InvoiceManagementSystem.Services
{
    public class CategoryService
    {
        private readonly ICategory _category;

        readonly CategoryRepository categoryRepository = new CategoryRepository();
        public CategoryService(ICategory category)
        {
            _category = category;
        }
        public void AddCategory(Category category)
        {
            _category.AddCategory(category);
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
           bool isPresent = categoryRepository.CheckAvailability(categoryId);
            if (isPresent)
            {
                _category.DeleteCategory(categoryId);
            }
           return isPresent;
        }

        public Category GetCategory(string categoryId)
        {
            Category categoryFound = categoryRepository.GetCategory(categoryId);
            return categoryFound;
        }
    }
}
