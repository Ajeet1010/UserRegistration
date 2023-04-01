using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    // UC7 - Password contains atleast 8 characters and also 1 numeric no.
    internal class Registartion
    {
        const string Password_Rule2 = "^[A-Z,a-z,0-9]{8,}[0-9]+$";
        public void Password()
        {
            Console.Write("User's password contains atleast 8 characters and 1 numeric no: ");
            string password2 = Console.ReadLine();
            if (Regex.IsMatch(password2, Password_Rule2))
                Console.WriteLine("\nUser's password is: " + password2);
            else
                Console.WriteLine("Choose your password as describes above");
        }
    }
}
