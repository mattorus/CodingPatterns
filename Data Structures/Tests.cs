using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Data_Structures
{
    static class HeapTest
    {
        public static void RunTests()
        {
            MaxHeap<int[]> maxHeap;
            MinHeap<int[]> minHeap;
            MaxHeap<int> maxHeap2;
            MinHeap<int> minHeap2;
            int[] nums;

            maxHeap = new MaxHeap<int[]>((x, y) => x[0].CompareTo(y[0]));
            minHeap = new MinHeap<int[]>((x, y) => x[1].CompareTo(y[1]));
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            nums = new int[] { 4, 5 };
            maxHeap.Add(nums);
            minHeap.Add(nums);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            nums = new int[] { 2, 3 };
            maxHeap.Add(nums);
            minHeap.Add(nums);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            nums = new int[] { 2, 4 };
            maxHeap.Add(nums);
            minHeap.Add(nums);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());
            nums = new int[] { 3, 5 };
            maxHeap.Add(nums);
            minHeap.Add(nums);
            Console.WriteLine(maxHeap.ToString());
            Console.WriteLine(minHeap.ToString());

            maxHeap2 = new MaxHeap<int>((x, y) => x.CompareTo(y));
            minHeap2 = new MinHeap<int>((x, y) => x.CompareTo(y));
            maxHeap2.Add(9);
            minHeap2.Add(9);
            Console.WriteLine(maxHeap2.ToString());
            Console.WriteLine(minHeap2.ToString());
            maxHeap2.Add(4);
            minHeap2.Add(4);
            Console.WriteLine(maxHeap2.ToString());
            Console.WriteLine(minHeap2.ToString());
            maxHeap2.Add(25);
            minHeap2.Add(25);
            Console.WriteLine(maxHeap2.ToString());
            Console.WriteLine(minHeap2.ToString());
            maxHeap2.Add(8);
            minHeap2.Add(8);
            Console.WriteLine(maxHeap2.ToString());
            Console.WriteLine(minHeap2.ToString());
            maxHeap2.Add(6);
            minHeap2.Add(6);
            Console.WriteLine(maxHeap2.ToString());
            Console.WriteLine(minHeap2.ToString());
            maxHeap2.Add(3);
            minHeap2.Add(3);
            Console.WriteLine(maxHeap2.ToString());
            Console.WriteLine(minHeap2.ToString());
            maxHeap2.Add(12);
            minHeap2.Add(12);
            Console.WriteLine(maxHeap2.ToString());
            Console.WriteLine(minHeap2.ToString());
            maxHeap2.Add(7);
            minHeap2.Add(7);
            Console.WriteLine(maxHeap2.ToString());
            Console.WriteLine(minHeap2.ToString());
            maxHeap2.Add(0);
            minHeap2.Add(0);
            Console.WriteLine(maxHeap2.ToString());
            Console.WriteLine(minHeap2.ToString());
        }

    }
}
