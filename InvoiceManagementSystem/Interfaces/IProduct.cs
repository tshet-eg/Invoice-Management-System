﻿using InvoiceManagementSystem.Models;
using System.Collections.Generic;


namespace InvoiceManagementSystem.Interfaces
{
    public interface IProduct
    {
        void EditProductDetails(Models.ProductsModel Product,string productName, string productDescription, int productPrice, double productDiscount, float productTax);
        void AddProducts(string productName, string productDescription, int productPrice, double productDiscount, float productTax,string categoryID);
        void DeleteProducts(string productId);
        List<ProductsModel> DisplayProducts();
        
    }
}
