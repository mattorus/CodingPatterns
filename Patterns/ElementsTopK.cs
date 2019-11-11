using System;
using System.Collections.Generic;

namespace CodingPatterns.Patterns
{
    public class ElementsTopK
    {
        public static void RunTests()
        {
            int[] nums;
            List<int> retVal;
            int k;
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

        }

        static List<int> LargestNumbersK(int[] nums, int k)
        {
            List<int> numSet = new List<int>();
            MaxHeap<int> heap = new MaxHeap<int>(Constants.CompareInt);

            if (nums == null)
            {
                return numSet;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Adding {nums[i]} to heap...");
                heap.Add(nums[i]);

            }

            for (int i = k; i > 0; i--)
            {
                numSet.Add(heap.Remove());
            }


            return numSet;
        }
    }
}
