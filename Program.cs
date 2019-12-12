using System;
using CodingPatterns.Algorithms;
using CodingPatterns.Patterns;
using CodingPatterns.DataStructures;
using CodingPatterns.Patterns.TopKElements;

namespace CodingPatterns
{
    class Program
    {
        static void OldMain(string[] args)
        {
            Console.WriteLine("----------------------START HEAP TESTS----------------------");

            HeapTest.RunTests();

            Console.WriteLine("----------------------END HEAP TESTS----------------------");
            Console.WriteLine("----------------------START ALGORITHM TESTS----------------------");
            
            SelectionSort.RunTests();
            InsertionSort.RunTests();
            Factorial.RunTests();
            Palindrome.RunTests();
            Recursion.RunTests();
            MergeSort.RunTests();
            QuickSort.RunTests();
            BreadthFirstSearch.RunTests();
            
            Console.WriteLine("----------------------END ALGORITHM TESTS----------------------");
            Console.WriteLine("----------------------START PATTERN TESTS----------------------");
                        
            BFS.RunTests();
            DFS.RunTests();
            SlidingWindow.RunTests();
            TwoPointers.RunTests();

            FastSlowPointers.RunTests();
            MergeIntervals.RunTests();
            CyclicSort.RunTests();
            InPlaceLinkedListReversal.RunTests();
            TwoHeaps.RunTests();
            Subsets.RunTests();
            ModifiedBinarySearch.RunTests();
            ElementsTopK.RunTests();
            DP.RunTests();

            Console.WriteLine("----------------------END PATTERN TESTS----------------------");
        }
    }
}
