using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Practice_IN
{
    class Program
    {
        static void Main(string[] args)
        {

            //-100
            //128
            //- 3540
            //64876
            //2 147 483 648
            //- 1 141 583 228
            //- 1 223 372 036 854 775 808

            sbyte idioticTaskOne = sbyte.Parse(Console.ReadLine());
            byte idioticTaskTwo = byte.Parse(Console.ReadLine());
            short idioticTaskThree = short.Parse(Console.ReadLine());
            ushort idioticTaskFour = ushort.Parse(Console.ReadLine());
            uint idioticTaskFive = uint.Parse(Console.ReadLine());
            int idioticTaskSix = int.Parse(Console.ReadLine());
            long idioticTaskSeven = long.Parse(Console.ReadLine());

            Console.WriteLine($"{idioticTaskOne}\n{idioticTaskTwo}\n{idioticTaskThree}\n{idioticTaskFour}\n{idioticTaskFive}\n{idioticTaskSix}\n{idioticTaskSeven}");

        }
    }
}