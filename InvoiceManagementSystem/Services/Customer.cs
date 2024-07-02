using InvoiceManagementSystem.Interfaces;

namespace InvoiceManagementSystem.Services
{
    public class CustomerService
    {
        public ICustomer _iCustomer;
        public CustomerService(ICustomer customer)
        {
            _iCustomer = customer;
        }
        public string CreateCustomer(Models.Customer customer)
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
            bool isCustomer = Validations.Customer.CheckCustomer(CustomerID);
            if (isCustomer)
            {
                _iCustomer.DeleteCustomer(CustomerID);
            }
            return isCustomer;
        }
        public Models.Customer GetCustomer(string CustomerID)
        {
            return _iCustomer.GetCustomer(CustomerID);
        }
    }
}
