using InvoiceManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceManagementSystem.Controllers
{
    public class InvoiceController
    {
        public void InvoiceGeneration()
        {
            string customerID;
            Services.CartService cartService = new Services.CartService(new Repositories.CartRepository());
            IInvoice invoiceRepository = new Repositories.InvoiceRepository();
            Services.InvoiceService invoiceService = new Services.InvoiceService(invoiceRepository);

            Console.WriteLine("Enter the customer ID");
            customerID = Console.ReadLine();
            if (!Validations.CustomerValidation.CheckCustomer(customerID))
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
