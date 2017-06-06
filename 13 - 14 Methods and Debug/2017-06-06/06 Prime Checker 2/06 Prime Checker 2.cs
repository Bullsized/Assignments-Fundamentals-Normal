using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Prime_Checker_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine()); ;
            int counter = (int)Math.Sqrt(n);
            bool isPrime = true;
            if (n > 1)
            {
                for (int cnt = 2; cnt <= counter; cnt++)
                {
                    if (n % cnt == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            else
            {
                isPrime = false;
            }
            if (isPrime) { Console.WriteLine(true); }
            else { Console.WriteLine(false); }
        }
    }
}