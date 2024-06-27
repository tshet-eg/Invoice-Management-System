using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Interfaces
{
    internal interface IProduct
    {
        void EditProductDetails();
        void AddProducts();
        void DeleteProducts();
        void DisplayProducts();

    }
}
