using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Valid Name\n");

            string userName = Console.ReadLine();
            
            Regex validName = new Regex(@"^[A-Z]{1}\w{0,30}$");

            if(validName.IsMatch(userName))
            {
                Console.WriteLine("Thank You for the Valid Entry!\n");
            }
            else
            {
                Console.WriteLine("Sorry, the name you entered is not valid\n");
            }

            Console.WriteLine("Please Enter a Valid email\n");

            string userEmail = Console.ReadLine();

            Regex validEmail = new Regex(@"^[0-z]{5,30}\@[0-z]{5,30}\.[0-z]{2,3}$");

            if (validEmail.IsMatch(userEmail))
            {
                Console.WriteLine("Thank You for the Valid Entry!\n");
            }
            else
            {
                Console.WriteLine("Sorry, the email you entered is not valid\n");
            }

            Console.WriteLine("Please Enter a Valid phone number Format: xxx-xxx-xxxx\n");

            string userPhoneNumber = Console.ReadLine();

            Regex validPhoneNumber = new Regex(@"^[0-9]{3}\-[0-9]{3}\-[0-9]{4}$");

            if (validPhoneNumber.IsMatch(userPhoneNumber))
            {
                Console.WriteLine("Thank You for the Valid Entry!\n");
            }
            else
            {
                Console.WriteLine("Sorry, the phone number you entered is not valid\n");
            }

            Console.WriteLine("Please Enter a Valid date (mm/dd/yyyy)\n");

            string userDate = Console.ReadLine();

            Regex validDate = new Regex(@"^(([0][[0-9])|([1][0-2]))\/(([0-2][0-9])|([3][0-2]))\/[0-9]{4}$");

            if (validDate.IsMatch(userDate))
            {
                Console.WriteLine("Thank You for the Valid Entry!\n");
            }
            else
            {
                Console.WriteLine("Sorry, the date you entered is not valid\n");
            }






        }
    }
}
