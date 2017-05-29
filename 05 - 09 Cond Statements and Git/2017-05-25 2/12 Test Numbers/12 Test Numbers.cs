using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());
            int answer = 0;
            int counter = 0;
            bool lamp = false;

            for (int s = n; s >= 1; s--)
            {
                for (int e = 1; e <= m; e++)
                {
                    counter++;
                    answer += 3 * (s * e);
                    if (answer >= limit)
                    {
                        Console.WriteLine($"{counter} combinations\nSum: {answer} >= {limit}");
                        lamp = true;
                        break;
                    }
                }
                if (lamp) break;
            }
            if (!lamp)
            {
                Console.WriteLine($"{counter} combinations\nSum: {answer}");
            }
        }
    }
}