using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Math_Pow
{
    class Program
    {
        static void Main(string[] args)
        {
            double digit = double.Parse(Console.ReadLine());
            double powered = double.Parse(Console.ReadLine());

            GetThePow(digit, powered);
        }

        private static void GetThePow(double digit, double powered)
        {
            Console.WriteLine(Math.Pow(digit, powered));
        }
    }
}