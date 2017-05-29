using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dividedByTwo = n / 2;
            // small x
            int minusTwo = n - 2;
            int zero = 0;

            for (int top = 0; top < dividedByTwo; top++)
            {
                Console.Write(new string(' ', zero));
                Console.Write("x");
                Console.Write(new string(' ', minusTwo));
                Console.Write("x");
                Console.WriteLine(new string(' ', zero));

                zero++;
                minusTwo -= 2;
            }

            Console.WriteLine("{0}x", new string(' ', zero));

            int emptySpace = 1;
            zero--;

            for (int bottom = 0; bottom < dividedByTwo; bottom++)
            {
                Console.Write(new string(' ', zero));
                Console.Write("x");
                Console.Write(new string(' ', emptySpace));
                Console.Write("x");
                Console.WriteLine(new string(' ', zero));
                zero--;
                emptySpace += 2;
            }
        }
    }
}