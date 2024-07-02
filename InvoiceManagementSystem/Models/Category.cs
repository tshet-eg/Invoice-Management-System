namespace InvoiceManagementSystem.Models
{
    public class Category : BaseEntity
    {
        public string CategoryID{get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
        private float _tax;
        public float Tax 
        {
            get 
            { 
                return _tax;
            }
            set
            {
                if (value >= 0)
                {
                    _tax = value;
                }
                else
                    throw new System.Exception("Invalid tax!!");
            }
        }

        public Category(string name, string description, float tax) 
        {
            Name = name;
            Description = description;
            Tax = tax;
            CategoryID = "CAT" + CategoryId;
        }
    }
}
