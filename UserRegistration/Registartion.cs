using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    // UC2- Check validation for USER's LAST NAME.
    internal class Registartion
    {
        const string LAST_NAME = "^[A-Z]{1}[a-z]{1,}$";
        public void LastName()
        {
            Console.Write("Enter the user's last name:  ");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, LAST_NAME))
                Console.WriteLine("User's Last Name - " + input);
            else
                Console.WriteLine("First letter should be capital");
        }
    }
}
