using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_String_C
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string answer = string.Empty;

            for (int cycle = 1; cycle <= n; cycle++)
            {
                string parsed = Console.ReadLine();
                if (cycle % 2 == 0 && evenOrOdd == "even")
                {
                    if (cycle == n - 1)
                    {
                        answer += parsed;
                    }
                    else
                    {
                        answer += parsed;
                        answer += delimiter;

                    }
                }

                if (cycle % 2 != 0 && evenOrOdd == "odd")
                {
                    if (cycle == n - 1)
                    {
                        answer += parsed;
                    }
                    else
                    {
                        answer += parsed;
                        answer += delimiter;

                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}