using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01_Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var date1 = ExtractDate();
            var date2 = ExtractDate();

            int workingDays = 0;

            DateTime[] nonWorkingDays = new DateTime[]
                {
                new DateTime(2000,01,01),
                new DateTime(2000,03,03),
                new DateTime(2000,05,01),
                new DateTime(2000,05,06),
                new DateTime(2000,05,24),
                new DateTime(2000,09,06),
                new DateTime(2000,09,22),
                new DateTime(2000,11,01),
                new DateTime(2000,12,24),
                new DateTime(2000,12,25),
                new DateTime(2000,12,26)
            };

            for (DateTime cycle = date1; cycle <= date2; cycle = cycle.AddDays(1))
            {
                DateTime holiday = new DateTime(2000, cycle.Month, cycle.Day);
                if (cycle.DayOfWeek != DayOfWeek.Saturday 
                    && cycle.DayOfWeek != DayOfWeek.Sunday 
                    && !nonWorkingDays.Contains(holiday))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }

        static DateTime ExtractDate()
        {
            int[] firstDate = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
            return new DateTime(firstDate[2], firstDate[1], firstDate[0]);
        }
    }
}