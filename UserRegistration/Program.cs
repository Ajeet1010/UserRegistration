namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  User Registartion using REGEX pattern");
            Console.Write("1. First Name.\n2. Last Name.\n3. Email-ID.\n4. Contact No.\n5. Password having 8 digits.\n" +
                "6. Password having atleast 1 UPPER CASE.\n7. Password having atleast 1 NUMERIC NO.\n" +
                "8. Password having atleast 1 SPECIAL CHARACTER.\nChoose option to perform:");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your choice is: " + option + "\n");
            switch (option)
            {
                case 1:
                    Registartion.FirstName();
                    break;
                case 2:
                    Registartion.LastName();
                    break;
                case 3:
                    Registartion.Email();
                    break;
                case 4:
                    Registartion.Contact();
                    break; 
                case 5:
                    Registartion.Password();
                    break;
                case 6:
                    Registartion.PasswordUPPER();
                    break;
                case 7:
                    Registartion.PasswordNUMERIC();
                    break;
                case 8:
                    Registartion.PasswordSPECIAL();
                    break;
                default:
                    Console.WriteLine("Enter correct choice: ");
                    break;
            }
        }
    }
}