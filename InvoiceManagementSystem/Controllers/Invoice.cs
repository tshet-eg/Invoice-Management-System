using InvoiceManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceManagementSystem.Controllers
{
    public class Invoice
    {
        public void InvoiceGeneration()
        {
            string customerID;
            Services.Cart cartService = new Services.Cart(new Repositories.Cart());
            IInvoice invoiceRepository = new Repositories.Invoice();
            Services.Invoice invoiceService = new Services.Invoice(invoiceRepository);

            Console.WriteLine("Enter the customer ID");
            customerID = Console.ReadLine();
            if (!Validations.Customer.CheckCustomer(customerID))
            {
                DisplayMessage.DisplayErrorMessage("Invlaid customer ID");
                return;
            }
            List<Models.Cart> cartList = cartService.DisplayCartItemsOfUser(customerID);
            if (cartList.Count()==0)
            {
                DisplayMessage.DisplayErrorMessage("Your Cart is empty");
                return;
            }
            invoiceService.PrintInvoiceService(cartList);
        }

    }
}
