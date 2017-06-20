using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateToBeParsed = Console.ReadLine();

            var dateAsADay = new DateTime();

            dateAsADay = DateTime.ParseExact(dateToBeParsed, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(dateAsADay.DayOfWeek);
        }
    }
}