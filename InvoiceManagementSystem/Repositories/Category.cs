using InvoiceManagementSystem.Database;
using InvoiceManagementSystem.Interfaces;
using System.Collections.Generic;

namespace InvoiceManagementSystem.Repositories
{
    public class Category : ICategory
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
           List<string> productIdList = new List<string>();
           Product productRepository = new Product();
            foreach (Models.Category category in DBEntity.CategoryList)
            {
                if (category.CategoryID == categoryId) 
                {
                   foreach(Models.Product product in DBEntity.ProductList)
                   {
                       if(product.CategoryID == categoryId)
                       {
                           productIdList.Add(product.ProductID);
                       }
                   }
                    DBEntity.CategoryList.Remove(category);
                    break;
                }
            }
            foreach(string productID in productIdList)
            {
                productRepository.DeleteProducts(productID);
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
    }
}
