namespace EmailValidation
{
    namespace EmailValidation
    {
        class Program
        {
            static void Main(string[] args)
            {
                string email;

                do
                {
                    Console.Write("Enter a valid email: ");
                    email = Console.ReadLine();
                } while (!IsValidEmail(email));

                Console.WriteLine("Valid email entered: " + email);
            }

            static bool IsValidEmail(string email)
            {
                // Check if "@" and "." are present in the email
                int atIndex = email.IndexOf('@');
                int dotIndex = email.LastIndexOf('.');

                if (atIndex == -1 || dotIndex == -1 || dotIndex < atIndex)
                {
                    Console.WriteLine("Invalid email format.");
                    return false;
                }

                // Extract the parts of the email
                string[] parts = email.Split('@');
                if (parts.Length != 2)
                {
                    Console.WriteLine("Invalid email format.");
                    return false;
                }

                string beforeAt = parts[0];
                string afterAt = parts[1];

                string[] domainParts = afterAt.Split('.');
                if (domainParts.Length < 2 || domainParts.Length > 3)
                {
                    Console.WriteLine("Invalid email format.");
                    return false;
                }

                string part1 = domainParts[0];
                string part2 = domainParts[1];
                string part3 = domainParts.Length > 2 ? domainParts[2] : "";

                // Check parts
                if (string.IsNullOrWhiteSpace(beforeAt) || string.IsNullOrWhiteSpace(part1) || string.IsNullOrWhiteSpace(part2))
                {
                    Console.WriteLine("Invalid email format.");
                    return false;
                }

                return true;
            }
        }
    }
}

