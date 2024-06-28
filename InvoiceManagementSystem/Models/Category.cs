namespace InvoiceManagementSystem.Models
{
    public class Category : BaseEntity
    {
        private int _categoryID;
        
        public int CategoryID{ 
            get
            { 
                return _categoryID;
            } 
            set 
            {
                _categoryID = CategoryId;
            }
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public float Tax { get; set; }

    }
}
