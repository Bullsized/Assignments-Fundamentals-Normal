using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal miles = decimal.Parse(Console.ReadLine());

            decimal calc = miles * 1.60934m;

            Console.WriteLine($"{calc:f2}");
        }
    }
}