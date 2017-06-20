using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Rect_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstRect = new Rectangle_Params();
            var secondRect = new Rectangle_Params();

            CreateTheRectangles(firstRect);
            CreateTheRectangles(secondRect);
            FindRightAndBottom(firstRect);
            FindRightAndBottom(secondRect);

            bool isInside = false;
            if (firstRect.left <= secondRect.left)
            {
                isInside = true;
            }
            if (firstRect.right >= secondRect.right)
            {
                isInside = true;
            }
            if (firstRect.top <= secondRect.top)
            {
                isInside = true;
            }
            if (firstRect.bottom >= secondRect.bottom)
            {
                isInside = true;
            }

            Console.WriteLine("{0}", isInside ? "Inside" : "Not inside");

        }

        private static void FindRightAndBottom(Rectangle_Params RectangleCreator)
        {
            RectangleCreator.right = RectangleCreator.left + RectangleCreator.width;
            RectangleCreator.bottom = RectangleCreator.height + RectangleCreator.top;
        }

        private static void CreateTheRectangles(Rectangle_Params RectangleCreator)
        {
            int[] inputValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            RectangleCreator.top = inputValues[0];
            RectangleCreator.left = inputValues[1];
            RectangleCreator.width = inputValues[2];
            RectangleCreator.height = inputValues[3];
        }
    }
}