using InvoiceManagementSystem.Interfaces;
namespace InvoiceManagementSystem.Services
{
    public class Product
    {
        private readonly IProduct _product;
        public Product(IProduct ProductObject) { 
            _product = ProductObject;
        }
        public void AddProductsService()
        {
            _product.AddProducts(_product);
        }
        public void DeleteProductsService()
        {
            _product.DeleteProducts();
        }
        public void EditProductDetailsService()
        {
            _product.EditProductDetails
        }
        public void DisplayProductsService()
        {
            _product.DisplayProducts();
        }
    }
}
