using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Models;
using InvoiceManagementSystem.Repositories;
namespace InvoiceManagementSystem.Services
{


    public class Product
    {
        private readonly IProduct _product;
        public Product(Repositories.Product ProductObject)
        {
            _product = ProductObject;
        }
       
        public void AddProductsService(Models.ProductsModel product)
        {
            _product.AddProducts(product);
        }
        public void DeleteProductsService(string productId)
        {
            _product.DeleteProducts(productId);
        }
        public void EditProductDetailsService()
        {
            _product.EditProductDetails();
        }
        public void DisplayProductsService()
        {
            _product.DisplayProducts();
        }
    }
}
