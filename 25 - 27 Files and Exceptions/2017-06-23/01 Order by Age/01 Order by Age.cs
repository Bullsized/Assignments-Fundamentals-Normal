using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                string[] tokens = inputLine.Split();

                string nameOfTheStudent = tokens[0];
                string idOfTheStudent = tokens[1];
                int ageOfTheStudent = int.Parse(tokens[2]);

                var newStudent = new Student()
                {
                    Name = nameOfTheStudent,
                    Id = idOfTheStudent,
                    Age = ageOfTheStudent
                };

                students.Add(newStudent);

                inputLine = Console.ReadLine();
            }

            foreach (var studentsSorted in students.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{studentsSorted.Name} with ID: {studentsSorted.Id} is {studentsSorted.Age} years old.");
            }

        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}