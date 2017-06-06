using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int largerOfFirstAndSecond = BiggerOfFirstAndSecond(first, second);
            int largerOfOneAndThird = BiggerOfOneAndThird(largerOfFirstAndSecond, third);

            Console.WriteLine(largerOfOneAndThird);
        }

        static int BiggerOfFirstAndSecond(int a, int b)
        {
            return Math.Max(a, b);
        }

        static int BiggerOfOneAndThird(int one, int c)
        {
            return Math.Max(one, c);
        }
    }
}