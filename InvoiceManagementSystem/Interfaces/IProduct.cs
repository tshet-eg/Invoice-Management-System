using InvoiceManagementSystem.Models;


namespace InvoiceManagementSystem.Interfaces
{
    public interface IProduct
    {
        void EditProductDetails(Models.ProductsModel Product);
        void AddProducts(Models.ProductsModel Product);
        void DeleteProducts(string productId);
        void DisplayProducts();
        
    }
}
