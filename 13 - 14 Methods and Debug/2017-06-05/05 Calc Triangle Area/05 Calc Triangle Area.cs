using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Calc_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal triangleBase = decimal.Parse(Console.ReadLine());
            decimal triangleHeight = decimal.Parse(Console.ReadLine());

            decimal answer = CalculateArea(triangleBase, triangleHeight);

            Console.WriteLine(answer);
        }

        private static decimal CalculateArea(decimal triangleBase, decimal triangleHeight)
        {
            return triangleBase * triangleHeight / 2;
        }
    }
}