using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inv_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            long[] quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            string inputProduct = Console.ReadLine();

            while (inputProduct != "done")
            {
                for (int cycle1 = 0; cycle1 < names.Length; cycle1++)
                {
                    if (inputProduct == names[cycle1])
                    {
                        Console.WriteLine($"{names[cycle1]} costs: {price[cycle1]}; Available quantity: {quantity[cycle1]}");
                        break;
                    }
                }

                inputProduct = Console.ReadLine();
            }
        }
    }
}