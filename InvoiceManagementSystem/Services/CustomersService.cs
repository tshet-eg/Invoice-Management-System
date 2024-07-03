using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Models;
using InvoiceManagementSystem.Validations;

namespace InvoiceManagementSystem.Services
{
    public class CustomersService
    {
        public ICustomer _iCustomer;
        //constructor injection to hide repository operations
        public CustomersService(ICustomer customer)
        {
            _iCustomer = customer;
        }
        public string CreateCustomer(Customer customer)
        {
            string customerId = _iCustomer.CreateCustomer(customer);
            return customerId;
        }
        public void EditCustomerDetails(string CustomerID, string name, long phone, string email, string address)
        {
            _iCustomer.EditCustomerDetails(CustomerID, name, phone, email, address);
        }
        public bool DeleteCustomer(string CustomerID)
        {
            bool isCustomer = CustomerValidation.CheckCustomer(CustomerID);
            if (isCustomer)
            {
                _iCustomer.DeleteCustomer(CustomerID);
            }
            return isCustomer;
        }
        public Customer GetCustomer(string CustomerID)
        {
            return _iCustomer.GetCustomer(CustomerID);
        }
    }
}
