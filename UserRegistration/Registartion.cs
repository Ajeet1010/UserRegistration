using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    // UC8 - Password contains atleast 8 characters and 1 special characters.
    internal class Registartion
    {
        const string Password_Rule = "^[A-Z,a-z,0-9]{8,}[!,@,#,%,$,^,&,*,<,>]+$";
        public void Password()
        {
            Console.WriteLine("Special Characters are:  (!,@,#,%,$,^,&,*,<,>) ");
            Console.Write("User's password contains atleast 8 characters and 1 special character: ");
            string password = Console.ReadLine();
            if (Regex.IsMatch(password, Password_Rule))
                Console.WriteLine("\nUser's password is: " + password);
            else
                Console.WriteLine("Choose your password as describes above");
        }
    }
}
