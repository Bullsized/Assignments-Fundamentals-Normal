using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01_Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string toRegex = @"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]+([-.]\w*)*(\.[a-z]+)";

            var regexShmegex = new Regex(toRegex);

            string textToMatch = Console.ReadLine();

            var contains = regexShmegex.Matches(textToMatch);

            foreach (Match mail in contains)
            {
                Console.WriteLine(mail);
            }
        }
    }
}