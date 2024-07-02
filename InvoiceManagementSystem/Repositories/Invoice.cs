using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Models;


namespace InvoiceManagementSystem.Repositories
{
    public class Products
    {
        public string name;
        public float tax;
        public float rate;
        public int qty;
        public float discount;

    }
    public class Cart
    {
        public static int id = 100;
        public  string  name;
        public Products products;
    }
    public class Invoice : IInvoice,IDiscount,ITax
    {
        private float _subtotal;
        public float CalculateAmount(Products cart)
        {
             float amount = cart.qty * cart.rate-ApplyDiscount(cart.rate,cart.discount,cart.qty, false);
            _subtotal += amount;
            return amount;
        }
    
        


       
        StoreDetails storeDetails = new StoreDetails();
       

        public void PrintInvoice()
        {
            Products prod1 = new Products();
            int i = 100;
            prod1.name = "hp";
                prod1.tax = 0.03f;
                prod1.rate = 899;
                prod1.discount = 0.1f;
                prod1.qty = 2;

            
            Products prod2 = new Products();

            prod2.name = "redmi";
                prod2.tax = 0.03f;
                prod2.rate = 1799;
                prod2.discount = 0;
                prod2.qty = 3;
            Products prod3 = new Products();

            prod3.name = "samsung";
            prod3.tax = 0.03f;
            prod3.rate = 1599;
            prod3.discount = 0.2f;
            prod3.qty = 3;


            List<Products>prods = new List<Products>();
            prods.Add(prod1);
            prods.Add(prod2);
            prods.Add(prod3);
            Cart cart = new Cart();
            cart.name = "Vieth";
            cart.products = prod1 ;



   
            Console.WriteLine($"\n            .________________________________________________________________________.");
            Console.WriteLine($"            |                                "+"{0,-40}|",storeDetails.Name);
            Console.WriteLine($"            |                                "+"{0,-40}|",storeDetails.Address);
            Console.WriteLine($"            |                                "+"{0,-40}|",storeDetails.Email);
            Console.WriteLine($"            |------------------------------------------------------------------------|");
            Console.WriteLine("            | {0,-40}{1,30} |",cart.name,DateTime.Now);
            Console.WriteLine("            | {0,-70} |","Mangalore");
            Console.WriteLine("            | {0,-70} |","+9198765432");
            Console.WriteLine($"            |------------------------------------------------------------------------|");
            Console.WriteLine($"            |Sl.no |   ProductName    |   Qty  | Price  |  Tax  | Discount  |  Total |");
            Console.WriteLine($"            |------------------------------------------------------------------------|");
            foreach(Products product in prods)
            {
            Console.WriteLine("            |{0,-10}{1,-20}{2,-3} {3,7}{4,9}{5,10}{6,11} |", i++,product.name,product.qty,product.rate,product.tax,ApplyDiscount(product.rate, product.discount,product.qty, false),CalculateAmount(product));
            Console.WriteLine("            |{0,-10}{1,-20}{2,-3} {3,7}{4,9}{5,10}{6,11} |", i++, product.name, product.qty, product.rate, product.tax, ApplyDiscount(product.rate, product.discount, product.qty, false), CalculateAmount(product));
            }
            Console.WriteLine($"            |------------------------------------------------------------------------|");
            Console.WriteLine($"            |                                                Subtotal    :"+"{0,10} |",_subtotal);
            Console.WriteLine($"            |                                                Service Tax :" + "{0,10} |",ApplyTax(_subtotal,0.03f));
            Console.WriteLine($"            |                                                Discount    :"+"{0,10} |",ApplyDiscount(_subtotal,0.1f,1, true));
            Console.WriteLine($"            |                                                Grand Total :"+"{0,10} |",CalculateTotal(_subtotal));
            Console.WriteLine($"            |------------------------------------------------------------------------|");
            Console.WriteLine($"            |                               -Thank You-                              |");
            Console.WriteLine($"            |________________________________________________________________________|\n");


        }

        public float ApplyDiscount(float amount, float discountRate,int quantity,bool isSubtotal)
        {
            if (amount < 1000 && isSubtotal)
                return 0.0f;

            return amount * discountRate*quantity;
        }
        public float CalculateTotal(float subtotal)
        {
            return subtotal - ApplyDiscount(subtotal, 0.1f,1,true) + ApplyTax(subtotal,0.03f);
        }

        public float ApplyTax(float amount,float taxRate)
        {
           return amount * taxRate;
        }
    }
}
