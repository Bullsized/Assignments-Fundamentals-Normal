using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Average_Grades
{
    public class Program
    {
        static void Main(string[] args)
        {
            int rotation = int.Parse(Console.ReadLine());

            //Dictionary<List<string>, decimal> solution = new Dictionary<List<string>, decimal>();
            List<Students> answer = new List<Students>();


            for (int cycle1 = 0; cycle1 < rotation; cycle1++)
            {
                string[] inputStudent = Console.ReadLine().Split();

                var currentStudent = new Students()
                {
                    Name = inputStudent[0],
                    Grades = new List<decimal>()
                };

                for (int cycle2 = 1; cycle2 < inputStudent.Length; cycle2++)
                {
                    currentStudent.Grades.Add(decimal.Parse(inputStudent[cycle2]));
                }

                answer.Add(currentStudent);
            }

            var realAnswer = answer.Where(x => x.Average >= 5.0m)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.Average)
                .ToList();


            foreach (var kvp in realAnswer)
            {
                Console.WriteLine($"{kvp.Name} -> {kvp.Average:f2}");
            }

        }
    }

    public class Students
    {
        public string Name { get; set; }
        public List<decimal> Grades { get; set; }
        public decimal Average
        {
            get
            {
                return Grades.Average();
            }
        }

    }
}