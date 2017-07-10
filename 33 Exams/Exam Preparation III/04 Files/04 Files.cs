using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _04_Files
{
    class Program
    {
        // 60/100, need to implement better method of adding files and replacing them to the class list
        static void Main(string[] args)
        {
            int rotation = int.Parse(Console.ReadLine());

            List<FileProperties> solution = new List<FileProperties>();

            for (int cycle = 0; cycle < rotation; cycle++)
            {
                string[] inputLine = Console.ReadLine().Split('\\', ';').ToArray();

                FileProperties currentFile = new FileProperties()
                {
                    root = inputLine[0],
                    name = inputLine[inputLine.Length - 2],
                    size = long.Parse(inputLine[inputLine.Length - 1])
                };
                //for (int cycle2 = 1; cycle2 < inputLine.Length - 2; cycle2++)
                //{
                //    currentFile.dir += inputLine[cycle2];
                //}

                //var match = solution.FirstOrDefault(f => f.name == currentFile.name);

                //if (match != null)
                //{
                //    match.size = long.Parse(inputLine[inputLine.Length - 1]);
                //}
                //else
                //{
                    solution.Add(currentFile);
                 // }
            }

            string[] outputLine = Console.ReadLine().Split();

            string dirToLook = outputLine[2];
            string extention = outputLine[0];
            bool lamp = false;
            foreach (var fileAndSize in solution.OrderByDescending(x => x.size).ThenBy(x => x.name))
            {
                if (fileAndSize.root.Contains(dirToLook) && fileAndSize.name.Contains(extention))
                {
                    lamp = true;
                    Console.WriteLine($"{fileAndSize.name} - {fileAndSize.size} KB");
                }
            }

            if (lamp == false)
            {
                Console.WriteLine("No");
            }

        }
    }

    class FileProperties
    {
        public string root { get; set; }
        public string dir { get; set; }
        public string name { get; set; }
        public long size { get; set; }
    }
}