using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int cycle = 1; cycle <= n; cycle++)
            {
                int newCycle = cycle;
                while (newCycle != 0)
                {
                    sum += newCycle % 10;
                    newCycle /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{cycle} - > True");
                }
                else
                {
                    Console.WriteLine($"{cycle} - > False");
                }
                sum = 0;
            }
        }
    }
}