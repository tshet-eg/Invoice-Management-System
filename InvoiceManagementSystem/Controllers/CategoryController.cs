using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Models;
using InvoiceManagementSystem.Services;
using System;
using System.Collections.Generic;

namespace InvoiceManagementSystem.Controllers
{
    public class CategoryController
    {
        public void CategoryOperations()
        {
            try
            {
                int choice;
                string categoryId;
                ICategory categoryRepository = new Repositories.CategoryRepository();
                CategoryService categoryService = new CategoryService(categoryRepository);
                do
                {
                    Console.WriteLine("\n----------------CATEGORY MENU----------------");
                    Console.WriteLine("1. Add Category");
                    Console.WriteLine("2. Update Category");
                    Console.WriteLine("3. Display Category");
                    Console.WriteLine("4. Delete Category");
                    Console.WriteLine("5. BACK");
                    Console.WriteLine("---------------------------------------------\n");
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            try
                            {
                                Console.Write("\nEnter category name: ");
                                string categoryName = Console.ReadLine();
                                Console.Write("Enter category description: ");
                                string categoryDescriptipn = Console.ReadLine();
                                Console.Write("Enter category tax: ");
                                float tax = float.Parse(Console.ReadLine());
                                Category categoryModel = new Category(categoryName, categoryDescriptipn, tax);
                                string categoryID = categoryService.AddCategory(categoryModel);  //Adds new category
                                DisplayMessage.DisplaySuccessMessage($"\nCategory added successfully!! \nCategory ID is {categoryID}");

                            }
                            catch (Exception e)
                            {
                                DisplayMessage.DisplayErrorMessage(e.Message);
                            }
                            break;
                        case 2:
                            try
                            {
                                Console.Write("\nEnter the category ID to update: ");
                                categoryId = Console.ReadLine();
                                Category updateCategory = categoryService.GetCategory(categoryId);  //Retrives category to update
                                if (updateCategory == null)
                                {
                                    DisplayMessage.DisplayErrorMessage("\nProvided category ID does not exist!!");
                                    break;
                                }
                                int editChoice;

                                // Edits fields based on input
                                do
                                {
                                    Console.WriteLine("\nCategory ID: " + updateCategory.CategoryID);
                                    Console.WriteLine("Name: " + updateCategory.Name);
                                    Console.WriteLine("Description: " + updateCategory.Description);
                                    Console.WriteLine("Tax: " + updateCategory.Tax);

                                    Console.WriteLine("\nSelect field to update: \n1. Name\n2. Description\n3. Tax\n4. BACK");
                                    Console.Write("\nEnter your choice: ");
                                    editChoice = Convert.ToInt32(Console.ReadLine());

                                    switch (editChoice)
                                    {
                                        case 1:
                                            Console.Write("Enter new category name: ");
                                            string updatedName = Console.ReadLine();
                                            categoryService.EditCategory(categoryId, updatedName, updateCategory.Description, updateCategory.Tax);  //Edits category name
                                            DisplayMessage.DisplaySuccessMessage("\nCategory name updated successfully!!");
                                            break;
                                        case 2:
                                            Console.Write("\nEnter new category description: ");
                                            string updatedDescription = Console.ReadLine();
                                            categoryService.EditCategory(categoryId, updateCategory.Name, updatedDescription, updateCategory.Tax);  //Edits category description
                                            DisplayMessage.DisplaySuccessMessage("\nCategory description updated successfully!!");
                                            break;
                                        case 3:
                                            Console.Write("\nEnter new category tax: ");
                                            float updatedTax = float.Parse(Console.ReadLine());
                                            categoryService.EditCategory(categoryId, updateCategory.Name, updateCategory.Description, updatedTax);  //Edits category tax
                                            DisplayMessage.DisplaySuccessMessage("\nCategory tax updated successfully!!");
                                            break;
                                        case 4:
                                            break;
                                        default:
                                            DisplayMessage.DisplayErrorMessage("\nInvalid choice!!");
                                            break;
                                    }
                                } while (editChoice != 4);
                            }
                            catch (Exception e)
                            {
                                DisplayMessage.DisplayErrorMessage(e.Message);
                            }
                            break;

                        case 3:
                            try
                            {
                                List<Category> list = categoryService.DisplayCategory(); //Gets the category list to display
                                if (list.Count > 0)
                                {
                                    foreach (Category category in list)
                                    {
                                        Console.WriteLine("\nCategory ID: " + category.CategoryID);
                                        Console.WriteLine("Name: " + category.Name);
                                        Console.WriteLine("Description: " + category.Description);
                                        Console.WriteLine("Tax: " + category.Tax);
                                    }
                                }
                                else
                                {
                                    DisplayMessage.DisplayErrorMessage("\nCategory list is empty!!");
                                }
                            }
                            catch (Exception e)
                            {
                                DisplayMessage.DisplayErrorMessage(e.Message);
                            }
                            break;

                        case 4:
                            try
                            {
                                Console.Write("Enter the category ID to delete: ");
                                categoryId = Console.ReadLine();
                                bool isPresent = categoryService.DeleteCategory(categoryId); //Deletes the category
                                if (isPresent)
                                    DisplayMessage.DisplaySuccessMessage("\nCategory deleted!!");
                                else
                                {
                                    DisplayMessage.DisplayErrorMessage($"\nProvided Category ID {categoryId} does not exist!!");
                                }
                            }
                            catch (Exception e)
                            {
                                DisplayMessage.DisplayErrorMessage(e.Message);
                            }
                            break;

                        case 5:
                            break;

                        default:
                            DisplayMessage.DisplayErrorMessage("\nInvalid choice!!");
                            break;
                    }
                } while (choice != 5);
            }
            catch (Exception e)
            {
                DisplayMessage.DisplayErrorMessage(e.Message);
            }
        }
    }
}
