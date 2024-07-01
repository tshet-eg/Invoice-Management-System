using InvoiceManagementSystem.Models;
using InvoiceManagementSystem.Services;
using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Repositories;
using System;
using InvoiceManagementSystem.Database;
using InvoiceManagementSystem.Validations;


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
                            Console.WriteLine("Enter the Tax for the Product");
                            ProductObject.ProductTax = float.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Product discount");
                            double discount=Convert.ToDouble(Console.ReadLine());
                            ProductObject.ProductDiscount = discount / 100;
                            Console.WriteLine("Enter the Category ID");
                            string productiD=Console.ReadLine();
                            ProductObject.CategoryID = Console.ReadLine();
                            /*if (CheckAvailablity(productiD))
                            {
                                
                            }*/
                            ProductObject.CategoryID = productiD;
                            var AddProduct = new Services.Product(ProductRepoObject);
                            AddProduct.AddProductsService(ProductObject);

                            break;
                        case 2:
                            Console.WriteLine("Enter the product ID to delete");
                            string productID = Console.ReadLine();
                            if (ProductValidation.ProductIdValidation(productID))
                            {
                                var DeleteProduct = new Services.Product(ProductRepoObject);
                                DeleteProduct.DeleteProductsService(productID);
                            }
                            else
                            {
                                Console.WriteLine("Entered ProductID is not valid");
                            }
                            
                           
                            

                            break;
                        case 3:
                            Console.Write("Enter the Product ID to update: ");
                            string productId = Console.ReadLine();

                            foreach (var Product in DBEntity.ProductList)
                            {
                                if (Product.ProductID == productId)
                                {
                                    Console.WriteLine("\nCategory ID: " + Product.ProductID);
                                    Console.WriteLine("Name: " + Product.ProductName);
                                    Console.WriteLine("Description: " + Product.ProductDescription);
                                    Console.WriteLine("Price: "+Product.ProductPrice);
                                    Console.WriteLine("Discount: " + Product.ProductDiscount);
                                    Console.WriteLine("Tax" + Product.ProductTax);
                                    Console.WriteLine("Category ID: "+Product.CategoryID);

                                    Console.WriteLine("\nSelect field to update: \n1. Name\n2. Description\n3. Price\n4. Discount\n5. Tax\n6. Exit");
                                    Console.Write("\nEnter your choice: ");
                                    int editChoice = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("\n");
                                    switch (editChoice)
                                    {
                                        case 1:
                                            Console.Write("Enter new Product name: ");
                                            Product.ProductName = Console.ReadLine();
                                            var EditProductName = new Services.Product(ProductRepoObject);
                                            EditProductName.EditProductDetailsService(Product);
                                            Console.Write("\nProduct name updated successfully!!");
                                            break;
                                        case 2:
                                            Console.Write("Enter new Product description: ");
                                            Product.ProductDescription = Console.ReadLine();
                                            var EditProductDescription = new Services.Product(ProductRepoObject);
                                            EditProductDescription.EditProductDetailsService(Product);
                                            Console.Write("\nProduct description updated successfully!!");
                                            break;
                                        case 3:
                                            Console.Write("Enter new Product price: ");
                                            Product.ProductPrice = Convert.ToInt16(Console.ReadLine());
                                            var EditProductPrice = new Services.Product(ProductRepoObject);
                                            EditProductPrice.EditProductDetailsService(Product);
                                            Console.Write("\nProduct tax updated successfully!!");
                                            break;
                                        case 4:
                                            Console.Write("Enter new Product Discount: ");
                                            Product.ProductName = Console.ReadLine();
                                            var EditProductDiscount = new Services.Product(ProductRepoObject);
                                            EditProductDiscount.EditProductDetailsService(Product);
                                            Console.Write("\nProduct tax updated successfully!!");
                                            break;
                                        case 5:
                                            Console.Write("Enter new Product Tax: ");
                                            Product.ProductTax =  float.Parse(Console.ReadLine());
                                            var EditProductTax = new Services.Product(ProductRepoObject);
                                            EditProductTax.EditProductDetailsService(Product);
                                            Console.Write("\nProduct tax updated successfully!!");
                                            break;
                                            case 6:
                                            break;
                                        default:
                                            Console.WriteLine("Invalid choice!!");
                                            break;
                                    }
                                    break;
                                }

                            }
                           



                            break;
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

