namespace InvoiceManagementSystem.Models
{
    public class Customer : BaseEntity
    {
        private string _customerID;
        public string CustomerID
        {
            get
            {
                return _customerID;
            }
            set
            {
                _customerID = "CUST"+CustomerId;
            }
        }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public long PhoneNumber {  get; set; }
        public string Address { get; set; }
    }
}
