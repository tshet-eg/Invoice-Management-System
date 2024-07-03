using InvoiceManagementSystem.Interfaces;
using InvoiceManagementSystem.Models;
using System.Collections.Generic;
namespace InvoiceManagementSystem.Services
{
    public class InvoiceService
    {
        private IInvoice _invoice;
        public InvoiceService(IInvoice invoice)
        {
            _invoice = invoice;
        }
        public void PrintInvoiceService(List<Cart> cart)
        {
            _invoice.PrintInvoice(cart);
        }
    }
}
