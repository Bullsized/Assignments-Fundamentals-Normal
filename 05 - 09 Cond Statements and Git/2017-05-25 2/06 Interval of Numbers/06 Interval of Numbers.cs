using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());

            int smaller = Math.Min(firstDigit, secondDigit);
            int bigger = Math.Max(firstDigit, secondDigit);

            for (int i = smaller; i <= bigger; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}