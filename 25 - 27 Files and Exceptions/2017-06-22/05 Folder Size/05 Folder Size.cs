using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05_Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are given a folder named “TestFolder”. Get the size of all files in the folder, 
            //which are NOT directories. 
            //The result should be written to another text file in Megabytes.

            // 1.
            // Get array of all file names.
            string[] a = Directory.GetFiles("../TestFolder", " *.txt");

            // 2.
            // Calculate total bytes of all files in a loop.
            long b = 0; //seems like it's better to be double or decimal
            foreach (string name in a)
            {
                // 3.
                // Use FileInfo to get length of each file.
                FileInfo info = new FileInfo(name);
                b += info.Length;
            }
            // 4.
            // Return total size

            //static double ConvertBytesToMegabytes(long bytes)
            //{
            //    return (bytes / 1024f) / 1024f;
            //}
            decimal intoMB = b / 1024m / 1024m;


        }
    }
}