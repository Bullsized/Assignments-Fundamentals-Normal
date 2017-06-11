using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Remove_Negatives_and_R
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int cycle = 0; cycle < listOfDigits.Count; cycle++)
            {
                if (listOfDigits[cycle] < 0)
                {
                    listOfDigits.RemoveAt(cycle);
                    cycle--;
                }
            }

            listOfDigits.Reverse();

            if (listOfDigits.Count > 0)
            {
                Console.WriteLine(string.Join(" ", listOfDigits));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}