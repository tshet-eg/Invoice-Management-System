namespace InvoiceManagementSystem.Models
{
    public class Customer : BaseEntity
    {
        public string CustomerID {  get; set; }
        public string CustomerName { get; set; }
        private string _customerEmail;
        public string CustomerEmail 
        {
            get
            {
                return _customerEmail;
            }
            set
            {
                if (Validations.Customer.ValidateEmail(value))
                {
                    _customerEmail = value;
                }
                else
                    throw new System.Exception("Invalid Email-ID!!");
            } 
        }
        private long _phoneNumber;
        public long PhoneNumber 
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (Validations.Customer.ValidatePhone(value) && value.ToString().Length==10)
                {
                    _phoneNumber = value;   
                }
                else
                    throw new System.Exception("Invalid Phone Number!!");
            }
        }
        public string Address { get; set; }

        public Customer(string name, long phoneNumber, string emailID, string address)
        {
            CustomerName = name;
            CustomerEmail = emailID;
            PhoneNumber = phoneNumber;
            Address = address;
            CustomerID= "CUST" + CustomerId;
        }
    }
}
