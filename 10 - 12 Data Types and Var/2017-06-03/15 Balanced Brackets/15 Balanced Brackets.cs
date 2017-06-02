using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotation = int.Parse(Console.ReadLine());
            int countOpen = 0;
            int countClose = 0;
            string doubleOpening = string.Empty;
            bool lamp = false;

            for (int cycle = 0; cycle < rotation; cycle++)
            {
                string bracketsOrNot = Console.ReadLine();
                if (bracketsOrNot == "(")
                {
                    countOpen++;
                }
                else if (bracketsOrNot == ")")
                {
                    countClose++;
                }

                if (bracketsOrNot == doubleOpening && doubleOpening == "(")
                {
                    Console.WriteLine("UNBALANCED");
                    lamp = true;
                    break;
                }
                doubleOpening = bracketsOrNot;
            }
            if (countOpen == countClose && lamp == false)
            {
                Console.WriteLine("BALANCED");
            }
            else if (countOpen != countClose && lamp == false)
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}