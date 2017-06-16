using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lineOfTimes = Console.ReadLine().Split().ToList();

            lineOfTimes.Sort();

            Console.WriteLine(string.Join(", ", lineOfTimes));
        }
    }
}