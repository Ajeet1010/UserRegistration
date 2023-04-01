using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    // UC4 - Mobile no followed by country code.
    internal class Registartion
    {

        const string Mobile_No = "^[0-9]{2,}[ ]{1}[0-9]{10}$";
        public void Contact()
        {
            Console.Write("User's mobile no followed by country code: ");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, Mobile_No))
                Console.WriteLine("\nUser's conatct no is: " + input);
            else
                Console.WriteLine("No should be entered correctly");
        }
    }
}
