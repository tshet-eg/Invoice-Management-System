using InvoiceManagementSystem.Interfaces;
using System.Collections.Generic;
namespace InvoiceManagementSystem.Services
{
    public class Invoice
    {
        private IInvoice _invoice;
        public Invoice(IInvoice invoice)
        {
            _invoice = invoice;
        }
        public void PrintInvoiceService(List<Models.Cart> cart)
        {
            _invoice.PrintInvoice(cart);
        }
    }
}
