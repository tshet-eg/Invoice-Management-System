namespace InvoiceManagementSystem.Models
{
    public class ProductsModel:BaseEntity
    {
        public string  ProductID ="PROD"+ProductId;
        public string ProductName;
        public string ProductDescription;
        public int ProductPrice;
        public double ProductDiscount;
        public Category ProductCategoryID;
    }
}
