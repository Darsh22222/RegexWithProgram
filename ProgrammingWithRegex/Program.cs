namespace ProgrammingWithRegex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Program with Regex Statements");
            Console.WriteLine("Select Below Mention Options");
            bool choice = true;
            while (choice)
            {
                Console.WriteLine("1. Check Pattern to validate Postal Code\n2.check pattern alphabet befor postal code\n3. Restrict postal Code at ending" +
                    "\n4.Postal Code With Space\n5.EmailValidation\n6.Email Validate Second part\n7.Validate Email All Part\n8. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                PostalCode code = new PostalCode();
                Email email = new Email();
                switch (option)
                {
                    case 1:
                        
                        code.TestPinCode1("400088");
                        break;
                    case 2:
                        code.TestPinCode2("A400088");
                        break;
                    case 3:
                        code.TestPinCode3("40008A");
                        break;
                    case 4:
                        code.TestPinCode4("400 088");
                        break;
                    case 5:
                        email.EmailPartFirst();
                        break;
                    case 6:
                        email.EmailPartSecond();
                        break;
                    case 7:
                        email.EmailPartThird();
                        break;
                    default:
                        choice = false;
                        Console.WriteLine("Try Again");
                        break;
                }
            }
        }
    }
}