using CodingPatterns.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingPatterns.Patterns.TopKElements
{
    public class ElementsTopK
    {
        public static void RunTests()
        {
            Point[] points;
            int[] nums;
            List<int> retVal;
            int k, x;
            string name;
            string testPattern = "ELEMENTSTOPK";
            Helpers.PrintStartTests(testPattern);

            name = "LargestNumbersK";
            Helpers.PrintStartFunctionTest(name);
            nums = new int[] { 3, 1, 5, 12, 2, 11 };
            k = 3;
            Helpers.PrintArray(nums);
            retVal = LargestNumbersK(nums, k);
            Helpers.PrintList(retVal);
            nums = new int[] { 3, 1, 5, 12, 2, 11 };
            k = 4;
            Helpers.PrintArray(nums);
            retVal = LargestNumbersK(nums, k);
            Helpers.PrintList(retVal);
            nums = new int[] { 3, 1, 5, 12, 2, 11 };
            k = 5;
            Helpers.PrintArray(nums);
            retVal = LargestNumbersK(nums, k);
            Helpers.PrintList(retVal);
            nums = new int[] { 5, 12, 11, -1, 12 };
            k = 2;
            Helpers.PrintArray(nums);
            retVal = LargestNumbersK(nums, k);
            Helpers.PrintList(retVal);
            nums = new int[] { 5, 12, 11, -1, 12 };
            k = 3;
            Helpers.PrintArray(nums);
            retVal = LargestNumbersK(nums, k);
            Helpers.PrintList(retVal);
            nums = new int[] { 5, 12, 11, -1, 12 };
            k = 4;
            Helpers.PrintArray(nums);
            retVal = LargestNumbersK(nums, k);
            Helpers.PrintList(retVal);

            name = "KthSmallestNumber";
            Helpers.PrintStartFunctionTest(name);
            nums = new int[] { 1, 5, 12, 2, 11, 5 };
            k = 3;
            Helpers.PrintArray(nums);
            Console.WriteLine(KthSmallestNumber(nums, k));
            nums = new int[] { 1, 5, 12, 2, 11, 5 };
            k = 4;
            Helpers.PrintArray(nums);
            Console.WriteLine(KthSmallestNumber(nums, k));
            nums = new int[] { 5, 12, 11, -1, 12 };
            k = 3;
            Helpers.PrintArray(nums);
            Console.WriteLine(KthSmallestNumber(nums, k));
            nums = new int[] { 5, 12, 11, -1, 12 };
            k = 2;
            Helpers.PrintArray(nums);
            Console.WriteLine(KthSmallestNumber(nums, k));
            nums = new int[] { 5, 12, 11, -1, 12 };
            k = 1;
            Helpers.PrintArray(nums);
            Console.WriteLine(KthSmallestNumber(nums, k));

            name = "ClosestPointsToOriginK";
            Helpers.PrintStartFunctionTest(name);
            points = new Point[] { new Point(1, 2), new Point(1, 3) };
            k = 1;
            Helpers.PrintList(ClosestKPointsToOrigin(points, k));
            points = new Point[] { new Point(1, 3), new Point(3, 4), new Point(2, -1) };
            k = 2;
            Helpers.PrintList(ClosestKPointsToOrigin(points, k));
            k = 1;
            Helpers.PrintList(ClosestKPointsToOrigin(points, k));

            name = "ConnectRopes";
            Helpers.PrintStartFunctionTest(name);
            nums = new int[] { 1, 3, 11, 5 };
            Helpers.PrintArray(nums);
            Console.WriteLine(ConnectRopes(nums));
            nums = new int[] { 3, 4, 5, 6 };
            Helpers.PrintArray(nums);
            Console.WriteLine(ConnectRopes(nums));
            nums = new int[] { 1, 3, 11, 5, 2 };
            Helpers.PrintArray(nums);
            Console.WriteLine(ConnectRopes(nums));
            nums = new int[] { 1, 13, 33, 3, 11, 5, 2, 6 };
            Helpers.PrintArray(nums);
            Console.WriteLine(ConnectRopes(nums));

            name = "FrequentNumbersTopK";
            Helpers.PrintStartFunctionTest(name);
            nums = new int[] { 1, 3, 5, 12, 11, 12, 11 };
            k = 2;
            Helpers.PrintArray(nums);
            Helpers.PrintList(TopKFrequentNumbers(nums, k));
            nums = new int[] { 5, 11, 3, 11, 12 };
            k = 2;
            Helpers.PrintArray(nums);
            Helpers.PrintList(TopKFrequentNumbers(nums, k));

            name = "KthLargestNumberInStream.Add";
            Helpers.PrintStartFunctionTest(name);
            nums = new int[] { 3, 1, 5, 12, 2, 11 };
            k = 4;
            KthLargestNumberInStream kthLargestNumber = new KthLargestNumberInStream(nums, k);
            Console.WriteLine(kthLargestNumber.Add(6));
            Console.WriteLine(kthLargestNumber.Add(13));
            Console.WriteLine(kthLargestNumber.Add(4));

            name = "FindKClosestNumbers";
            Helpers.PrintStartFunctionTest(name);
            nums = new int[] { 5, 6, 7, 8, 9 };
            x = 7;
            k = 3;
            Helpers.PrintArray(nums);
            Helpers.PrintList(FindKClosestNumbers(nums, x, k));
            nums = new int[] { 2, 4, 5, 6, 9 };
            x = 6;
            k = 3;
            Helpers.PrintArray(nums);
            Helpers.PrintList(FindKClosestNumbers(nums, x, k));
            nums = new int[] { 2, 4, 5, 6, 9 };
            x = 10;
            k = 3;
            Helpers.PrintArray(nums);
            Helpers.PrintList(FindKClosestNumbers(nums, x, k));
            nums = new int[] { 2, 44 };
            x = 10;
            k = 3;
            Helpers.PrintArray(nums);
            Helpers.PrintList(FindKClosestNumbers(nums, x, k));

        }

        static List<int> FindKClosestNumbers(int[] nums, int x, int k)
        {
            MinHeap<(int diff, int num)> heap = new MinHeap<(int diff, int num)>((a, b) => a.diff.CompareTo(b.diff));
            List<int> list = new List<int>();
            int xIndex = BinarySearch(nums, x);
            int left = Math.Max(xIndex - k, 0);
            int right = Math.Min(xIndex + k, nums.Length - 1);
            
            for (int i = left; i <= right; i++)
            {
                heap.Add((Math.Abs(nums[i] - x), nums[i]));
            }

            for (int i = 0; i < k && heap.Count > 0; i++)
            {
                list.Add(heap.Remove().num);
            }

            list.Sort();

            return list;
        }

        static int BinarySearch(int[] nums, int x)
        {
            int start = 0, mid = 0, end = 1;

            if (nums == null || nums.Length < 1)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }

            while (start < end)
            {
                mid = start + (end - start) / 2;

                if (nums[mid] > x)
                {
                    end = mid - 1;
                }
                else if (nums[mid] < x)
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return start;
        }

        static List<int> TopKFrequentNumbers(int[] nums, int k)
        {
            List<int> topNums = new List<int>();
            Dictionary<int, int> numCounts = new Dictionary<int, int>();
            MinHeap<KeyValuePair<int, int>> heap = new MinHeap<KeyValuePair<int, int>>((a, b) => a.Value.CompareTo(b.Value));

            if (nums == null || nums.Length < 1 || k < 1)
            {
                return topNums;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!numCounts.ContainsKey(nums[i]))
                {
                    numCounts[nums[i]] = 0;
                }

                numCounts[nums[i]]++;
            }

            foreach (KeyValuePair<int, int> kv in numCounts)
            {
                if (k > 0)
                {
                    heap.Add(kv);
                    k--;
                }
                else
                {
                    if (kv.Value > heap.Peek().Value)
                    {
                        heap.Remove();
                        heap.Add(kv);
                    }
                }
            }

            while (heap.Count > 0)
            {
                topNums.Add(heap.Remove().Key);
            }

            return topNums;
        }

        static int ConnectRopes(int[] nums)
        {
            MinHeap<int> heap = new MinHeap<int>(Constants.CompareInt);
            int totalCost = 0;

            if (nums == null || nums.Length < 2)
            {
                return 0;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                heap.Add(nums[i]);
            }

            while (heap.Count > 1)
            {
                var curCost = heap.Remove() + heap.Remove();
                totalCost += curCost;
                heap.Add(curCost);
            }

            return totalCost;
        }

        static List<Point> ClosestKPointsToOrigin(Point[] points, int k)
        {
            List<Point> closestPoints = new List<Point>();
            MaxHeap<Point> heap = new MaxHeap<Point>((a, b) => a.X.CompareTo(b.X));
            Point origin = new Point(0, 0);

            if (points == null || points.Length < 1 || k < 1)
            {
                return null;
            }

            if (k >= points.Length)
            {
                return new List<Point>(points);
            }

            for (int i = 0; i < k; i++)
            {
                heap.Add(points[i]);
            }

            for (int i = k; i < points.Length; i++)
            {
                if (Point.EuclideanDistance(origin, points[i]) < Point.EuclideanDistance(origin, heap.Peek()))
                {
                    heap.Remove();
                    heap.Add(points[i]);
                }
            }

            Console.WriteLine($"heap: {heap}");

            while (heap.Count > 0)
            {
                closestPoints.Add(heap.Remove());
            }

            return closestPoints;
        }

        static int KthSmallestNumber(int[] nums, int k)
        {
            MaxHeap<int> heap = new MaxHeap<int>(Constants.CompareInt);

            if (nums == null || nums.Length < 1 || k < 1)
            {
                return -1;
            }

            for (int i = 0; i < k; i++)
            {
                heap.Add(nums[i]);
            }

            for (int i = k; i < nums.Length; i++)
            {
                if (nums[i] < heap.Peek())
                {
                    heap.Remove();
                    heap.Add(nums[i]);
                }
            }

            return heap.Peek();
        }

        static List<int> LargestNumbersK(int[] nums, int k)
        {
            List<int> numSet = new List<int>();
            MinHeap<int> heap = new MinHeap<int>(Constants.CompareInt);

            if (nums == null)
            {
                return numSet;
            }

            for (int i = 0; i < k; i++)
            {
                heap.Add(nums[i]);
            }

            for (int i = k; i < nums.Length; i++)
            {
                if (nums[i] > heap.Peek())
                {
                    heap.Remove();
                    heap.Add(nums[i]);
                }
            }

            for (int i = 0; i < k; i++)
            {
                numSet.Add(heap.Remove());
            }

            return numSet;
        }
    }
}
