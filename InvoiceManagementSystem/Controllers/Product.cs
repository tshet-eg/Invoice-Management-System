using InvoiceManagementSystem.Models;
using InvoiceManagementSystem.Services;
using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Repositories;
using System;


namespace InvoiceManagementSystem.Controllers
{
    public class Product:BaseEntity
    {
        public static void ProductSelection()
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
                var ProductRepoObject = new Repositories.Product();
                var ProductObject = new Models.ProductsModel();
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                          
                        
                            Console.WriteLine("Enter the product name");
                            ProductObject.ProductName=Console.ReadLine();
                            Console.WriteLine("Enter the product description");
                            ProductObject.ProductDescription=Console.ReadLine();
                            Console.WriteLine("Enter the product price");
                            ProductObject.ProductPrice = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the product discount");
                            double discount=Convert.ToDouble(Console.ReadLine());
                            ProductObject.ProductDiscount = discount / 100;
                            var AddProduct = new Services.Product(ProductRepoObject);
                            AddProduct.AddProductsService(ProductObject);
                            break;
                        /*case 2:
                            var DeleteProduct = new Services.Product((Interfaces.IProduct)ProductObject);
                            DeleteProduct.DeleteProductsService();
                            break;
                        case 3:
                            var EditProduct = new Services.Product((Interfaces.IProduct)ProductObject);
                            EditProduct.EditProductDetailsService();
                            break;*/
                        case 4:
                            var DisplayProduct = new Services.Product(ProductRepoObject);
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

