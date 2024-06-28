namespace InvoiceManagementSystem.Models
{
    public class Cart:BaseEntity
    {
        public readonly string CartID;
        public string CustomerID { get; set; }
        public string ProductID { get; set; }
        public int Quantity { get;set }

        public Cart(string customerID,string productID,int quantity) {
            CartID = "CART" + CartId;
            CustomerID = customerID;
            ProductID = productID;
            Quantity = quantity;
        }
    }
}
