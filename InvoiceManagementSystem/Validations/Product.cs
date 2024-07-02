using System;
using System.Collections.Generic;
using InvoiceManagementSystem;
using InvoiceManagementSystem.Database;

namespace InvoiceManagementSystem.Validations
{
    public class ProductValidation
    {
        public static bool ProductIdValidation(string productID)
        {
            bool result = false;
            foreach (var item in DBEntity.ProductList)
            {
                Console.WriteLine(item.ProductID);
                if (item.ProductID == productID)
                {
                    result=true;
                    break;
                }
                else
                {
                    result=false;
                }
            }
            return result;
            
        }
    }
}
