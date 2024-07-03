using System;

namespace InvoiceManagementSystem
{
    public abstract class BaseEntity
    {
        private static int _customerId = 0;
        private static int _categoryId = 0;
        private static int _productId = 0;
        private static int _cartId = 0;
        private int _invoiceId=11000;

        protected int CustomerId {
            get { return ++_customerId; }
        }
        protected int CategoryId {
            get { return ++_categoryId; }
        }
        protected  int ProductId {
            get { return ++_productId; }
        }
        protected int CartId {
            get { return ++_cartId; }
        }
        protected int InvoiceID {
            get {
                return ++_invoiceId;
            }
        }
    }
}
