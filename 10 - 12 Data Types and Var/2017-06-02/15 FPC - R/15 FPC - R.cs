using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_FPC___R
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNum = int.Parse(Console.ReadLine());
            for (int cycle = 2; cycle <= givenNum; cycle++)
            {
                bool lamp = true;
                for (int cycle2 = 2; cycle2 <= Math.Sqrt(cycle); cycle2++)
                {
                    if (cycle % cycle2 == 0)
                    {
                        lamp = false;
                        break;
                    }
                }
                Console.WriteLine($"{cycle} -> {lamp}");
            }
        }
    }
}