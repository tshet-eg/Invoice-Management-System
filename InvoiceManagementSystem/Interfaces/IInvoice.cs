using System.Collections.Generic;

namespace InvoiceManagementSystem.Interfaces
{
    public interface IInvoice
    {
        float CalculateTotal(float subtotal);
        void PrintInvoice(List<Models.Cart> cart);

    }
}
