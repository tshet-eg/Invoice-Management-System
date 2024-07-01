namespace InvoiceManagementSystem.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        private readonly float  _serviceTax = 3.0f;
        private readonly float _discount = 5.0f;
        public double Subtotal {  get; set; }
        public double Total {  get; set; }
    }
}
