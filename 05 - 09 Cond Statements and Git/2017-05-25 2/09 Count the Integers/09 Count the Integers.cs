using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string digitOrNot = Console.ReadLine();
            int counter = 0;
            int toBeOrNotToBe = 0;

            bool shakespeare = int.TryParse(digitOrNot, out toBeOrNotToBe);

            while (shakespeare)
            {
                counter++;
                digitOrNot = Console.ReadLine();
                shakespeare = int.TryParse(digitOrNot, out toBeOrNotToBe);
            }
            Console.WriteLine(counter);
        }
    }
}