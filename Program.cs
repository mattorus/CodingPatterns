using System;
using CodingPatterns.Algorithms;
using CodingPatterns.Patterns;
using CodingPatterns.Data_Structures;
using CodingPatterns.Patterns.TopKElements;

namespace CodingPatterns
{
    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine("----------------------END PATTERN TESTS----------------------");

            //int[] nums = new int[] { 10, 7, 5, 8, 11, 9 };
            //Helpers.PrintArray(nums);
            //Console.WriteLine(GetMaxProfit(nums));

        }

        static int GetMaxProfit(int[] stockPrices)
        {
            int maxPrice = 0, maxProfit = 0;

            if (stockPrices == null || stockPrices.Length < 1)
            {
                return 0;
            }

            maxPrice = stockPrices[stockPrices.Length - 1];
            
            for (int i = stockPrices.Length - 2; i >= 0; i--)
            {
                maxProfit = Math.Max(maxProfit, maxPrice - stockPrices[i]);
                maxPrice = Math.Max(maxPrice, stockPrices[i]);
            }

            return maxProfit;
        }
    }
}
