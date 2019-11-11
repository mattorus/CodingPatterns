using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Data_Structures
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int EuclideanDistance(Point p)
        {
            return (int)Math.Sqrt(Math.Pow((p.X - X), 2) + Math.Pow((p.Y - Y), 2));
        }

        public static int EuclideanDistance(Point from, Point to)
        {
            return (int)Math.Sqrt(Math.Pow((to.X - from.X), 2) + Math.Pow((to.Y - from.Y), 2));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"[{X}, {Y}]");

            return sb.ToString();
        }
    }
}
