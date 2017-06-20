using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Closest_2_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPoints = int.Parse(Console.ReadLine());

            var pointsList = new List<Points>(); //new list of points to collect all of them

            for (int cycle = 0; cycle < countOfPoints; cycle++) //cycle to add the points to the list
            {
                int[] xAndY = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var currentPoint = new Points();
                currentPoint.coordinateX = xAndY[0];
                currentPoint.coordinateY = xAndY[1];
                pointsList.Add(currentPoint);                              
            }

            double minimumDistance = double.MaxValue; //to store the answers
            Points firstPointResult = null;
            Points secondPointResult = null;

            for (int first = 0; first < pointsList.Count; first++) // 1.1 1.2 1.3 1.4 1.5 and so on
            {
                for (int second = first + 1; second < pointsList.Count; second++) // 2.2 2.3 2.4 3.4 3.5 4.5
                {
                    var firstPoint = pointsList[first];
                    var secondPoint = pointsList[second];
                    var distance = GetTheDistance(firstPoint, secondPoint);

                    if (minimumDistance > distance)
                    {
                        minimumDistance = distance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }

            Console.WriteLine("{0:f3}", minimumDistance);
            Console.WriteLine(firstPointResult.Print()); //use the Points Class Method on the very point itself
            Console.WriteLine(secondPointResult.Print());

        }

        private static double GetTheDistance(Points firstPoint, Points secondPoint) //to calculate the closest distance
        {
            int xDiff = (int)Math.Pow(firstPoint.coordinateX - secondPoint.coordinateX, 2);
            int yDiff = (int)Math.Pow(firstPoint.coordinateY - secondPoint.coordinateY, 2);
            double solutionSqrt = Math.Sqrt(xDiff + yDiff);
            return solutionSqrt;
        }
    }
}