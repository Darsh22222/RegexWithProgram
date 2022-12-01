namespace ProgrammingWithRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Program with Regex Statements");
            Console.WriteLine("Select Below Mention Options");
            bool choice = true;
            while (choice)
            {
                Console.WriteLine("1. Check Pattern to validate Postal Code\n2.check pattern alphabet befor postal code\n3. Restrict postal Code at Begining" +
                    "\n4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                PostalCode code = new PostalCode();
                switch (option)
                {
                    case 1:
                        
                        code.TestPinCode1("400088");
                        break;
                    case 2:
                        code.TestPinCode1("A400088");
                        break;
                    case 3:
                        code.TestPinCode1("40008A");
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