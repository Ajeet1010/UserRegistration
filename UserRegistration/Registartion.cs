using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    // UC3- Check validation for USER's VALID EMAIL ID.
    internal class Registartion
    {
        //E.g. - Email has 3 mandatory parts (abc, bl& co) and 2 optional(xyz & in) withprecise @ and.positions
        const string Email_Id = "^[A-Z]?[a-z]{1,}[.]?[a-z]*[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}[.]?[a-z]*$";
        public void Email()
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
