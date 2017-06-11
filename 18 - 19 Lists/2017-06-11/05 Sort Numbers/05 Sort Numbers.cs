using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> lineOfDecimals = Console.ReadLine().Split(' ')
                .Select(decimal.Parse)
                .ToList();

            lineOfDecimals.Sort();

            Console.WriteLine(string.Join(" <= ", lineOfDecimals));

        }
    }
}