using InvoiceManagementSystem.Controllers;
using System;
using InvoiceManagementSystem.Controllers;

namespace InvoiceManagementSystem
{
    public class Program
    {
        static int DisplayOptions()
        { int choice;
            Console.WriteLine("\n\n-----------------MENU -----------------");
            Console.WriteLine("1. Customer operations");
            Console.WriteLine("2. Category operations");
            Console.WriteLine("3. Product operations");
            Console.WriteLine("4. Cart operations");
            Console.WriteLine("5. Generate invoice");
            Console.WriteLine("6. Exit");
            Console.WriteLine("----------------------------------------");
            Console.Write("\nEnter your choice: ");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
                return choice;
            }
            catch (Exception) {
                DisplayMessage.DisplayErrorMessage("Numbers required");
                return -1;
            }
        }
        static void Main(string[] args)
        {
            int choice;
                do
                {
                    choice=DisplayOptions();
                if (choice == -1) continue;
                   
                    switch (choice)
                    {
                        case 1:
                            Customer customer = new Customer();
                            customer.CustomerController();
                            break;
                        case 2:
                            Category categoryController = new Category();
                            categoryController.CustomerController();
                            break;
                        case 3:
                            Controllers.Product product = new Controllers.Product();
                            product.ProductSelection();
                            break;
                        case 4:
                            Cart cart = new Cart();
                            cart.CartOperations();
                            break;
                    case 5:
                        Invoice invoiceController = new Invoice();
                        invoiceController.InvoiceGeneration();
                        break;
                    case 6:
                            return;
                        default:
                            DisplayMessage.DisplayErrorMessage("Invalid choice. Enter correct choice!!!");
                            break;
                    }

                } while (choice != 6);
        }
    }
}
