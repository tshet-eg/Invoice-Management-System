using System;
using System.Collections.Generic;

namespace InvoiceManagementSystem.Controllers
{
    public class Cart
    {
        public static void CartOperations()
        {
            int choice;
            int quantity;
            string customerId, productId;
            Services.Cart cart=new Services.Cart(new Repositories.Cart());
            do
            {
                Console.WriteLine("1. Add items to Cart");
                Console.WriteLine("2. Delete all cart items of a customer");
                Console.WriteLine("3. Display all cart items a customer");
                Console.WriteLine("3. Display all cart items ");
                Console.WriteLine("4. Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter customerId: ");
                        customerId = Console.ReadLine();
                        Console.Write("Enter productId: ");
                        productId = Console.ReadLine();
                        Console.Write("Enter quantity: ");
                        quantity = int.Parse(Console.ReadLine());
                        cart.AddtoCart(customerId,productId,quantity);
                        break;
                    case 2:
                        Console.Write("Enter customerId: ");
                        customerId = Console.ReadLine();
                        cart.ClearCartItemsOfUser(customerId);
                        break;
                    case 3:
                        Console.Write("Enter customerId: ");
                        customerId = Console.ReadLine();
                        List<Models.Cart> customerCartItems=cart.DisplayCartItemsOfUser(customerId);
                        foreach (Models.Cart cartItem in customerCartItems)
                        {
                            Console.WriteLine("ProductId"+cartItem.Product.ProductID);
                            Console.WriteLine("CustomerId"+cartItem.CustomerID);
                            Console.WriteLine("quantity"+cartItem.Quantity);
                        }
                        break;
                    case 4:
                        List<Models.Cart> CartItems = cart.DisplayAllCartData();
                        foreach (Models.Cart cartItem in CartItems)
                        {
                            Console.WriteLine("ProductId" + cartItem.Product.ProductID);
                            Console.WriteLine("CustomerId" + cartItem.CustomerID);
                            Console.WriteLine("quantity" + cartItem.Quantity);
                        }
                        break; ;
                    case 5: return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (true);

        }
    }
}
