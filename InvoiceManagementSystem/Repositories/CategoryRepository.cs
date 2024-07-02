using InvoiceManagementSystem.Database;
using InvoiceManagementSystem.Interfaces;
using System.Collections.Generic;

namespace InvoiceManagementSystem.Repositories
{
    public class CategoryRepository : ICategory
    {
        public void AddCategory(Models.Category category)
        {
            EntityCollection.CategoryList.Add(category);
        }
        public void EditCategory(string categoryId, string name, string description, float tax)
        {
            foreach (Models.Category category in EntityCollection.CategoryList)
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
           ProductRepository productRepository = new ProductRepository();
            foreach (Models.Category category in EntityCollection.CategoryList)
            {
                if (category.CategoryID == categoryId) 
                {
                   foreach(Models.Product product in EntityCollection.ProductList)
                   {
                       if(product.CategoryID == categoryId)
                       {
                           productIdList.Add(product.ProductID);
                       }
                   }
                    EntityCollection.CategoryList.Remove(category);
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
            return EntityCollection.CategoryList;
        }

        public Models.Category GetCategory(string categoryId)
        {
            Models.Category categoryFound = null;
            foreach (Models.Category category in EntityCollection.CategoryList)
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
