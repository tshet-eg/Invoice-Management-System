using System;
using System.Collections.Generic;
using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Database;
using InvoiceManagementSystem.Models;

namespace InvoiceManagementSystem.Repositories
{
    public class ProductRepository:IProduct
    {
        public void AddProducts(string productName, string productDescription, int productPrice, float productDiscount, float productTax, string categoryID)
        {
            Models.Product Product = new Product(productName, productDescription, productPrice, productDiscount, productTax, categoryID);
            EntityCollection.ProductList.Add(Product);
        }

        public void DeleteProducts(string productId)
        {
            
            foreach (var Product in EntityCollection.ProductList)
            {
                if (Product.ProductID==productId)
                {
                    EntityCollection.ProductList.Remove(Product);
                    break;
                }
               
            }

        }
        public void EditProductDetails(Product Product,string productName, string productDescription, int productPrice, float productDiscount, float productTax)
        {
            Product.ProductName = productName;
            Product.ProductDescription = productDescription;
            Product.ProductPrice = productPrice;
            Product.ProductDiscount = productDiscount;
            Product.ProductTax = productTax;

        }


        public List<Product> DisplayProducts()
        {
           return EntityCollection.ProductList;
        }

       
    }
}
