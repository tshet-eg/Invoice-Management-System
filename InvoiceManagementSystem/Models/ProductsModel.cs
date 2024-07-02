using InvoiceManagementSystem.Models;
namespace InvoiceManagementSystem.Models
{
    public class ProductsModel:BaseEntity
    {

        public string ProductID;
        public string ProductName;
        public string ProductDescription;
        public int ProductPrice;
        public double ProductDiscount;
        public string CategoryID;
        public float ProductTax;
        public ProductsModel(string productName, string productDescription, int productPrice, double productDiscount, float productTax, string categoryID) {
            ProductID = "PROD" + ProductId;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductPrice = productPrice;
            ProductDiscount = productDiscount;
            CategoryID = categoryID;
            ProductTax = productTax;


        }
        public ProductsModel() { }
    }
}
