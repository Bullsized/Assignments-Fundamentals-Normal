using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Nums_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string answer = new string(input.ToCharArray().Reverse().ToArray());

            Console.WriteLine(answer);
        }
    }
}