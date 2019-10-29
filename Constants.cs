using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns
{
    class Constants
    {
        public static Comparison<int> CompareInt = (x, y) => x.CompareTo(y);
        public static Comparison<int[]> CompareCoordX = (x, y) => x[0].CompareTo(y[0]);
        public static Comparison<int[]> CompareCoordY = (x, y) => x[1].CompareTo(y[1]);

    }
}
