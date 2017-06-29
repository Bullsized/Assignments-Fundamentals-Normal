using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string toReverse = Console.ReadLine();
            var reversedCharArray = toReverse.ToCharArray().Reverse();
            Console.WriteLine(string.Join("", reversedCharArray));
        }
    }
}