using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Models;
using InvoiceManagementSystem.Repositories;
using InvoiceManagementSystem.Services;
using System;

namespace InvoiceManagementSystem.Controllers
{
    public class CustomersController
    {
        int choice;
        public void CustomerOperations()
        {
            try
            {
                string customerId;
                ICustomer customerRepository = new CustomersRepository();
                CustomersService customer = new CustomersService(customerRepository);
                do
                {
                    Console.WriteLine("\n----------------CUSTOMER MENU----------------");
                    Console.WriteLine(" 1. Add Customer \n 2. Edit customer details\n 3. View customer details\n 4. Delete customer\n 5. Back");
                    Console.WriteLine("-----------------------------------------------");
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
                                Console.Write("Enter you phone number: ");
                                long PhoneNumber = long.Parse(Console.ReadLine());
                                Console.Write("Enter your email ID: ");
                                string CustomerEmail = Console.ReadLine();
                                Console.Write("Enter your address: ");
                                string Address = Console.ReadLine();
                                Customer customerType = new Customer(CustomerName, PhoneNumber, CustomerEmail, Address);
                                customerId = customer.CreateCustomer(customerType);//creates new customer
                                DisplayMessage.DisplaySuccessMessage($"\nAccount created successfully!!\nYour account ID is: {customerId}");
                            }
                            catch (Exception e)
                            {
                                DisplayMessage.DisplayErrorMessage(e.Message);
                            }
                            break;
                        case 2:
                            try
                            {
                                Console.Write("Enter unique customer ID: ");
                                customerId = Console.ReadLine();
                                Customer customerEntry = customer.GetCustomer(customerId);//retrieves customer details of given customer ID
                                if (customerEntry == null)
                                {
                                    DisplayMessage.DisplayErrorMessage("Invalid customer ID!!!");
                                    break;
                                }
                                else
                                {
                                    int option;
                                    //edits fileds based on user input
                                    do
                                    {
                                        Console.WriteLine("\nCustomer ID : " + customerEntry.CustomerID);
                                        Console.WriteLine("Customer name : " + customerEntry.CustomerName);
                                        Console.WriteLine("Customer phone : " + customerEntry.PhoneNumber);
                                        Console.WriteLine("Customer email ID : " + customerEntry.CustomerEmail);
                                        Console.WriteLine("Customer address : " + customerEntry.Address);
                                        Console.WriteLine("\n---------------EDIT MENU---------------");
                                        Console.WriteLine(" 1.Change name\n 2.Change phone number\n 3.Change email address\n 4.Change address\n 5.Back");
                                        Console.WriteLine("-----------------------------------------\n");
                                        Console.Write("Enter your option: ");
                                        option = int.Parse(Console.ReadLine());
                                        Console.WriteLine("");
                                        switch (option)
                                        {
                                            case 1:
                                                Console.Write("Enter name to update: ");
                                                string customerName = Console.ReadLine();
                                                customer.EditCustomerDetails(customerId, customerName, customerEntry.PhoneNumber, customerEntry.CustomerEmail, customerEntry.Address);//updates customer name
                                                DisplayMessage.DisplaySuccessMessage("\n Name updated successfully!!");
                                                break;
                                            case 2:
                                                Console.Write("Enter phone number to update: ");
                                                long phoneNumber = long.Parse(Console.ReadLine());
                                                customer.EditCustomerDetails(customerId, customerEntry.CustomerName, phoneNumber, customerEntry.CustomerEmail, customerEntry.Address);//updates customer phone number
                                                DisplayMessage.DisplaySuccessMessage("\n Phone number updated successfully!!");
                                                break;
                                            case 3:
                                                Console.Write("Enter emailID to update: ");
                                                string email = Console.ReadLine();
                                                customer.EditCustomerDetails(customerId, customerEntry.CustomerName, customerEntry.PhoneNumber, email, customerEntry.Address);//updates customer email id
                                                DisplayMessage.DisplaySuccessMessage("\n Email ID updated successfully!!");
                                                break;
                                            case 4:
                                                Console.Write("Enter address to update: ");
                                                string address = Console.ReadLine();
                                                customer.EditCustomerDetails(customerId, customerEntry.CustomerName, customerEntry.PhoneNumber, customerEntry.CustomerEmail, address);//updates customer address
                                                DisplayMessage.DisplaySuccessMessage("\n Address updated successfully!!");
                                                break;
                                            case 5:
                                                break;
                                            default:
                                                DisplayMessage.DisplayErrorMessage("Invalid choice. Enter correct choice!!!");
                                                break;
                                        }
                                    } while (option != 5);
                                }
                            }
                            catch (Exception e)
                            {
                                DisplayMessage.DisplayErrorMessage(e.Message);
                            }
                            break;
                        case 3:
                            try
                            {
                                Console.Write("Enter unique customer ID: ");
                                customerId = Console.ReadLine();
                                Customer displayCustomer = customer.GetCustomer(customerId);//retrieves customer details
                                if (displayCustomer == null)
                                {
                                    DisplayMessage.DisplayErrorMessage("Invalid Customer ID!!!");
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
                                DisplayMessage.DisplayErrorMessage(e.Message);
                            }
                            break;
                        case 4:
                            Console.Write("Enter unique customer ID: ");
                            customerId = Console.ReadLine();
                            bool isPresent = customer.DeleteCustomer(customerId);//deletes customer account
                            if (!isPresent)
                            {
                                DisplayMessage.DisplayErrorMessage("Invalid Customer ID!!!");
                                break;
                            }
                            DisplayMessage.DisplaySuccessMessage("\n Customer deleted successfully!!");
                            break;
                        case 5:
                            break;
                        default:
                            DisplayMessage.DisplayErrorMessage("Invalid choice. Enter correct choice!!!");
                            break;
                    }
                } while (choice != 5);
            }
            catch
            {
                DisplayMessage.DisplayErrorMessage("Integer required!!!");
            }
        }
    }
}
