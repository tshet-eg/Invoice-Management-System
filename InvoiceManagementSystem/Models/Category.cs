namespace InvoiceManagementSystem.Models
{
    public class Category : BaseEntity
    {
        private string _categoryID;
        
        public string CategoryID{ 
            get
            { 
                return _categoryID;
            } 
            set 
            {
                _categoryID = "Cat" + CategoryId;
            }
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public float Tax { get; set; }

    }
}
