using InvoiceManagementSystem.Interfaces;
using System;

namespace InvoiceManagementSystem.Controllers
{
    public class Customer
    {
        int choice;
        public void CustomerController()
        {
            string customerId;
            ICustomer customerRepository = new Repositories.Customer();
            Services.Customer customer = new Services.Customer(customerRepository);
            do
            {
                Console.WriteLine("\n----------------MENU----------------");
                Console.WriteLine(" 1. Add Customer \n 2. Edit customer details\n 3. View customer details\n 4. Delete customer\n 5. Exit");
                Console.WriteLine("------------------------------------");
                Console.Write("Enter you choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.Write("Enter your name: ");
                            string CustomerName = Console.ReadLine();
                            Console.Write("Enter you phone number: ");
                            long PhoneNumber = long.Parse(Console.ReadLine());
                            Console.Write("Enter your email ID: ");
                            string CustomerEmail = Console.ReadLine();
                            Console.Write("Enter your address: ");
                            string Address = Console.ReadLine();
                            Models.Customer customerType = new Models.Customer(CustomerName, PhoneNumber, CustomerEmail, Address);
                            customerId = customer.CreateCustomer(customerType);
                            Console.WriteLine($"\nAccount created successfully!!\nYour account ID is: {customerId}");
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(e.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case 2:
                        try
                        {
                            Console.Write("Enter unique customer ID: ");
                            customerId = Console.ReadLine();
                            Models.Customer customerEntry = customer.GetCustomer(customerId);
                            if (customerEntry == null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Customer ID is invalid");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                            else
                            {
                                int option;
                                do
                                {
                                    Console.WriteLine("\nCustomer ID : " + customerEntry.CustomerID);
                                    Console.WriteLine("Customer name : " + customerEntry.CustomerName);
                                    Console.WriteLine("Customer phone : " + customerEntry.PhoneNumber);
                                    Console.WriteLine("Customer email ID : " + customerEntry.CustomerEmail);
                                    Console.WriteLine("Customer address : " + customerEntry.Address);
                                    Console.WriteLine("\n---------------MENU---------------");
                                    Console.WriteLine(" 1.Change name\n 2.Change phone number\n 3.Change email address\n 4.Change address\n 5.Exit");
                                    Console.WriteLine("----------------------------------\n");
                                    Console.Write("Enter your option: ");
                                    option = int.Parse(Console.ReadLine());
                                    Console.WriteLine("");
                                    switch (option)
                                    {
                                        case 1:
                                            Console.Write("Enter name to update: ");
                                            string customerName = Console.ReadLine();
                                            customer.EditCustomerDetails(customerId, customerName, customerEntry.PhoneNumber, customerEntry.CustomerEmail, customerEntry.Address);
                                            Console.WriteLine("Name updated successfully!!");
                                            break;
                                        case 2:
                                            Console.Write("Enter phone number to update: ");
                                            long phoneNumber = long.Parse(Console.ReadLine());
                                            customer.EditCustomerDetails(customerId, customerEntry.CustomerName, phoneNumber, customerEntry.CustomerEmail, customerEntry.Address);
                                            Console.WriteLine("Phone number updated successfully!!");
                                            break;
                                        case 3:
                                            Console.Write("Enter emailID to update: ");
                                            string email = Console.ReadLine();
                                            customer.EditCustomerDetails(customerId, customerEntry.CustomerName, customerEntry.PhoneNumber, email, customerEntry.Address);
                                            Console.WriteLine("Email ID updated successfully!!");
                                            break;
                                        case 4:
                                            Console.Write("Enter address to update: ");
                                            string address = Console.ReadLine();
                                            customer.EditCustomerDetails(customerId, customerEntry.CustomerName, customerEntry.PhoneNumber, customerEntry.CustomerEmail, address);
                                            Console.WriteLine("Address updated successfully!!");
                                            break;
                                        case 5:
                                            break;
                                        default:
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Enter correct option!!");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;
                                    }
                                } while (option != 5);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(e.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.Write("Enter unique customer ID: ");
                            customerId = Console.ReadLine();
                            Models.Customer displayCustomer = customer.GetCustomer(customerId);
                            if (displayCustomer == null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nCustomer ID not found!!");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }
                            Console.WriteLine($"\nCustomer {customerId} details:");
                            Console.WriteLine("Customer name : " + displayCustomer.CustomerName);
                            Console.WriteLine("Customer phone number : " + displayCustomer.PhoneNumber);
                            Console.WriteLine("Customer email : " + displayCustomer.CustomerEmail);
                            Console.WriteLine("Customer name : " + displayCustomer.Address);
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(e.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case 4:
                        Console.Write("Enter unique customer ID: ");
                        customerId = Console.ReadLine();
                        bool isPresent = customer.DeleteCustomer(customerId);
                        if (!isPresent)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nProvided customer ID does not exist");
                            Console.ForegroundColor = ConsoleColor.White; break;
                        }
                        Console.WriteLine("\nCustomer deleted successfully!!");
                        break;
                    case 5:
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter correct option\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            } while (choice != 5);
        }
    }
}
