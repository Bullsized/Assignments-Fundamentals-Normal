using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            PrintingMethod(digit);
        }

        public static void PrintingMethod(int digit)
        {
            for (int cycle1 = 1; cycle1 <= digit; cycle1++)
            {
                for (int cycle2 = 1; cycle2 <= cycle1; cycle2++)
                {
                    Console.Write(cycle2 + " ");
                }
                Console.WriteLine();
            }
            for (int cycle3 = digit - 1; cycle3 > 0; cycle3--)
            {
                for (int cycle4 = 1; cycle4 <= cycle3; cycle4++)
                {
                    Console.Write(cycle4 + " ");
                }
                Console.WriteLine();
            }
        }
    }
}