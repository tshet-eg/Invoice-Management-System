﻿using System;
using System.Collections.Generic;

using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Models;
using InvoiceManagementSystem.Database;

namespace InvoiceManagementSystem.Repositories
{
    public class Product:IProduct
    {
        public void AddProducts(Models.Product Product )
        {
            DBEntity.ProductList.Add(Product);


        }

        public void DeleteProducts()
        {

        }
        public void EditProductDetails()
        {

        }

 
        public void DisplayProducts()
        {
            foreach(var Product in DBEntity.ProductList)
            {
                Console.WriteLine($"ProductID: {Product.ProductID}");
                Console.WriteLine($"Product Name: {Product.ProductName}");
                Console.WriteLine($"Product Description: {Product.ProductDescription}");
                Console.WriteLine($"Product Price: {Product.Price}");
                Console.WriteLine($"Product Discount: {Product.Discount} ");
                //Console.WriteLine($"Product CategoryID: {Product.ProductCategoryID}");

            }
        }

       
    }
}