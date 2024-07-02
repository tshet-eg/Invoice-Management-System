using InvoiceManagementSystem.Interfaces;
using System.Collections.Generic;

namespace InvoiceManagementSystem.Services
{
    public class CategoryService
    {
        private readonly ICategory _category;

        readonly Repositories.CategoryRepository categoryRepository = new Repositories.CategoryRepository();
        public CategoryService(ICategory category)
        {
            _category = category;
        }
        public void AddCategory(Models.Category category)
        {
            _category.AddCategory(category);
        }
        public void EditCategory(string categoryId, string name, string description, float tax)
        {
            _category.EditCategory(categoryId, name, description, tax);
        }
        public List<Models.Category> DisplayCategory()
        {
            List<Models.Category> list = _category.DisplayCategory();
            return list;

        }
        public bool DeleteCategory(string categoryId)
        {
           bool isPresent = Validations.Category.CheckAvailability(categoryId);
            if (isPresent)
            {
                _category.DeleteCategory(categoryId);
            }
           return isPresent;
        }

        public Models.Category GetCategory(string categoryId)
        {
            Models.Category categoryFound = _category.GetCategory(categoryId);
            return categoryFound;
        }
    }
}
