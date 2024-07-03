using InvoiceManagementSystem.Database;
using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Models;

namespace InvoiceManagementSystem.Repositories
{
    public class CustomersRepository : ICustomer
    {
        //function to create new customer
        public string CreateCustomer(Customer customer)
        {
            EntityCollection.CustomerList.Add(customer);//adds customer details into the list
            return customer.CustomerID;
        }

        //function to edit customer details
        public void EditCustomerDetails(string CustomerID, string name, long phone, string email, string address)
        {
            foreach (Customer customerEntry in EntityCollection.CustomerList)//updates customer details in the list
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

        //function to delete a customer
        public void DeleteCustomer(string CustomerID)
        {
            foreach (Customer customerEntry in EntityCollection.CustomerList)
            {
                if (customerEntry.CustomerID == CustomerID)
                {
                    EntityCollection.CustomerList.Remove(customerEntry);//deletes customer from list
                    break;
                }
            }
        }

        //function to display customer details
        public Customer GetCustomer(string CustomerID)
        {
            Customer customer = null;
            foreach (Customer customerEntry in EntityCollection.CustomerList)
            {
                if (CustomerID == customerEntry.CustomerID)
                {
                    customer = customerEntry;

                }
            }
            return customer;//retrieves customer details if present in the list
        }
    }
}
