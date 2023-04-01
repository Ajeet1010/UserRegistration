using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    // UC6 - Password contains atleast 8 characters and also 1 UPPER CASE LETTER.
    internal class Registartion
    {
        const string Password_Rule1 = "^[A-Z]+[A-Z,a-z,0-9]{8,}[A-Z]*[a-z,0-9]*$";
        public void Password()
        {
            Console.Write("User's password contains atleast 8 characters and 1 UPPER CASE: ");
            string password1 = Console.ReadLine();
            if (Regex.IsMatch(password1, Password_Rule1))
                Console.WriteLine("\nUser's password is: " + password1);
            else
                Console.WriteLine("Choose your password as describes above");
        }
    }
}
