using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Form");

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Mobile Number: ");
            string mobile = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (UserValidator.IsValidFirstName(firstName) &&
                UserValidator.IsValidLastName(lastName) &&
                UserValidator.IsValidEmail(email) &&
                UserValidator.IsValidMobileNumber(mobile) &&
                UserValidator.IsValidPassword(password))
            {
                Console.WriteLine("Registration Successful!");
            }
            else
            {
                Console.WriteLine("Registration Failed. Please check your details.");
            }
        }
    }

    public static class UserValidator
    {
        public static Func<string, bool> IsValidFirstName = firstName =>
            !string.IsNullOrWhiteSpace(firstName) && firstName.Length >= 3;

        public static Func<string, bool> IsValidLastName = lastName =>
            !string.IsNullOrWhiteSpace(lastName) && lastName.Length >= 3;

        public static Func<string, bool> IsValidEmail = email =>
        {
            
            return true;
        };

        public static Func<string, bool> IsValidMobileNumber = mobile =>
        {
            return true;
        };

        public static Func<string, bool> IsValidPassword = password =>
        {
            
            return true;
        };
    }
}
