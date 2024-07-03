using InvoiceManagementSystem.Interfaces;
using System.Collections.Generic;
namespace InvoiceManagementSystem.Services
{


    public class Product
    {
        private readonly IProduct _product;
        public Product(Repositories.Product ProductObject)
        {
            _product = ProductObject;
        }
       
        public void AddProductsService(string productName, string productDescription, int productPrice, double productDiscount, float productTax, string categoryID)
        {
            _product.AddProducts(productName, productDescription, productPrice, productDiscount, productTax, categoryID);
        }
        public void DeleteProductsService(string productId)
        {
            _product.DeleteProducts(productId);
        }
        public void EditProductDetailsService(Models.ProductsModel Product,string productName,string productDescription,int productPrice,double productDiscount,float productTax   )
        {
            _product.EditProductDetails(Product,productName, productDescription, productPrice, productDiscount, productTax);
        }
        public List<ProductsModel> DisplayProductsService()
        {
            return _product.DisplayProducts();
        }
    }
}
