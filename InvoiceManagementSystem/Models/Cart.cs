namespace InvoiceManagementSystem.Models
{
    public class Cart : BaseEntity
    {
        public readonly string CartID;
        public string CustomerID { get; set; }
        public ProductsModel Product { get; set; }
        public int Quantity { get; set; }

        public Cart(string customerID, ProductsModel product, int quantity)
        {
            CartID = "CART" + CartId;
            CustomerID = customerID;
            Product = product;
            Quantity = quantity;
        }
    }
}
