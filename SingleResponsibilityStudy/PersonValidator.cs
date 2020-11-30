using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityStudy
{
    public class PersonValidator
    {

        public static bool isValid(Person person)
        {
            // Checks to be sure the first and last names are valid


            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayValidationError("First Name");
                return false;
            }          

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidationError("Last Name");
                return false;
            }
            return true;
        }

    }
}
