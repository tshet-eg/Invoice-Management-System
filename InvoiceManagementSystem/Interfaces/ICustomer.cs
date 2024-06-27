using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Interfaces
{
    internal interface ICustomer
    {
        void CreateCustomer();
        void DisplayCustomerDetails();
        void DeleteCustomer();
        void EditCustomerDetaile();

    }
}
