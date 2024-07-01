using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using InvoiceManagementSystem.Interfaces;


namespace InvoiceManagementSystem.Repositories
{
    public class Invoice : IInvoice
    {
        public void CalculateTotal()
        {
            throw new NotImplementedException();
        }

        public void PrintInvoice()
        {
            List<string> list = new List<string>(
                
                );
            
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("                                  Store"                                 );
            Console.WriteLine("                             WrkWrk, Mnagalore                          ");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Vijeth                                                      22-june-2001");
            Console.Write("Mangalore\n+9198765432\n22-june-2001\n");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Sl.no    ProductName     Qty     Price       Tax     Discount      Total");
            foreach(string element in list)
            {
            Console.WriteLine($"1        {element}        1       100         9         9            9 ");
            }   
            Console.WriteLine("------------------------------------------------------------------------");


        }
    }
}
