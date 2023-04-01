using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{    
    internal class Registartion
    {
        // UC1- Check validation for USER's FIRST NAME.
        const string FIRST_NAME = "^[A-Z]{1}[a-z]{1,}$";
        public static void FirstName()
        {
            Console.Write("Enter the user's first name:  ");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, FIRST_NAME))
                Console.WriteLine("User's First Name - " + input);
            else
                Console.WriteLine("First letter should be capital");
        }

        // UC2- Check validation for USER's LAST NAME.
        const string LAST_NAME = "^[A-Z]{1}[a-z]{1,}$";
        public static void LastName()
        {
            Console.Write("Enter the user's last name:  ");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, LAST_NAME))
                Console.WriteLine("User's Last Name - " + input);
            else
                Console.WriteLine("First letter should be capital");
        }

        // UC3- Check validation for USER's VALID EMAIL ID.
        //E.g. - Email has 3 mandatory parts (abc, bl& co) and 2 optional(xyz & in) withprecise @ and.positions
        const string Email_Id = "^[A-Z]?[a-z]{1,}[.]?[a-z]*[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}[.]?[a-z]*$";
        public static void Email()
        {
            Console.Write("Email-id should be like: \n---->  abc.xyz @bl.co.in or abc@bl.co  <----\nEnter the user's e-mail id:  ");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, Email_Id))
                Console.WriteLine("\nUser's mail id - " + input);
            else
                Console.WriteLine("Email-id should be like as given above");
        }
    }
}
