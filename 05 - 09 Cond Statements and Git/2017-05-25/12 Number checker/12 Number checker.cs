using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Number_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            string tryDigit = Console.ReadLine();
            int trueDigit = 0;

            bool sherlockHolmes = int.TryParse(tryDigit, out trueDigit);

            if (sherlockHolmes)
            {
                Console.WriteLine("It is a number.");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}