using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01_Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime leaveTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            BigInteger steps = BigInteger.Parse(Console.ReadLine());
            BigInteger seconds = BigInteger.Parse(Console.ReadLine());

            BigInteger stepsBySeconds = steps * seconds;

            DateTime arrivalTime = leaveTime.AddSeconds((double)stepsBySeconds);

            Console.WriteLine("Time Arrival: {0:d2}:{1:d2}:{2:d2}", 
               arrivalTime.Hour, arrivalTime.Minute, arrivalTime.Second);

            //Console.WriteLine("Time Arrival: {0}", arrivalTime.ToString("HH:mm:ss"));







            //2nd solution:
            //var timeOfLeaving = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            //var steps = int.Parse(Console.ReadLine());
            //var secondsPerStep = int.Parse(Console.ReadLine());
            //ulong secondsToAdd = (ulong)steps * (ulong)secondsPerStep;
            //long initialSeconds = (timeOfLeaving.Hour * 60 * 60) + (timeOfLeaving.Minute * 60) + timeOfLeaving.Second;
            //ulong totalSeconds = (ulong)initialSeconds + secondsToAdd;
            //var seconds = totalSeconds % 60;
            //var totalMinutes = totalSeconds / 60;
            //var minutes = totalMinutes % 60;
            //var totalHours = totalMinutes / 60;
            //var hours = totalHours % 24;

            //Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}