using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int howManyRows = int.Parse(Console.ReadLine());
            int counter = 0;
            int digits = 1;

            for (int cycle = 0; cycle < howManyRows; cycle++)
            {
                Console.WriteLine(digits);
                counter += digits;
                digits += 2;
            }
            Console.WriteLine("Sum: {0}", counter);
        }
    }
}