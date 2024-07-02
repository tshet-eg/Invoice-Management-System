namespace InvoiceManagementSystem.Interfaces
{
    public interface IInvoice
    {
        float CalculateTotal(float subtotal);
        void PrintInvoice();

    }
}
