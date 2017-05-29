using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddOrNot = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (oddOrNot % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                    oddOrNot = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("The number is: {0}", Math.Abs(oddOrNot));
                    break;
                }
            }
        }
    }
}