namespace InvoiceManagementSystem.Models
{
    public class Product:BaseEntity
    {

        public string ProductID;
        public string ProductName;
        public string ProductDescription;
        public int ProductPrice;
        public float ProductDiscount;
        public string CategoryID;
        public float ProductTax;
        public Product(string productName, string productDescription, int productPrice, float productDiscount, float productTax, string categoryID) {
            ProductID = "PROD" + ProductId;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductPrice = productPrice;
            ProductDiscount = productDiscount;
            CategoryID = categoryID;
            ProductTax = productTax;


        }
        public Product() { }
    }
}
