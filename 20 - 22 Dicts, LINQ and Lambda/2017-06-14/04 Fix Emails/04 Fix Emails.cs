using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailDict = new Dictionary<string, string>();

            string nameAndMail = Console.ReadLine();

            string remember = string.Empty;

            int oddOrEven = 1;

            while (nameAndMail != "stop")
            {
                if (oddOrEven % 2 == 0) // even
                {
                    emailDict[remember] = nameAndMail;
                }
                else // odd
                {
                    emailDict[nameAndMail] = string.Empty;
                    remember = nameAndMail;
                }

                oddOrEven++;
                nameAndMail = Console.ReadLine();
            }

            foreach (var kvp in emailDict)
            {
                if (!kvp.Value.Contains(".us") && !kvp.Value.Contains(".uk"))
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}