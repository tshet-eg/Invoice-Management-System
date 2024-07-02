using InvoiceManagementSystem.Database;
using InvoiceManagementSystem.Interfaces;
using System;
using System.Collections.Generic;

namespace InvoiceManagementSystem.Repositories
{
    public class CategoryRepository : ICategory
    {
        public void AddCategory(Models.Category category)
        {
            DBEntity.CategoryList.Add(category);
        }
        public void EditCategory(string categoryId, string name, string description, float tax)
        {
            foreach (Models.Category category in DBEntity.CategoryList)
            {
                if (category.CategoryID == categoryId)
                {
                    category.Name = name;
                    category.Description = description;
                    category.Tax = tax;
                    break;
                }
            }
        }
        public void DeleteCategory(string categoryId)
        {
           // ProductRepository productRepository = new ProductRepository();
            foreach (Models.Category category in DBEntity.CategoryList)
            {
                if (category.CategoryID == categoryId) 
                {
                   // foreach(Models.Product product in DBEntity.ProductList)
                    //{
                     //   if(product.categoryID == categoryId)
                        //{
                           // productRepository.DeleteProducts(product.productId);
                       // }
                   // }
                    DBEntity.CategoryList.Remove(category);
                    break;
                }
            }
        }
        public List<Models.Category> DisplayCategory()
        {
            return DBEntity.CategoryList;
        }

        public Models.Category GetCategory(string categoryId)
        {
            Models.Category categoryFound = null;
            foreach (Models.Category category in DBEntity.CategoryList)
            {
                if (category.CategoryID == categoryId)
                {
                    categoryFound = category;
                }
            }
            return categoryFound;
        }

        public bool CheckAvailability(string categoryId)
        {
            foreach (Models.Category category in DBEntity.CategoryList)
            {
                if (category.CategoryID == categoryId)
                    return true;
            }
            return false;
        }
    }
}
