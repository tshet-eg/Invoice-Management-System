namespace InvoiceManagementSystem.Interfaces
{
    internal interface IDiscount
    {
        float ApplyDiscount(float ammount,float discountRate,int quantity, bool isSubtotal);

    }
}
