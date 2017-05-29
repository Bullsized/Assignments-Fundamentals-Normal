using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());

            int counter = 0;
            bool lamp = false;


            for (int first = m; first >= n; first--)
            {
                for (int second = m; second >= n; second--)
                {
                    counter++;
                    if (first + second == digit)
                    {
                        Console.WriteLine($"Number found! {first} + {second} = {digit}");
                        lamp = true;
                        break;
                    }
                }
                if (lamp) break;
            }
            if (!lamp)
            {
                Console.WriteLine($"{counter} combinations - neither equals {digit}");
            }
        }
    }
}