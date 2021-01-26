using System;
using System.Text.RegularExpressions;
namespace RegexLab
{
    class Program
    {
        static void Main(string[] args)
        {
            VerifyName(GetInput("Please enter your first name:"));
            VerifyEmail(GetInput("Please enter your email:"));
            VerifyPhone(GetInput("Please enter your phone number:"));
            VerifyDate(GetInput("Please enter the date:"));
        }

        //Gets user input string, does not do any validation
        public static string GetInput(string display)
        {
            Console.WriteLine(display);
            string input = Console.ReadLine();
            return input.Trim();
        }

        //Checks for valid name against REGEX string
        public static void VerifyName(string input)
        {
            if (Regex.IsMatch(input, "^[A-Z][a-z]{1,29}$"))
            {
                Console.WriteLine("Valid name!");
            }
            else
            {
                Console.WriteLine("Invalid name!");
            }
        }

        //Checks for valid email agains REGEX string
        public static void VerifyEmail(string input)
        {
            if (Regex.IsMatch(input, "^[0-9A-Za-z]{5,30}@[0-9A-Za-z]{5,10}\\.[0-9A-Za-z]{2,3}$"))
            {
                Console.WriteLine("Valid email!");
            }
            else
            {
                Console.WriteLine("Invalid email!");
            }
        }

        public static void VerifyPhone(string input)
        {
            if (Regex.IsMatch(input, "^[0-9]{3}-[0-9]{3}-[0-9]{4}$"))
            {
                Console.WriteLine("Valid phone number!");
            }
            else
            {
                Console.WriteLine("Invalid phone number!");
            }
        }

        public static void VerifyDate(string input)
        {
            if (Regex.IsMatch(input, "^(0[1-9]|[1-2][0-9]|3[0-1])\\/(0[1-9]|[1-2][0-2])\\/[0-9]{4}$"))
            {
                Console.WriteLine("Valid date!");
            }
            else
            {
                Console.WriteLine("Invalid date!");
            }
        }


    }
}
