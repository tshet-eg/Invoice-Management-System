using InvoiceManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using InvoiceManagementSystem.Services;
using InvoiceManagementSystem.Repositories;
using InvoiceManagementSystem.Validations;
namespace InvoiceManagementSystem.Controllers
{
    public class InvoiceController
    {
        public void InvoiceGeneration()
        {
            string customerID;
            CartService cartService = new CartService(new CartRepository());
            IInvoice invoiceRepository = new InvoiceRepository();
            InvoiceService invoiceService = new InvoiceService(invoiceRepository);

            Console.WriteLine("Enter the customer ID");
            customerID = Console.ReadLine();
            if (!Customer.CheckCustomer(customerID))
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
