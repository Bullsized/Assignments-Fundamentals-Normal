using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Search_For_a_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lineOfDigits = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> lineOfCommands = Console.ReadLine().Split().Select(int.Parse).ToList();

            int takeThisMuchDigits = lineOfCommands[0];

            int removeThisMuchDigits = lineOfCommands[1];

            int checkThisOut = lineOfCommands[2];

            lineOfDigits.Take(takeThisMuchDigits);
            lineOfDigits.RemoveRange(0, removeThisMuchDigits);

            if (lineOfDigits.Contains(checkThisOut))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}