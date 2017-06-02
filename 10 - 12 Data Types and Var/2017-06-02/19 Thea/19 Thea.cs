using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Thea
{
    class Program
    {
        static void Main(string[] args)
        {
            long picsTaken = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long percentage = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());
            
            long amountFiltered = (long)(Math.Ceiling(picsTaken * percentage / 100d));
            long filterAllPics = picsTaken * filterTime;
            long uploadAllPics = amountFiltered * uploadTime;
            long totalTime = filterAllPics + uploadAllPics;
            
            long seconds = totalTime % 60;
            long minutes = ((totalTime - seconds) / 60) % 60;
            long hours = ((totalTime - seconds - minutes*60) / 60 / 60);
            long days = (totalTime - seconds - (minutes * 60) - (hours * 360)) / 86400;


            Console.WriteLine($"{days:d1}:{hours:d2}:{minutes}:{seconds:d2}");

            //second method with TimeSpan:
            //TimeSpan projectTime = TimeSpan.FromSeconds(totalTime);
            //Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
            //    projectTime.Days,
            //    projectTime.Hours,
            //    projectTime.Minutes,
            //    projectTime.Seconds);
        }
    }
}