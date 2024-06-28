using System.Text.RegularExpressions;

namespace InvoiceManagementSystem.Validations
{
    public class Customer
    {
        public bool ValidateEmail(string email) {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        public bool ValidatePhone(long phoneNumber) {
            return Regex.IsMatch(phoneNumber.ToString(), @"^(?!0)(?!.*(\d)\1{9})\d{10}$");
        }
    }
}
