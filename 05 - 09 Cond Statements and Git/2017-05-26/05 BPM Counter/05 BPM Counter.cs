using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double beatsPerMinute = double.Parse(Console.ReadLine());
            double beatsCount = double.Parse(Console.ReadLine());

            double time = (beatsCount / beatsPerMinute) * 60;
            double mins = Math.Truncate(time / 60);
            double secs = Math.Truncate(time % 60);

            Console.WriteLine($"{Math.Round(beatsCount / 4, 1)} bars - {mins}m {secs}s");
        }
    }
}