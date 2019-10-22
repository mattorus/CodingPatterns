﻿using System;
using CodingPatterns.Algorithms;

namespace CodingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------EXECUTING TESTS----------------------");
            DepthFirstSearch.RunTests();
            SelectionSort.RunTests();
            InsertionSort.RunTests();
            Factorial.RunTests();
            Palindrome.RunTests();
            Recursion.RunTests();
            MergeSort.RunTests();
            QuickSort.RunTests();

            Console.WriteLine(9 / 2);
            Console.WriteLine(8 / 2);
            Console.WriteLine(Math.Ceiling(1d / 2d));
            Console.WriteLine(Math.Floor(1d / 2d));
        }
    }
}
