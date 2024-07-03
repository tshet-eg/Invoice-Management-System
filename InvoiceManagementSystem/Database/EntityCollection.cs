using InvoiceManagementSystem.Models;
using System.Collections.Generic;


namespace InvoiceManagementSystem.Database
{
    public class EntityCollection
    {
        public static List<Customer> CustomerList = new List<Customer>();
        public static List<Category> CategoryList = new List<Category>();
        public static List<Product> ProductList = new List<Product>();
        public static List<Cart> Cart = new List<Cart>();
    }
}
