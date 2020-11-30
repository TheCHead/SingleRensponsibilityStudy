using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my app!");

            // Ask for user inof
            Person user = new Person();

            Console.Write("What is your first name: ");
            user.FirstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            user.LastName = Console.ReadLine();

            // Checks to be sure the first and last names are valid

            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("You didn't enter valid first name. Please enter again: ");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You didn't enter valid last name. Please enter again: ");
                Console.ReadLine();
                return;
            }

            // Create a username for the person
            Console.WriteLine($"Your username is { user.FirstName.Substring(0, 1) }{ user.LastName }");
            Console.ReadLine();

        }
    }
}
