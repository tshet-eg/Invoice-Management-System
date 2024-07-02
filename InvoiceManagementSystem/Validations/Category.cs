using InvoiceManagementSystem.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Validations
{
    public class Category
    {
        public static bool CheckAvailability(string categoryId)
        {
            foreach (Models.Category category in DBEntity.CategoryList)
            {
                if (category.CategoryID == categoryId)
                    return true;
            }
            return false;
        }
    }
}
