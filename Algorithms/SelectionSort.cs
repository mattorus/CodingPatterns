using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Algorithms
{
    class SelectionSort
    {
        public SelectionSort() { }

        public static void RunTests()
        {
            string testPattern = "SELECTIONSORT";
            Helpers.PrintStartTests(testPattern);
            Console.WriteLine("Testing DoSort()");
            Console.WriteLine("--------------------------");
            int[] nums = { 5, 3, 6, 10, 1, 4 };
            Console.Write($"nums: ");
            Helpers.PrintArray(nums);
            DoSort(nums);
            Console.Write($"nums: ");
            Helpers.PrintArray(nums);

            Helpers.PrintEndTests(testPattern);
        }

        public static void DoSort(int[] nums)
        {
            int i, j, temp, minNum, minIndex;

            if (nums == null)
            {
                return;
            }

            // Loop:
            //  -Start at index i, 
            //  -Find min num[j] > i
            //  -Swap num[i] <-> num[j]
            //  -i++

            for (i = 0; i < nums.Length; i++)
            {
                minIndex = i;
                minNum = nums[i];

                for (j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < minNum)
                    {
                        minIndex = j;
                        minNum = nums[j];
                    }
                }

                temp = nums[i];
                nums[i] = nums[minIndex];
                nums[minIndex] = temp;
            }
        }

    }
}
