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
        const string FIRST_NAME = "^[A-Z]{1}[a-z]{1,}$";
        const string LAST_NAME = "^[A-Z]{1}[a-z]{1,}$";
        const string Mobile_No = "^[0-9]{2,}[ ]{1}[0-9]{10}$";
        const string Password_Rule = "^[A-Z,a-z,0-9]{8,}$";
        const string Password_Rule1 = "^[A-Z]+[A-Z,a-z,0-9]{8,}[A-Z]*[a-z,0-9]*$";
        const string Password_Rule2 = "^[A-Z,a-z,0-9]{8,}[0-9]+$";

        // UC1- Check validation for USER's FIRST NAME.
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

        // UC4- Check user entered correct mobile no.
        public static void Contact()
        {
            Console.Write("User's mobile no followed by country code: ");
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, Mobile_No))
                Console.WriteLine("\nUser's conatct no is: " + input);
            else
                Console.WriteLine("No should be entered correctly");
        }

        // UC5 - Password contains atleast 8 characters.
        public static void Password()
        {
            Console.Write("User's password contains atleast 8 characters: ");
            string password = Console.ReadLine();
            if (Regex.IsMatch(password, Password_Rule))
                Console.WriteLine("\nUser's password is: " + password);
            else
                Console.WriteLine("Choose your password as describes above");
        }


        // UC6 - Password contains atleast 8 characters and also 1 UPPER CASE LETTER.
        public static void PasswordUPPER()
        {
            Console.Write("User's password contains atleast 8 characters and 1 UPPER CASE: ");
            string password1 = Console.ReadLine();
            if (Regex.IsMatch(password1, Password_Rule1))
                Console.WriteLine("\nUser's password is: " + password1);
            else
                Console.WriteLine("Choose your password as describes above");
        }

        // UC7 - Password contains atleast 8 characters and also 1 numeric no.
        public static void PasswordNUMERIC()
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
