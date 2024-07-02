using System;

namespace InvoiceManagementSystem
{
    public abstract class BaseEntity
    {
        private int _customerId=0;
        private static int _categoryId=0;
        private int _productId=0;
        private int _cartId=0;
        private string _uniqueId;

        protected int CustomerId {
            get { return ++_customerId; }
        }
        protected int CategoryId {
            get { return ++_categoryId; }
        }
        protected int ProductId {
            get { return ++_productId; }
        }
        protected int CartId {
            get { return ++_cartId; }
        }
        protected string UniqueId {
            get { 
                Guid uniqueId = Guid.NewGuid();
                return uniqueId.ToString();
            }
        }
    }
}
