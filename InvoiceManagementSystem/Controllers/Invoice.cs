using InvoiceManagementSystem.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Controllers
{
    public class Invoice
    {
        public void InvoiceGeneration()
        {
            string customerID;
            Console.WriteLine("Enter the customer ID");
            customerID = Console.ReadLine();
            if(DBEntity.CategoryList.Contains(customerID))
        }

    }
}
