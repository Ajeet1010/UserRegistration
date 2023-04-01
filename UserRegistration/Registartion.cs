using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    // UC1- Check validation for USER's FIRST NAME.
    internal class Registartion
    {
        const string FIRST_NAME = "^[A-Z]{1}[a-z]{1,}$";
        public void FirstName()
        {
            Console.Write("Enter the user's first name:  ");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, FIRST_NAME))
                Console.WriteLine("User's First Name - " + input);
            else
                Console.WriteLine("First letter should be capital");
        }
    }
}
