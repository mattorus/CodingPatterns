using System;
using CodingPatterns.Sorts;

namespace CodingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------EXECUTING TESTS----------------------");
            Pattern_DepthFirstSearch.RunTests();
            Pattern_SelectionSort.RunTests();
        }
    }
}
