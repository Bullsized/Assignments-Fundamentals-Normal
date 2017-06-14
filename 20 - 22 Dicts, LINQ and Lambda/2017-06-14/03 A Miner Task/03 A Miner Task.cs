using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> jewelery = new Dictionary<string, long>();

            string inputGoodie = Console.ReadLine();

            int oddOrEven = 1;

            string remember = inputGoodie;

            while (inputGoodie != "stop")
            {
                if (oddOrEven % 2 == 0) // even
                {
                    jewelery[remember] += long.Parse(inputGoodie);
                }
                else // odd
                {
                    if (!jewelery.ContainsKey(inputGoodie))
                    {
                        jewelery.Add(inputGoodie, 0);
                    }
                    remember = inputGoodie;
                }

                oddOrEven++;
                inputGoodie = Console.ReadLine();
            }

            foreach (var kvp in jewelery)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}