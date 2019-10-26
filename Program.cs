using System;
using CodingPatterns.Algorithms;
using CodingPatterns.Patterns;

namespace CodingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine("----------------------END PATTERN TESTS----------------------");
        }
    }
}
