using InvoiceManagementSystem.Interfaces;
using System.Collections.Generic;
namespace InvoiceManagementSystem.Services
{


    public class ProductService
    {
        private readonly IProduct _product;
        public ProductService(Repositories.ProductRepository ProductObject)
        {
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
        public void EditProductDetailsService(Models.Product Product,string productName,string productDescription,int productPrice,float productDiscount,float productTax   )
        {
            _product.EditProductDetails(Product,productName, productDescription, productPrice, productDiscount, productTax);
        }
        public List<Models.Product> DisplayProductsService()
        {
            return _product.DisplayProducts();
        }
    }
}
