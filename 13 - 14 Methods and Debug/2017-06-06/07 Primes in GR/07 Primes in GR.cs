using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Primes_in_GR
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            List<int> solution = new List<int>();

            PrimeDiapason(start, end, solution);

            Console.WriteLine(string.Join(", ", solution));
        }

        private static void PrimeDiapason(int start, int end, List<int> solution)
        {
            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                if (i < 2) isPrime = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    solution.Add(i);
                }
            }
        }
    }
}