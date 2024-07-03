using System;
using System.Collections.Generic;
using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Database;

namespace InvoiceManagementSystem.Repositories
{
    public class Product:IProduct
    {
        public void AddProducts(string productName, string productDescription, int productPrice, double productDiscount, float productTax, string categoryID)
        {
            Models.ProductsModel Product = new Models.ProductsModel(productName, productDescription, productPrice, productDiscount, productTax, categoryID);
            DBEntity.ProductList.Add(Product);


        }

        public void DeleteProducts(string productId)
        {
            
            foreach (var Product in DBEntity.ProductList)
            {
                if (Product.ProductID==productId)
                {
                    DBEntity.ProductList.Remove(Product);
                    Console.WriteLine("Deleted successfully");
                    break;
                }
               
            }

        }
        public void EditProductDetails(Models.ProductsModel Product,string productName, string productDescription, int productPrice, double productDiscount, float productTax)
        {
            Product.ProductName = productName;
            Product.ProductDescription = productDescription;
            Product.ProductPrice = productPrice;
            Product.ProductDiscount = productDiscount;
            Product.ProductTax = productTax;

        }


        public List<ProductsModel> DisplayProducts()
        {
           return DBEntity.ProductList;
        }

       
    }
}
