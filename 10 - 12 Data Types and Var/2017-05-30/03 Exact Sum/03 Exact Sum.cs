using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Exact_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int digits = int.Parse(Console.ReadLine());
            decimal answer = 0;
            for (int cycle = 0; cycle < digits; cycle++)
            {
                decimal nextDigit = decimal.Parse(Console.ReadLine());
                answer += nextDigit;
            }

            Console.WriteLine(answer);
        }
    }
}