using System;


namespace InvoiceManagementSystem.Models
{
    public class Product:BaseEntity
    {
        private string _productID;
        public string  ProductID {
            set {_productID="PROD"+ ProductId;
            }
            get { return _productID; }
        }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Price { get; set; }
        public Double Discount {  get; set; } 
        public string  ProductCategoryID { get; set; }
    }
}
