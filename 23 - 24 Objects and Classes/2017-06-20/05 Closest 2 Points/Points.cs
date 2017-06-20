using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Closest_2_Points
{
    public class Points
    {
        public int coordinateX { get; set; }

        public int coordinateY { get; set; }

        public string Print()
        {
            return $"({coordinateX}, {coordinateY})";
        }
    }
}
