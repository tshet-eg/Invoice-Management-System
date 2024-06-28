namespace InvoiceManagementSystem.Models
{
    public class Cart:BaseEntity
    {
        public readonly string CartID;
        public string CustomerID { get; set; }
        public string ProductID { get; set; }

        public Cart(string customerID,string productID) {
            CartID = "CART" + CartId;
            CustomerID = customerID;
            ProductID = productID;
        }
    }
}
