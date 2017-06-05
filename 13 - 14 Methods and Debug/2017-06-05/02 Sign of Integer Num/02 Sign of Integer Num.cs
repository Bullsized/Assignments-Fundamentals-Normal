using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sign_of_Integer_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());

            PrintStatement(digit);
        }

        public static void PrintStatement(int digit)
        {
            if (digit > 0) Console.WriteLine($"The number {digit} is positive.");
            else if (digit < 0) Console.WriteLine($"The number {digit} is negative.");
            else Console.WriteLine($"The number {digit} is zero.");
        }
    }
}