using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _08_Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInputLine = Console.ReadLine();

            List<Altogether> nameAndDates = new List<Altogether>();

            while (firstInputLine != "end of dates")
            {
                List<string> firstInput = firstInputLine.Split(' ', ',').ToList();

                List<DateTime> currStudentDates = new List<DateTime>();

                string nameOfThePunk = firstInput[0];

                for (int cycle = 1; cycle < firstInput.Count; cycle++)
                {
                    currStudentDates.Add(DateTime.ParseExact(firstInput[cycle], "dd/MM/yyyy", 
                        CultureInfo.InvariantCulture));
                }

                currStudentDates.Sort();

                if (nameAndDates.Any(st => st.NameOfPerson == nameOfThePunk))
                {
                    foreach (var student in nameAndDates)
                    {
                        if (student.NameOfPerson == nameOfThePunk)
                        {
                            student.Dates.AddRange(currStudentDates);
                        }
                    }
                }
                else
                {
                    Altogether personAndDates = new Altogether();

                    personAndDates.NameOfPerson = nameOfThePunk;

                    personAndDates.Dates = new List<DateTime>();

                    personAndDates.Comments = new List<string>();

                    personAndDates.Dates.AddRange(currStudentDates);

                    personAndDates.Dates.Sort();

                    nameAndDates.Add(personAndDates);
                }
                
                firstInputLine = Console.ReadLine();
            }


            string secondInputLine = Console.ReadLine();

            while (secondInputLine != "end of comments")
            {
                string[] secondInput = secondInputLine.Split('-').ToArray();

                string name = secondInput[0];

                string comment = secondInput[1];

                foreach (var checkname in nameAndDates)
                {
                    if (checkname.NameOfPerson == name)
                    {
                        checkname.Comments.Add(comment);
                    }
                }

                secondInputLine = Console.ReadLine();
            }

            foreach (var user in nameAndDates)
            {
                Console.WriteLine(user.NameOfPerson);
                Console.WriteLine("Comments:");
                foreach (var commentGiven in user.Comments)
                {
                    Console.WriteLine($"- {commentGiven}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var dateAttended in user.Dates)
                {
                    Console.WriteLine($"-- {dateAttended.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }

    class Altogether
    {
        public string NameOfPerson { get; set; }
        public List<DateTime> Dates { get; set; }
        public List<string> Comments { get; set; }
        public object Name { get; internal set; }
    }
}