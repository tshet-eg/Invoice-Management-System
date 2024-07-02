using System;
using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Models;
using InvoiceManagementSystem.Database;
using InvoiceManagementSystem.Controllers;

namespace InvoiceManagementSystem.Services
{
    public class Customer
    {
        public ICustomer _iCustomer;
        public Customer(ICustomer customer) 
        {
            _iCustomer = customer;
        }
        Repositories.Customer customer=new Repositories.Customer();
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
            bool isCustomer = customer.CheckCustomer(CustomerID);
            if (isCustomer)
            {
                _iCustomer.DeleteCustomer(CustomerID);
            }
            return isCustomer;
        }
        public Models.Customer DisplayCustomerDetails(string CustomerID)
        {
                return _iCustomer.DisplayCustomerDetails(CustomerID);
        }

        public Models.Customer GetCustomer(string CustomerID)
        {
            Models.Customer customerFound=customer.GetCustomer(CustomerID);
            return customerFound;
        }
    }
}
