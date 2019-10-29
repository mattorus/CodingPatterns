using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Patterns
{
    class TwoHeaps
    {
        public static void RunTests()
        {
            string name;
            string testPattern = "RUNTESTS";
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



            Helpers.PrintEndTests(testPattern);
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
