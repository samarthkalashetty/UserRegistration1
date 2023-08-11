using System;
using System.Linq;

namespace PasswordValidation
{
    class UC5678
    {
        static void Main(string[] args)
        {
            string password;

            do
            {
                Console.Write("Enter a valid password: ");
                password = Console.ReadLine();
            } while (!IsValidPassword(password));

            Console.WriteLine("Valid password entered.");
        }

        static bool IsValidPassword(string password)
        {
           
            if (password.Length < 8)
            {
                Console.WriteLine("Password should have a minimum of 8 characters.");
                return false;
            }

            
            if (!password.Any(char.IsUpper))
            {
                Console.WriteLine("Password should have at least 1 uppercase letter.");
                return false;
            }

            
            if (!password.Any(char.IsDigit))
            {
                Console.WriteLine("Password should have at least 1 numeric digit.");
                return false;
            }

           
            if (password.Count(char.IsPunctuation) != 1)
            {
                Console.WriteLine("Password should have exactly 1 special character.");
                return false;
            }

            return true;
        }
    }
}


