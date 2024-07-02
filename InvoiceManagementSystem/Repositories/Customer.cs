﻿using InvoiceManagementSystem.Database;
using InvoiceManagementSystem.Interfaces;
using System;

namespace InvoiceManagementSystem.Repositories
{
    public class Customer : ICustomer
    {
        public string CreateCustomer(Models.Customer customer)
        {
            DBEntity.CustomerList.Add(customer);
            return customer.CustomerID;
        }
        public void EditCustomerDetails(string CustomerID, string name, long phone, string email, string address)
        {
            foreach(Models.Customer customerEntry in DBEntity.CustomerList)
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
            foreach (Models.Customer customerEntry in DBEntity.CustomerList)
            {
                if (customerEntry.CustomerID==CustomerID)
                {
                    DBEntity.CustomerList.Remove(customerEntry);
                    break;
                }
            }
        }
        public Models.Customer DisplayCustomerDetails(string CustomerID)
        {
            Models.Customer customer = null;
            foreach (Models.Customer customerEntry in DBEntity.CustomerList)
            {
                if (CustomerID == customerEntry.CustomerID)
                {
                    customer = customerEntry;

                }
            }
            return customer;
        }
        public bool CheckCustomer(string CustomerID)
        {
            bool isPresent = false;
            foreach (Models.Customer customerEntry in DBEntity.CustomerList)
            {
                if (CustomerID == customerEntry.CustomerID)
                {
                    isPresent = true;
                    break;
                }
            }
            return isPresent;
        }

        public Models.Customer GetCustomer(string CustomerID)
        {
            Models.Customer customer = null;
            foreach(Models.Customer customerEntry in DBEntity.CustomerList)
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
