using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitOne = int.Parse(Console.ReadLine());
            int digitTwo = int.Parse(Console.ReadLine());
            int digitThree = int.Parse(Console.ReadLine());
            int digitFour = int.Parse(Console.ReadLine());

            Console.WriteLine($"{digitOne:d4} {digitTwo:d4} {digitThree:d4} {digitFour:d4}");

        }
    }
}