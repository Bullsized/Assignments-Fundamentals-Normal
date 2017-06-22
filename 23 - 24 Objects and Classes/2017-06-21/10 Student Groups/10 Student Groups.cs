using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _10_Student_Groups
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> townsFilled = new List<Town>(); 

            string inputLine = Console.ReadLine();

            //input lines
            while (inputLine != "End")
            {
                List<string> inputArray = inputLine.Split().ToList();

                if (inputArray.Contains("=>"))
                {
                    List<string> input = Regex.Split(inputLine, @"\s=>\s").ToList();

                    Town workingTown = new Town()
                    {
                        NameOfTown = input[0],
                        SeatsCount = int.Parse(Regex.Match(input[1], @"\d+").Value),
                        Students = new List<Student>()
                    };
                    townsFilled.Add(workingTown);
                }
                else
                {
                    List<string> workingInputArray = inputLine
                        .Trim()
                        .Split(new char[] { '|', ' ' },
                        StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    Student workingStudents = new Student()
                    {
                        Name = workingInputArray[0] + " " + workingInputArray[1],
                        Email = workingInputArray[2].Trim(),
                        RegistrationDate = DateTime.ParseExact(workingInputArray[3], "d-MMM-yyyy",
                        CultureInfo.InvariantCulture)
                    };
                    townsFilled.LastOrDefault().Students.Add(workingStudents); //yeah. that was all me. duh.
                }
                inputLine = Console.ReadLine();
            }

            //add to groups
            List<Group> groups = new List<Group>();

            foreach (var town in townsFilled.OrderBy(x => x.NameOfTown))
            {
                IEnumerable<Student> studs = town.Students //which was all my idea, also.
                    .OrderBy(x => x.RegistrationDate)
                    .ThenBy(z => z.Name)
                    .ThenBy(y => y.Email);

                while (studs.Any()) //pfffff
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = studs.Take(group.Town.SeatsCount).ToList();
                    studs = studs.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }

            //print
            int townsCount = groups.Select(x => x.Town).Distinct().Count();

            Console.WriteLine($"Created {groups.Count} groups in {townsCount} towns:");

            foreach (var group in groups.OrderBy(x => x.Town.NameOfTown))
            {
                Console.Write($"{group.Town.NameOfTown} => ");

                Console.WriteLine($"{string.Join(", ", group.Students.Select(x => x.Email))}");
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Town
    {
        public string NameOfTown { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
}