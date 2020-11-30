using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityStudy
{
    public class StandardMessages
    {

        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my app!");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You didn't enter valid {fieldName} name.");
        }
    }
}
