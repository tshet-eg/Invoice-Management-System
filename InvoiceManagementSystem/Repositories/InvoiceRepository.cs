using InvoiceManagementSystem.Database;
using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Models;
using System;
using System.Collections.Generic;


namespace InvoiceManagementSystem.Repositories
{

    public class InvoiceRepository :BaseEntity, IInvoice, IDiscount, ITax
    {
        private float _subtotal;

        readonly StoreDetails storeDetails = new StoreDetails();
         Customer customer;

        

        public void PrintInvoice(List<Cart> cart)
        {


            int slNumber = 1000;
            customer = fetchcustomer(cart[0].CustomerID);
            Console.WriteLine($"\n            .________________________________________________________________________.");
            Console.WriteLine($"            |                                " + "{0,-40}|", storeDetails.Name);
            Console.WriteLine($"            |                                " + "{0,-40}|", storeDetails.Address);
            Console.WriteLine($"            |                                " + "{0,-40}|", storeDetails.Email);
            Console.WriteLine($"            |------------------------------------------------------------------------|");
            Console.WriteLine("            | {0,-40}{1,30} |", customer.CustomerName, DateTime.Now);
            Console.WriteLine("            | {0,-70} |",customer.Address);
            Console.WriteLine("            | {0,-70} |", customer.PhoneNumber);
            Console.WriteLine("            | {0,-70} |",InvoiceID );
            Console.WriteLine($"            |------------------------------------------------------------------------|");
            Console.WriteLine($"            |Sl.no |   ProductName    |   Qty  | Price  |  Tax(%) | Discount | Total |");
            Console.WriteLine($"            |------------------------------------------------------------------------|");
            foreach (Cart product in cart)
            {
                Console.WriteLine("            |{0,-10}{1,-20}{2,-3} {3,7}{4,9}{5,10}{6,11} |", slNumber++, product.Product.ProductName, product.Quantity, product.Product.ProductPrice, product.Product.ProductTax, ApplyDiscount(product.Product.ProductPrice, product.Product.ProductDiscount, product.Quantity, false), CalculateAmount(product));

            }
            Console.WriteLine($"            |------------------------------------------------------------------------|");
            Console.WriteLine($"            |                                                Subtotal    :" + "{0,10} |", _subtotal);
            Console.WriteLine($"            |                                                Service Tax :" + "{0,10} |", ApplyTax(_subtotal, storeDetails.ServiceTax));
            Console.WriteLine($"            |                                                Discount    :" + "{0,10} |", ApplyDiscount(_subtotal, storeDetails.DiscountRate, 1, true));
            Console.WriteLine($"            |                                                Grand Total :" + "{0,10} |", CalculateTotal(_subtotal));
            Console.WriteLine($"            |------------------------------------------------------------------------|");
            Console.WriteLine($"            |                               -Thank You-                              |");
            Console.WriteLine($"            |________________________________________________________________________|\n");


        }
        //method to  calculate discount amount
        public float ApplyDiscount(float amount, float discountRate, int quantity, bool isSubtotal)
        {
            if (amount < 1000 && isSubtotal)
                return 0.0f;

            return amount * discountRate * quantity;
        }
        //method caluclate grand total (deducting discount)
        public float CalculateTotal(float subtotal)
        {
            return subtotal - ApplyDiscount(subtotal, 0.1f, 1, true) + ApplyTax(subtotal, 0.03f);
        }

        public float ApplyTax(float amount, float taxRate)
        {
            return amount * taxRate;
        }
        //method caluclate amount an d also subtotal
        public float CalculateAmount(Cart product)
        {
            float amount = product.Quantity * product.Product.ProductPrice - ApplyDiscount(product.Product.ProductPrice, product.Product.ProductDiscount, product.Quantity, false);
            _subtotal += amount;
            return amount;
        }
        Customer fetchcustomer(string customerID)
        {
            foreach (Customer customer in EntityCollection.CustomerList)
            {
                if (customer.CustomerID == customerID)
                    return customer;
            }
            return null;
        }
    }
}
