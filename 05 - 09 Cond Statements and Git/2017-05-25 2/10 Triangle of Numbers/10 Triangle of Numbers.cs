using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            for (int i = 1; i <= limit; i++)
            {
                for (int m = 1; m <= i ; m++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}