using InvoiceManagementSystem.Interfaces;
using System.Collections.Generic;
using InvoiceManagementSystem.Repositories;
using InvoiceManagementSystem.Models;
namespace InvoiceManagementSystem.Services
{
    public class ProductService
    {
        private readonly IProduct _product;
        public ProductService(ProductRepository ProductObject)
        {
            //Constructor injection is done 
            _product = ProductObject;
        }
       
        public void AddProductsService(string productName, string productDescription, int productPrice, float productDiscount, float productTax, string categoryID)
        {
            _product.AddProducts(productName, productDescription, productPrice, productDiscount, productTax, categoryID);
        }
        public void DeleteProductsService(string productId)
        {
            _product.DeleteProducts(productId);
        }
        public void EditProductDetailsService(Product Product,string productName,string productDescription,int productPrice,float productDiscount,float productTax   )
        {
            _product.EditProductDetails(Product,productName, productDescription, productPrice, productDiscount, productTax);
        }
        public List<Product> DisplayProductsService()
        {
            return _product.DisplayProducts();
        }
    }
}
