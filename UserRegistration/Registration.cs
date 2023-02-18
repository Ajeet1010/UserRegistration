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
        // UC2- Checking Validation for user's last name
        const string Last_Name = "^[A-Z]{1}[a-z]{2,}$";
        public void FirstName()
        {
            Console.Write("Enter the user's first name:  ");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, Last_Name))
                Console.WriteLine("User's Last Name - " + input);
            else
                Console.WriteLine("Name should contain atleast three characters");
        }
    }
}
