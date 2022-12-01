using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgrammingWithRegex
{
    internal class PostalCode
    {
        const string PIN_CODE_PATTERN = "^[0-9]{6}$";
        const string PIN_CODE_PATTERN2 = "^[0-9]{6}$";
        const string PIN_CODE_PATTERN3 = "^[0-9]{6}$";
        const string PIN_CODE_PATTERN4 = "^[0-9]{3}[ ]{1}[0-9]{3}$";


        public void TestPinCode1(string input)
        {
            if (Regex.IsMatch(input, PIN_CODE_PATTERN))
                Console.WriteLine("Regex is matched");
            else
                Console.WriteLine("Regex doesnot match");
        }
        public void TestPinCode2(string input)
        {
            if (Regex.IsMatch(input, PIN_CODE_PATTERN2))
                Console.WriteLine("Regex is matched");
            else
                Console.WriteLine("Regex doesnot match");
        }
        public void TestPinCode3(string input)
        {
            if (Regex.IsMatch(input, PIN_CODE_PATTERN3))
                Console.WriteLine("Regex is matched");
            else
                Console.WriteLine("Regex doesnot match");
        }
        public void TestPinCode4(string input)
        {
            if (Regex.IsMatch(input, PIN_CODE_PATTERN4))
                Console.WriteLine("Regex is matched");
            else
                Console.WriteLine("Regex doesnot match");
        }
    }
}
