using InvoiceManagementSystem.Models;


namespace InvoiceManagementSystem.Interfaces
{
    public interface IProduct
    {
        void EditProductDetails();
        void AddProducts(Models.Product Product);
        void DeleteProducts();
        void DisplayProducts();
        
    }
}
