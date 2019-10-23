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

            Console.WriteLine("----------------------END PATTERN TESTS----------------------");

            Console.WriteLine(9 / 2);
            Console.WriteLine(8 / 2);
            Console.WriteLine(Math.Ceiling(1d / 2d));
            Console.WriteLine(Math.Floor(1d / 2d));
        }
    }
}
