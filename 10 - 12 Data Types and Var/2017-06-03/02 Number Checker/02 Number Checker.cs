using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());

            if (input % 1 != 0)
            {
                Console.WriteLine("floating-point");
            }
            else
            {
                Console.WriteLine("integer");
            }
        }
    }
}