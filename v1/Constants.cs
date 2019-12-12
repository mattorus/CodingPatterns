using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns
{
    class Constants
    {
        // Algorithms
        public static bool TestFactorial = true;

        // Data Structures
        public static bool TestHeap = true;

        // Patterns
        public static bool TestBFS = true;
        public static bool TestCyclicSort = true;
        public static bool TestDFS = true;
        public static bool TestDP = true;
        public static bool TestFastSlowPointers = true;
        public static bool TestInPlaceLinkedListReversal = true;
        public static bool TestMergeIntervals = true;
        public static bool TestSlidingWindow = true;
        public static bool TestSubsets = true;
        public static bool TestTwoHeaps = true;
        public static bool TestTwoPointers = true;

        public static Comparison<int> CompareInt = (x, y) => x.CompareTo(y);
        public static Comparison<int[]> CompareCoordX = (x, y) => x[0].CompareTo(y[0]);
        public static Comparison<int[]> CompareCoordY = (x, y) => x[1].CompareTo(y[1]);

    }
}
