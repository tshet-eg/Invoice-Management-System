using InvoiceManagementSystem.Database;
using InvoiceManagementSystem.Models;
using System.Text.RegularExpressions;

namespace InvoiceManagementSystem.Validations
{
    public class CustomerValidation
    {
        //method to check if a customer exists in the list
        public static bool CheckCustomer(string CustomerID)
        {
            foreach (Customer customerEntry in EntityCollection.CustomerList)
                if (CustomerID == customerEntry.CustomerID)//checks if ID exists in the list
                    return true;
            return false;
        }

        //function to validate email
        public static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        //function to validate phone number
        public static bool ValidatePhone(long phoneNumber)
        {
            return Regex.IsMatch(phoneNumber.ToString(), @"^(?!0)(?!.*(\d)\1{9})\d{10}$");
        }
    }
}
