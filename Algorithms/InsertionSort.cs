using System;
using System.Collections.Generic;
using System.Text;
using CodingPatterns;

namespace CodingPatterns.Algorithms
{
    class InsertionSort
    {

        public static void RunTests()
        {
            string testPattern = "PATTERN_INSERTIONSORT";
            Helpers.PrintStartTests(testPattern);

            Console.WriteLine("Insert");
            Console.WriteLine("--------------------------");
            int[] nums = { 2, 3, 5, 7, 11, 13, 9, 6 };
            int value = 9;
            int rightIndex = 5;
            Helpers.PrintArray(nums);
            Insert(nums, rightIndex, value);
            Helpers.PrintArray(nums);
            value = 6;
            rightIndex = 6;
            Insert(nums, rightIndex, value);
            Helpers.PrintArray(nums);

            Console.WriteLine("\nDoSort");
            Console.WriteLine("--------------------------");
            nums = new[] { 2, 3, 5, 7, 11, 6, 9, 13 };
            Helpers.PrintArray(nums);
            DoSort(nums);
            Helpers.PrintArray(nums);


            Helpers.PrintEndTests(testPattern);
        }

        public static void DoSort(int[] nums)
        {
            if (nums == null)
            {
                return;
            }

            for (int i = 1; i < nums.Length; i++)
            {
                Insert(nums, i - 1, nums[i]);
            }
        }

        private static void Insert(int[] nums, int rightIndex, int value)
        {
            int i = 0;
            if (rightIndex == nums.Length - 1)
            {
                // ERROR
                return;
            }

            for (i = rightIndex; i >= 0 && nums[i] > value; i--)
            {
                nums[i + 1] = nums[i];
            }
            
            nums[i + 1] = value;
        }
    }
}
