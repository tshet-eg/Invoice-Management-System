using InvoiceManagementSystem.Models;
using InvoiceManagementSystem.Services;
using System;


namespace InvoiceManagementSystem.Controllers
{
    public class Product:BaseEntity
    {
        public void ProductSelection()
        {
            bool exit = false;

            while (!exit)
            {
            
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Delete Product");
                Console.WriteLine("3. Edit Product");
                Console.WriteLine("4. Display Product");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                int option;
                var ProductObject = new Models.Product();
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:

                            ProductObject.ProductID = "Prod"+ProductId;
                            ProductObject.ProductCategoryID =;
                            Console.WriteLine("Enter the product name");
                            ProductObject.ProductName=Console.ReadLine();
                            Console.WriteLine("Enter the product description");
                            ProductObject.ProductDescription=Console.ReadLine();
                            Console.WriteLine("Enter the product price");
                            ProductObject.Price=Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the product discount");
                            int discount=Convert.ToInt32(Console.ReadLine());
                            ProductObject.Discount = discount / 100;

                            var AddProduct = new Services.Product(ProductObject);
                            AddProduct.AddProductsService();
                            break;
                        case 2:
                            var DeleteProduct = new Services.Product(ProductObject);
                            DeleteProduct.DeleteProductsService();
                            break;
                        case 3:
                            var EditProduct = new Services.Product(ProductObject);
                            EditProduct.EditProductDetailsService();
                            break;
                        case 4:
                            var DisplayProduct = new Services.Product(ProductObject);
                            DisplayProduct.DisplayProductsService();
                            break;
                        case 5:
                            exit = true;
                            Console.WriteLine("Exiting program...");
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter a number.");
                }

                Console.WriteLine();

            }
        }
    }
}

