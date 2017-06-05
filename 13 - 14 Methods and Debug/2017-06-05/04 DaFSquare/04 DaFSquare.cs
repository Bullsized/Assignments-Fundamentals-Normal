using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DaFSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            TopAndBottomLine(digit);
            MiddlePart(digit);
            TopAndBottomLine(digit);
        }

        private static void TopAndBottomLine(int digit)
        {
            Console.WriteLine(new string('-', 2 * digit));
        }

        private static void MiddlePart(int digit)
        {
            for (int cycle = 0; cycle < digit - 2; cycle++)
            {
                Console.WriteLine("-" + string.Concat(Enumerable.Repeat("\\/", digit - 1)) + "-");  
            }
        }
    }
}