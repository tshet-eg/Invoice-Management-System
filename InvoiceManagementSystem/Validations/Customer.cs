using InvoiceManagementSystem.Database;
using System.Text.RegularExpressions;

namespace InvoiceManagementSystem.Validations
{
    public class Customer
    {
        public static  bool CheckCustomer(string CustomerID)
        {
            foreach (Models.Customer customerEntry in DBEntity.CustomerList)
                if (CustomerID == customerEntry.CustomerID)
               return true;
            return false;
        }
        public static bool ValidateEmail(string email) {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        public static bool ValidatePhone(long phoneNumber) {
            return Regex.IsMatch(phoneNumber.ToString(), @"^(?!0)(?!.*(\d)\1{9})\d{10}$");
        }
    }
}
