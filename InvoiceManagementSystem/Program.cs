using System;

namespace InvoiceManagementSystem
{
    public class Program
    {
        private static int choice;
        static void DisplayOptions()
        {
            Console.WriteLine();
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
            do
            {
                DisplayOptions();
                switch (choice)
                {
                    case 1:
                        Controllers.Customer customer = new Controllers.Customer();
                        customer.CustomerController();
                        break;
                    case 6:
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter correct option!!");
                        Console.ForegroundColor= ConsoleColor.White;
                        break;
                }

            } while (choice != 6);
        }
    }
}
