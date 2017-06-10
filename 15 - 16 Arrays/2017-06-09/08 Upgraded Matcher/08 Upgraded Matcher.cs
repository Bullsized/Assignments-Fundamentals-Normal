using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            long[] quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //If in the quantities array there is no index, which 
            //corresponds to the name, you should assume the quantity is 0.
            decimal[] price = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            string[] inputName = Console.ReadLine().Split();

            while (inputName[0] != "done")
            {
                long qtityToOrder = long.Parse(inputName[1]);

                for (int cycle = 0; cycle < names.Length; cycle++)
                {
                    if (inputName[0] == names[cycle])
                    {
                        if (cycle < quantity.Length && quantity[cycle] >= qtityToOrder)
                        {
                            Console.WriteLine($"{names[cycle]} x {qtityToOrder} costs {qtityToOrder * price[cycle]:f2}");
                            quantity[cycle] -= qtityToOrder;
                        }
                        else
                        {
                            Console.WriteLine($"We do not have enough {names[cycle]}");
                        }
                    }
                }

                inputName = Console.ReadLine().Split();
            }
        }
    }
}