namespace InvoiceManagementSystem.Interfaces
{
    internal interface ITax
    {
        float ApplyTax(float amount, float taxRate);
    }
}
