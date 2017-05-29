using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Choose_a_Drink_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int qtity = int.Parse(Console.ReadLine());

            if (profession == "Athlete")
            {
                Console.WriteLine("The Athlete has to pay {0:f2}.", qtity * 0.7);
            }
            else if (profession == "Businessman")
            {
                Console.WriteLine("The Businessman has to pay {0:f2}.", qtity * 1);
            }
            else if (profession == "Businesswoman")
            {
                Console.WriteLine("The Businesswoman has to pay {0:f2}.", qtity * 1);
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine("The SoftUni Student has to pay {0:f2}.", qtity * 1.7);
            }
            else
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, qtity * 1.2);
            }
        }
    }
}