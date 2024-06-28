using System.Collections.Generic;

namespace InvoiceManagementSystem.Database
{
    public class DBEntity
    {
        public List<Customer>CustomerList=new List<Customer>();
        public List<Category>CategoryList=new List<Category>();
        public List<Product>ProductList=new List<Product>();
        public List<Cart>Cart=new List<Cart>();
    }
}
