using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Water_Overflow_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            byte currentQuantity = 0;

            for (byte i = 0; i < n; i++)
            {
                short input = short.Parse(Console.ReadLine());

                if (currentQuantity + input > byte.MaxValue)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                currentQuantity += (byte)input;
            }

            Console.WriteLine(currentQuantity);
        }
    }
}