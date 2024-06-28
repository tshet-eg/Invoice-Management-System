using InvoiceManagementSystem.Models;

namespace InvoiceManagementSystem.Interfaces
{
    public interface IProduct
    {
        void EditProductDetails();
        void AddProducts(IProduct Product);
        void DeleteProducts();
        void DisplayProducts();

    }
}
