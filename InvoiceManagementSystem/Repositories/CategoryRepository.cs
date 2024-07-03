using InvoiceManagementSystem.Database;
using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Models;
using System.Collections.Generic;

namespace InvoiceManagementSystem.Repositories
{
    public class CategoryRepository : ICategory
    {
        public string AddCategory(Category category)
        {
            EntityCollection.CategoryList.Add(category); //Adding new category to list
            return category.CategoryID;
        }

        public void EditCategory(string categoryId, string name, string description, float tax)
        {
            foreach (Category category in EntityCollection.CategoryList)
            {
                //Checks if the ID matches and updates the fields
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

            //Adding all the product ID's of provided category to a list
            foreach (Product product in EntityCollection.ProductList)
            {
                if (product.CategoryID == categoryId)
                {
                    productIdList.Add(product.ProductID);
                }
            }
            //Deleting category from category list
            foreach (Category category in EntityCollection.CategoryList)
            {
                if (category.CategoryID == categoryId)
                {
                    EntityCollection.CategoryList.Remove(category);
                    break;
                }
            }
            //Deleting products from product list that belongs to the given category 
            foreach (string productID in productIdList)
            {
                productRepository.DeleteProducts(productID);
            }
        }

        public List<Category> DisplayCategory()
        {
            return EntityCollection.CategoryList;
        }

        //Function to return a category that matches the given category ID
        public Category GetCategory(string categoryId)
        {
            Category categoryFound = null;
            foreach (Category category in EntityCollection.CategoryList)
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
