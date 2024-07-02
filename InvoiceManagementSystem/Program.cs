using InvoiceManagementSystem.Controllers;
using System;
using InvoiceManagementSystem.Controllers;

namespace InvoiceManagementSystem
{
    public class Program
    {
        static void DisplayOptions(out int choice)
        {
            Console.WriteLine("\n\n-----------------MENU -----------------");
            Console.WriteLine("1. Customer operations");
            Console.WriteLine("2. Category operations");
            Console.WriteLine("3. Product operations");
            Console.WriteLine("4. Cart operations");
            Console.WriteLine("5. Generate invoice");
            Console.WriteLine("6. Exit");
            Console.WriteLine("----------------------------------------");
            Console.Write("\nEnter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int choice;
            do
            {
                DisplayOptions(out choice);
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
                    case 3:Controllers.Product product = new Controllers.Product();
                        product.ProductSelection();
                        break;
                    case 4:Cart cart = new Cart();
                        cart.CartOperations();
                        break;
                    case 6:
                        return;
                    case 5: Repositories.Invoice invoice = new Repositories.Invoice();
                            invoice.PrintInvoice();
                        break;
                    default:
                        DisplayMessage.DisplayErrorMessage("Invlaid choice. Enter correct choice!!!");
                        break;
                }

            } while (choice != 6);
        }
    }
}
