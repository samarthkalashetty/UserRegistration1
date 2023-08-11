namespace LastNameValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string lastName;

            do
            {
                Console.Write("Enter a valid last name: ");
                lastName = Console.ReadLine();
            } while (!IsValidLastName(lastName));

            Console.WriteLine("Valid last name entered: " + lastName);
        }

        static bool IsValidLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName) || lastName.Length < 3)
            {
                Console.WriteLine("Last name should have a minimum of 3 characters.");
                return false;
            }

            if (!char.IsUpper(lastName[0]))
            {
                Console.WriteLine("Last name should start with a capital letter.");
                return false;
            }

            return true;
        }
    }
}




