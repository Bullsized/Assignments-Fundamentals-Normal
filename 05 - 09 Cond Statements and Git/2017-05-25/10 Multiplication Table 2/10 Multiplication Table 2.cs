using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Multiplication_Table_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitOne = int.Parse(Console.ReadLine());
            int digitTwo = int.Parse(Console.ReadLine());

            if (digitTwo > 10)
            {
                Console.WriteLine($"{digitOne} X {digitTwo} = {digitOne * digitTwo}");
            }
            else
            {
                for (int i = digitTwo; i < 11; i++)
                {
                    Console.WriteLine($"{digitOne} X {i} = {digitOne * i}");
                }
            }
        }
    }
}