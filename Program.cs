

namespace MobileNumberValidation
{
    class UC4
    {
        static void Main(string[] args)
        {
            string mobileNumber;

            do
            {
                Console.Write("Enter a valid mobile number: ");
                mobileNumber = Console.ReadLine();
            } while (!IsValidMobileNumber(mobileNumber));

            Console.WriteLine("Valid mobile number entered: " + mobileNumber);
        }

        static bool IsValidMobileNumber(string mobileNumber)
        {
            // Remove any spaces and non-numeric characters
            string cleanNumber = new string(mobileNumber.Where(char.IsDigit).ToArray());

            // Check if the cleaned number has exactly 10 digits
            if (cleanNumber.Length != 10)
            {
                Console.WriteLine("Invalid mobile number format.");
                return false;
            }

            // Check if the country code is 91
            string countryCode = cleanNumber.Substring(0, 2);
            if (countryCode != "91")
            {
                Console.WriteLine("Invalid country code.");
                return false;
            }

            Console.WriteLine("Country code: " + countryCode);

            // Extract and display the mobile number part
            string mobilePart = cleanNumber.Substring(2);
            Console.WriteLine("Mobile number: " + mobilePart);

            return true;
        }
    }
}