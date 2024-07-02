using InvoiceManagementSystem.Models;
namespace InvoiceManagementSystem.Interfaces
{
    public interface ICustomer
    {
        string CreateCustomer(Customer customer);
        Customer GetCustomer(string CustomerID);
        void DeleteCustomer(string CustomerID);
        void EditCustomerDetails(string CustomerID, string name, long phone, string email, string address);

    }
}
