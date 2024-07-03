using InvoiceManagementSystem.Validations;
using System;
using System.Collections.Generic;

namespace InvoiceManagementSystem.Controllers
{
    public class CartController
    {
        public void CartOperations()
        {
            int choice;
            int quantity;
            string customerId, productId, cartId;
            Services.CartService cart = new Services.CartService(new Repositories.CartRepository());
            do
            {
                //showing the menu
                Console.WriteLine("\n----------------CART MENU----------------");
                Console.WriteLine("1. Add items to Cart");
                Console.WriteLine("2. Display all items in the cart");
                Console.WriteLine("3. Display all cart items a customer");
                Console.WriteLine("4. Delete all cart items of a customer");
                Console.WriteLine("5. Delete a single cart item");
                Console.WriteLine("6. Edit a cart item");
                Console.WriteLine("7. BACK");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter customerId: ");
                        customerId = Console.ReadLine();
                        if (!Validations.Customer.CheckCustomer(customerId))
                        {
                            DisplayMessage.DisplayErrorMessage("Invalid Customer ID");
                            break;
                        }
                        Console.Write("Enter product Id: ");
                        productId = Console.ReadLine();
                        if (!ProductValidation.ProductIdValidation(productId))
                        {
                            DisplayMessage.DisplayErrorMessage("Invalid Product ID");
                            break;
                        }
                        Console.Write("Enter quantity: ");
                        try
                        {
                            quantity = Convert.ToInt32(Console.ReadLine());
                            if (quantity < 1)
                            {
                                DisplayMessage.DisplayErrorMessage("Quantity needs to greater than 0");
                                break;
                            }
                            cart.AddtoCart(customerId, productId, quantity); //function to add items to cart
                               DisplayMessage.DisplaySuccessMessage("Successfull added to cart");
                            }
                        catch (FormatException)
                        {
                            DisplayMessage.DisplayErrorMessage("Number is required");
                        }
                        break;
                    case 2:
                        List<Models.Cart> cartItems = cart.DisplayAllCartData(); //retrievig  all the the items from the cart
                        DisplayCartItems(cartItems);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Enter customer ID: ");
                        customerId = Console.ReadLine();
                        if (!Validations.Customer.CheckCustomer(customerId))
                        {
                            DisplayMessage.DisplayErrorMessage("Invalid Customer ID");
                            break;
                        }
                        List<Models.Cart> customerCartItems = cart.DisplayCartItemsOfUser(customerId); //retrieving all the cart items of customer
                        DisplayCartItems(customerCartItems);
                        break;
                    case 4:
                        Console.Write("Enter customer ID: ");
                        customerId = Console.ReadLine();
                        if (!Validations.Customer.CheckCustomer(customerId))
                        {
                            DisplayMessage.DisplayErrorMessage("Invalid Customer ID");
                            break;
                        }

                        if (cart.DisplayCartItemsOfUser(customerId).Count == 0)
                        {
                            DisplayMessage.DisplayErrorMessage("Cart is empty to delete");
                            break;
                        }
                        cart.ClearCartItemsOfUser(customerId); //deleteing all the cart items
                        DisplayMessage.DisplaySuccessMessage("customer's cart items cleared");
                        break;
                    case 5:
                        Console.Write("Enter the cart ID: ");
                        cartId = Console.ReadLine();
                        if (!Validations.Cart.VerifyCartId(cartId))
                        {
                            DisplayMessage.DisplayErrorMessage("Invalid Cart Id");
                            break;
                        }
                        cart.DeleteCartItem(cartId); //deleting single cart item
                        DisplayMessage.DisplaySuccessMessage("Cart Item is deleted");
                        break;
                    case 6:
                        Console.Write("Enter the cart ID: ");
                        cartId = Console.ReadLine();
                        if (!Validations.Cart.VerifyCartId(cartId))
                        {
                            DisplayMessage.DisplayErrorMessage("Invalid Cart Id");
                            break;
                        }
                        Console.Write("Enter the new quantity: ");
                        quantity = int.Parse(Console.ReadLine());
                        if (quantity < 1)
                        {
                            DisplayMessage.DisplayErrorMessage("Quantity needs to be greater than 0");
                            break;
                        }
                        cart.EditCartItem(cartId, quantity); //editing the cart item
                        DisplayMessage.DisplaySuccessMessage("Cart item updated");
                        break;
                    case 7: return;
                    default:
                        DisplayMessage.DisplayErrorMessage("Invlaid choice");
                        break;
                }
            } while (true);
        }

        //displaying the cart items
        public static void DisplayCartItems(List<Models.Cart> cartItems)
        {
            if (cartItems.Count == 0)
            {
                Console.WriteLine("\n\n      Cart is empty\n");
            }
            else
            {
                Console.WriteLine("\n\n      Cart Items \n");
                foreach (Models.Cart cartItem in cartItems)
                {
                    Console.WriteLine("Cart Id     : " + cartItem.CartID);
                    Console.WriteLine("Customer Id : " + cartItem.CustomerID);
                    Console.WriteLine("Product Id  : " + cartItem.Product.ProductID);
                    Console.WriteLine("Product Name: " + cartItem.Product.ProductName);
                    Console.WriteLine("Price       : " + cartItem.Product.ProductPrice);
                    Console.WriteLine("Quantity    : " + cartItem.Quantity);
                    Console.WriteLine();
                }
            }
        }
    }
}
