using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Last_K_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());  //n
            int second = int.Parse(Console.ReadLine());  //k

            long[] solution = new long[first];
            solution[0] = 1;

            for (int i = 1; i < first; i++)
            {
                long sum = 0;
                for (int j = i - second; j <= i - 1; j++)
                {
                    if (j >= 0)
                    {
                        sum += solution[j];
                    }
                    solution[i] = sum;
                }
            }

            Console.WriteLine(string.Join(" ", solution));
        }
    }
}