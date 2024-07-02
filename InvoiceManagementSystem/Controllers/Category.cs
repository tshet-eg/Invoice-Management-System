using InvoiceManagementSystem.Interfaces;
using System;
using System.Collections.Generic;

namespace InvoiceManagementSystem.Controllers
{
    public class Category
    {
        public void CategoryController()
        {
            try
            {
                int choice;
                string categoryId;
                ICategory categoryRepository = new Repositories.Category();
                Services.Category categoryService = new Services.Category(categoryRepository);
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
                                Models.Category categoryModel = new Models.Category(categoryName, categoryDescriptipn, tax);
                                categoryService.AddCategory(categoryModel);
                                DisplayMessage.DisplaySuccessMessage("\nCategory added successfully!!");

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
                                Models.Category updateCategory = categoryService.GetCategory(categoryId);
                                if (updateCategory == null)
                                {
                                    DisplayMessage.DisplayErrorMessage("\nProvided category ID does not exist!!");
                                    break;
                                }
                                int editChoice;
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
                                            categoryService.EditCategory(categoryId, updatedName, updateCategory.Description, updateCategory.Tax);
                                            DisplayMessage.DisplaySuccessMessage("\nCategory name updated successfully!!");
                                            break;
                                        case 2:
                                            Console.Write("\nEnter new category description: ");
                                            string updatedDescription = Console.ReadLine();
                                            categoryService.EditCategory(categoryId, updateCategory.Name, updatedDescription, updateCategory.Tax);
                                            DisplayMessage.DisplaySuccessMessage("\nCategory description updated successfully!!");
                                            break;
                                        case 3:
                                            Console.Write("\nEnter new category tax: ");
                                            float updatedTax = float.Parse(Console.ReadLine());
                                            categoryService.EditCategory(categoryId, updateCategory.Name, updateCategory.Description, updatedTax);
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
                                List<Models.Category> list = categoryService.DisplayCategory();
                                if (list.Count > 0)
                                {
                                    foreach (Models.Category category in list)
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
                                bool isPresent = categoryService.DeleteCategory(categoryId);
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
