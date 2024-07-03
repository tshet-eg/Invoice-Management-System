﻿using System;
using System.Collections.Generic;

using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Models;
using InvoiceManagementSystem.Database;


namespace InvoiceManagementSystem.Repositories
{
    public class ProductRepository:IProduct
    {
        public void AddProducts(string productName, string productDescription, int productPrice, float productDiscount, float productTax, string categoryID)
        {
            Models.Product Product = new Models.Product(productName, productDescription, productPrice, productDiscount, productTax, categoryID);
            EntityCollection.ProductList.Add(Product);


        }

        public void DeleteProducts(string productId)
        {
            
            foreach (var Product in EntityCollection.ProductList)
            {
                if (Product.ProductID==productId)
                {
                    EntityCollection.ProductList.Remove(Product);
                    Console.WriteLine("Deleted successfully");
                    break;
                }
               
            }

        }
        public void EditProductDetails(Models.Product Product,string productName, string productDescription, int productPrice, float productDiscount, float productTax)
        {
            Product.ProductName = productName;
            Product.ProductDescription = productDescription;
            Product.ProductPrice = productPrice;
            Product.ProductDiscount = productDiscount;
            Product.ProductTax = productTax;

        }


        public List<Models.Product> DisplayProducts()
        {
           return EntityCollection.ProductList;
        }

       
    }
}