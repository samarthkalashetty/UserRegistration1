namespace UserRegistration1
{
    internal class UserResgistrationUC1
    {
        class UC1
        {
            public static bool IsValidFirstName(string firstName)
            {
                if (string.IsNullOrEmpty(firstName) || firstName.Length < 3)
                {
                    return false;
                }

                if (!char.IsUpper(firstName[0]))
                {
                    return false;
                }

                for (int i = 1; i < firstName.Length; i++)
                {
                    if (!char.IsLetter(firstName[i]))
                    {
                        return false;
                    }
                }

                return true;
            }

            public static void Main(string[] args)
            {
                Console.Write("Enter your first name: ");
                string firstName = Console.ReadLine();

                if (IsValidFirstName(firstName))
                {
                    Console.WriteLine("Valid first name.");
                }
                else
                {
                    Console.WriteLine("Invalid first name. Make sure it starts with a capital letter and has at least 3 characters.");
                }
            }
        }
    }
}
