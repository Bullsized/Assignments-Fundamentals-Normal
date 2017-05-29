using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Back_in_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            mins += 30;

            if (mins > 59)
            {
                hours++;
                mins -= 60;
            }
            if (hours > 23)
            {
                hours -= 23;
            }

            Console.WriteLine($"{hours}:{mins}");

        }
    }
}