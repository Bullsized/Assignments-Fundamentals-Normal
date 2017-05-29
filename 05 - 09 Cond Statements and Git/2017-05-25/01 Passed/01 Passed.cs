using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal grade = decimal.Parse(Console.ReadLine());

            if (grade >= 3m)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}