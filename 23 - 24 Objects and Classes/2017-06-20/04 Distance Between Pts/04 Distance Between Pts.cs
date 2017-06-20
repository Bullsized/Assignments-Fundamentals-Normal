using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Distance_Between_Pts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputPoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //create Point.cs Class

            var firstPoint = new Point(); //first you create NEW class object
            firstPoint.coordinateX = inputPoint[0]; //then you apply values to it
            firstPoint.coordinateY = inputPoint[1];

            inputPoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondPoint = new Point
            {
                coordinateX = inputPoint[0],
                coordinateY = inputPoint[1]
            }; //another input method for filling up a class

            double solutionSqrt = GetTheDistance(firstPoint, secondPoint);

            Console.WriteLine("{0:f3}", solutionSqrt);
        }

        private static double GetTheDistance(Point firstPoint, Point secondPoint)
        {
            int xDiff = (int)Math.Pow(firstPoint.coordinateX - secondPoint.coordinateX, 2);
            int yDiff = (int)Math.Pow(firstPoint.coordinateY - secondPoint.coordinateY, 2);
            double solutionSqrt = Math.Sqrt(xDiff + yDiff);
            return solutionSqrt;
        }
    }
}