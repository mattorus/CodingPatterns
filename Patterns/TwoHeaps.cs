using CodingPatterns.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Patterns
{
    class TwoHeaps
    {
        public static void RunTests()
        {
            int[] nums;
            int k;
            string name;
            string testPattern = "TWOHEAPS";
            NumberStream testMedian;
            Helpers.PrintStartTests(testPattern);

            name = "NumberStreamMedian";
            Helpers.PrintStartFunctionTest(name);
            testMedian = new NumberStream();
            testMedian.InsertNum(3);
            Console.WriteLine($"Left: {testMedian.Left.ToString()}");
            Console.WriteLine($"Right: {testMedian.Right.ToString()}");
            testMedian.InsertNum(1);
            Console.WriteLine($"Left: {testMedian.Left.ToString()}");
            Console.WriteLine($"Right: {testMedian.Right.ToString()}");
            Console.WriteLine($"Median: {testMedian.FindMedian()}");
            testMedian.InsertNum(5);
            Console.WriteLine($"Left: {testMedian.Left.ToString()}");
            Console.WriteLine($"Right: {testMedian.Right.ToString()}");
            Console.WriteLine($"Median: {testMedian.FindMedian()}");
            testMedian.InsertNum(4);
            Console.WriteLine($"Left: {testMedian.Left.ToString()}");
            Console.WriteLine($"Right: {testMedian.Right.ToString()}");
            Console.WriteLine($"Median: {testMedian.FindMedian()}");
            testMedian.InsertNum(5);
            Console.WriteLine($"Left: {testMedian.Left.ToString()}");
            Console.WriteLine($"Right: {testMedian.Right.ToString()}");
            Console.WriteLine($"Median: {testMedian.FindMedian()}");
            testMedian.InsertNum(5);
            Console.WriteLine($"Left: {testMedian.Left.ToString()}");
            Console.WriteLine($"Right: {testMedian.Right.ToString()}");
            Console.WriteLine($"Median: {testMedian.FindMedian()}");
            testMedian.InsertNum(5);
            Console.WriteLine($"Left: {testMedian.Left.ToString()}");
            Console.WriteLine($"Right: {testMedian.Right.ToString()}");
            Console.WriteLine($"Median: {testMedian.FindMedian()}");
            testMedian.InsertNum(5);
            Console.WriteLine($"Left: {testMedian.Left.ToString()}");
            Console.WriteLine($"Right: {testMedian.Right.ToString()}");
            Console.WriteLine($"Median: {testMedian.FindMedian()}");
            testMedian.InsertNum(5);
            Console.WriteLine($"Left: {testMedian.Left.ToString()}");
            Console.WriteLine($"Right: {testMedian.Right.ToString()}");
            Console.WriteLine($"Median: {testMedian.FindMedian()}");
            testMedian.InsertNum(1);
            Console.WriteLine($"Left: {testMedian.Left.ToString()}");
            Console.WriteLine($"Right: {testMedian.Right.ToString()}");
            Console.WriteLine($"Median: {testMedian.FindMedian()}");
            testMedian.InsertNum(2);
            Console.WriteLine($"Left: {testMedian.Left.ToString()}");
            Console.WriteLine($"Right: {testMedian.Right.ToString()}");
            Console.WriteLine($"Median: {testMedian.FindMedian()}");
            testMedian.InsertNum(1);
            Console.WriteLine($"Left: {testMedian.Left.ToString()}");
            Console.WriteLine($"Right: {testMedian.Right.ToString()}");
            Console.WriteLine($"Median: {testMedian.FindMedian()}");
            testMedian.InsertNum(1);
            Console.WriteLine($"Left: {testMedian.Left.ToString()}");
            Console.WriteLine($"Right: {testMedian.Right.ToString()}");
            Console.WriteLine($"Median: {testMedian.FindMedian()}");
            testMedian.InsertNum(1);
            Console.WriteLine($"Left: {testMedian.Left.ToString()}");
            Console.WriteLine($"Right: {testMedian.Right.ToString()}");
            Console.WriteLine($"Median: {testMedian.FindMedian()}");
            testMedian.InsertNum(1);
            Console.WriteLine($"Left: {testMedian.Left.ToString()}");
            Console.WriteLine($"Right: {testMedian.Right.ToString()}");
            Console.WriteLine($"Median: {testMedian.FindMedian()}");

            name = "NumberStreamMedian";
            Helpers.PrintStartFunctionTest(name);
            nums = new int[] { 1, 2, -1, 3, 5 };
            k = 2;
            Helpers.PrintArray(nums);
            Console.Write("->");
            Helpers.PrintArray<double>(MedianOfKSubarrays(nums, k));
            nums = new int[] { 1, 2, -1, 3, 5 };
            k = 3;
            Helpers.PrintArray(nums);
            Console.Write("->");
            Helpers.PrintArray<double>(MedianOfKSubarrays(nums, k));
            nums = new int[] { 1, 5, -1, 3, 5, 13, 4, 23, 1, 5, 2, 6, 8, 2 };
            k = 3;
            Helpers.PrintArray(nums);
            Console.Write("->");
            Helpers.PrintArray<double>(MedianOfKSubarrays(nums, k));
            nums = new int[] { 1, 5, -1, 3, 5, 13, 4, 23, 1, 5, 2, 6, 8, 2 };
            k = 8;
            Helpers.PrintArray(nums);
            Console.Write("->");
            Helpers.PrintArray<double>(MedianOfKSubarrays(nums, k));



            Helpers.PrintEndTests(testPattern);
        }

        public static double[] MedianOfKSubarrays(int[] nums, int k)
        {
            NumberStream numStream = new NumberStream();
            List<double> medians = new List<double>();

            if (nums == null || k < 1)
            {
                return null;
            }

            for (int i = 0; i + k - 1 < nums.Length; i++)
            {
                for (int j = i; j < nums.Length && j < i + k; j++)
                {
                    numStream.InsertNum(nums[j]);
                }

                medians.Add(numStream.FindMedian());
                numStream = new NumberStream();
            }

            return medians.ToArray();
        }

        public class NumberStream
        {
            public MaxHeap<int> Left { get; set; }
            public MinHeap<int> Right { get; set; }

            public NumberStream()
            {
                Left = new MaxHeap<int> (Constants.CompareInt);
                Right = new MinHeap<int> (Constants.CompareInt);

            }

            public void InsertNum(int num)
            {
                // Insert based on current median, or if heaps are empty.
                if (Left.Count == 0 || num <= FindMedian())
                {
                    Left.Add(num);
                }
                else
                {
                    Right.Add(num);
                }

                BalanceHeaps();
            }

            public double FindMedian()
            {
                if (Left.Count > Right.Count)
                {
                    return Left.Peek();
                }
                else
                {
                    return (Left.Peek() + Right.Peek()) / 2d;
                }
            }

            private void BalanceHeaps()
            {
                while (Left.Count < Right.Count)
                {
                    Left.Add(Right.Remove());
                }

                while (Right.Count < Left.Count - 1)
                {
                    Right.Add(Left.Remove());
                }
            }
        }
    }
}
