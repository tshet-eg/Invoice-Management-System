namespace InvoiceManagementSystem.Models
{
    public class Customer : BaseEntity
    {
        private int _customerID;
        public int CustomerID
        {
            get
            {
                return _customerID;
            }
            set
            {
                _customerID = CustomerId;
            }
        }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public long PhoneNumber {  get; set; }
        public string Address { get; set; }
    }
}
