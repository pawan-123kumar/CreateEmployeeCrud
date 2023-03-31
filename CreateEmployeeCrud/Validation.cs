using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CreateEmployeeCrud
{
    public class Validation
    {
        string pattern = @"^[A-Za-z\s]+$";
        string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

        public string checkName(string? name)
        {
            while (!Regex.IsMatch(name ?? "", pattern))
            {
                Console.WriteLine("Invalid string please enter a valid string");
                name = Console.ReadLine();

            }
            return name ?? "";
        }
        public string checkEmail(string? email)
        {
            while (!Regex.IsMatch(email ?? "", emailPattern))
            {
                Console.WriteLine("Invalid EmailAddress Please Provide a valid EmailAddress");
                email = Console.ReadLine();

            }
            return email ?? "";
        }
    }
}
