namespace InvoiceManagementSystem.Models
{
    public class Cart : BaseEntity
    {
        public readonly string CartID;
        public string CustomerID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public Cart(string customerID, Product product, int quantity)
        {
            CartID = "CART" + CartId;
            CustomerID = customerID;
            Product = product;
            Quantity = quantity;
        }
    }
}
