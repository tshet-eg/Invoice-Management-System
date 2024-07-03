using InvoiceManagementSystem.Database;
using InvoiceManagementSystem.Interfaces;

namespace InvoiceManagementSystem.Repositories
{
    public class CustomerRepository : ICustomer
    {
        public string CreateCustomer(Models.Customer customer)
        {
            EntityCollection.CustomerList.Add(customer);
            return customer.CustomerID;
        }
        public void EditCustomerDetails(string CustomerID, string name, long phone, string email, string address)
        {
            foreach (Models.Customer customerEntry in EntityCollection.CustomerList)
            {
                if (customerEntry.CustomerID == CustomerID)
                {
                    customerEntry.CustomerName = name;
                    customerEntry.PhoneNumber = phone;
                    customerEntry.CustomerEmail = email;
                    customerEntry.Address = address;
                    break;
                }
            }
        }
        public void DeleteCustomer(string CustomerID)
        {
            foreach (Models.Customer customerEntry in EntityCollection.CustomerList)
            {
                if (customerEntry.CustomerID == CustomerID)
                {
                    EntityCollection.CustomerList.Remove(customerEntry);
                    break;
                }
            }
        }
        public Models.Customer GetCustomer(string CustomerID)
        {
            Models.Customer customer = null;
            foreach (Models.Customer customerEntry in EntityCollection.CustomerList)
            {
                if (CustomerID == customerEntry.CustomerID)
                {
                    customer = customerEntry;

                }
            }
            return customer;
        }
    }
}
