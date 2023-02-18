using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Registration
    {
        // UC1- Checking Validation for user first name
        const string First_Name = "^[A-Z]{1}[a-z]{2,}$";
        public void FirstName()
        {
            Console.Write("Enter the user's first name:  ");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, First_Name))
                Console.WriteLine("User's First Name - " + input);
            else
                Console.WriteLine("Name should contain atleast three characters");
        }
    }
}
