using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Patterns
{
    class CyclicSort
    {
        public static void RunTests()
        {
            int[] nums, numsArr;
            List<int> numbers;
            string name;
            string testPattern = "CYCLICSORT";
            Helpers.PrintStartTests(testPattern);

            name = "InPlaceSort";
            Helpers.PrintStartTests(name);
            nums = new int[] { 3, 1, 5, 4, 2 };
            Helpers.PrintArray(nums);
            InPlaceSort(nums);
            Helpers.PrintArray(nums);
            nums = new int[] { 2, 6, 4, 3, 1, 5 };
            Helpers.PrintArray(nums);
            InPlaceSort(nums);
            Helpers.PrintArray(nums);
            nums = new int[] { 1, 5, 6, 4, 3, 2 };
            Helpers.PrintArray(nums);
            InPlaceSort(nums);
            Helpers.PrintArray(nums);

            name = "FindMissingNumber";
            Helpers.PrintStartTests(name);
            nums = new int[] { 4, 0, 3, 1 };
            Helpers.PrintArray(nums);
            Console.WriteLine($"->{FindMissingNumber(nums)}");
            nums = new int[] { 8, 3, 5, 2, 4, 6, 0, 1 };
            Helpers.PrintArray(nums);
            Console.WriteLine($"->{FindMissingNumber(nums)}");
            nums = new int[] { 8, 3, 5, 2, 4, 6, 7, 1 };
            Helpers.PrintArray(nums);
            Console.WriteLine($"->{FindMissingNumber(nums)}");
            nums = new int[] { 7, 3, 5, 2, 4, 6, 8, 1 };
            Helpers.PrintArray(nums);
            Console.WriteLine($"->{FindMissingNumber(nums)}");

            name = "FindAllMissingNums";
            Helpers.PrintStartTests(name);
            nums = new int[] { 2, 3, 1, 8, 2, 3, 5, 1 };
            Helpers.PrintArray(nums);
            numbers = FindAllMissingNums(nums);
            Console.Write("->");
            Helpers.PrintList(numbers);
            nums = new int[] { 2, 4, 1, 2 };
            Helpers.PrintArray(nums);
            numbers = FindAllMissingNums(nums);
            Console.Write("->");
            Helpers.PrintList(numbers);
            nums = new int[] { 2, 3, 2, 1 };
            Helpers.PrintArray(nums);
            numbers = FindAllMissingNums(nums);
            Console.Write("->");
            Helpers.PrintList(numbers);
            nums = new int[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            Helpers.PrintArray(nums);
            numbers = FindAllMissingNums(nums);
            Console.Write("->");
            Helpers.PrintList(numbers);
            nums = new int[] { 1, 1, 1 };
            Helpers.PrintArray(nums);
            numbers = FindAllMissingNums(nums);
            Console.Write("->");
            Helpers.PrintList(numbers);

            name = "FindDuplicateNum";
            Helpers.PrintStartTests(name);
            nums = new int[] { 1, 4, 4, 3, 2 };
            Helpers.PrintArray(nums);
            Console.Write($"  -> {FindDuplicateNum(nums)}\n");
            nums = new int[] { 2, 1, 3, 3, 5, 4 };
            Helpers.PrintArray(nums);
            Console.Write($"  -> {FindDuplicateNum(nums)}\n");
            nums = new int[] { 2, 4, 1, 4, 4 };
            Helpers.PrintArray(nums);
            Console.Write($"  -> {FindDuplicateNum(nums)}\n");
            nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 1 };
            Helpers.PrintArray(nums);
            Console.Write($"  -> {FindDuplicateNum(nums)}\n");
            nums = new int[] { 28, 2, 3, 4, 5, 6, 7, 8, 9, 10, 27, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 1 };
            Helpers.PrintArray(nums);
            Console.Write($"  -> {FindDuplicateNum(nums)}\n");
            nums = new int[] { 28, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 };
            Helpers.PrintArray(nums);
            Console.Write($"  -> {FindDuplicateNum(nums)}\n");
            nums = new int[] { 1, 1, 1, 1, 1, 1, 1, 3, 1, 1, 1, 1, 1 };
            Helpers.PrintArray(nums);
            Console.Write($"  -> {FindDuplicateNum(nums)}\n");
            nums = new int[] { 1, 22, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 };
            Helpers.PrintArray(nums);
            Console.Write($"  -> {FindDuplicateNum(nums)}\n");

            name = "FindAllDuplicateNums";
            Helpers.PrintStartTests(name);
            nums = new int[] { 3, 4, 4, 5, 5 };
            Helpers.PrintArray(nums);
            numbers = FindAllDuplicateNums(nums);
            Console.Write("->");
            Helpers.PrintList(numbers);
            nums = new int[] { 5, 4, 7, 2, 3, 5, 3 };
            Helpers.PrintArray(nums);
            numbers = FindAllDuplicateNums(nums);
            Console.Write("->");
            Helpers.PrintList(numbers);
            nums = new int[] { 5, 4, 5, 2, 5, 5, 3 };
            Helpers.PrintArray(nums);
            numbers = FindAllDuplicateNums(nums);
            Console.Write("->");
            Helpers.PrintList(numbers);
            nums = new int[] { 5, 4, 5, 5, 5, 5, 5 };
            Helpers.PrintArray(nums);
            numbers = FindAllDuplicateNums(nums);
            Console.Write("->");
            Helpers.PrintList(numbers);
            nums = new int[] { 5, 4, 5, 5, 5, 5, 4 };
            Helpers.PrintArray(nums);
            numbers = FindAllDuplicateNums(nums);
            Console.Write("->");
            Helpers.PrintList(numbers);

            name = "FindCorruptPair";
            Helpers.PrintStartTests(name);
            nums = new int[] { 3, 1, 2, 5, 2 };
            Helpers.PrintArray(nums);
            numsArr = FindCorruptPair(nums);
            Console.Write("->");
            Helpers.PrintArray(numsArr);
            nums = new int[] { 3, 1, 2, 3, 6, 4 };
            Helpers.PrintArray(nums);
            numsArr = FindCorruptPair(nums);
            Console.Write("->");
            Helpers.PrintArray(numsArr);
            nums = new int[] { 3, 1, 4, 4 };
            Helpers.PrintArray(nums);
            numsArr = FindCorruptPair(nums);
            Console.Write("->");
            Helpers.PrintArray(numsArr);
            nums = new int[] { 3, 1, 2, 5, 6, 4, 1 };
            Helpers.PrintArray(nums);
            numsArr = FindCorruptPair(nums);
            Console.Write("->");
            Helpers.PrintArray(numsArr);

            name = "SmallestMissingPosNum";
            Helpers.PrintStartTests(name);
            nums = new int[] { -3, 1, 5, 4, 2 };
            Helpers.PrintArray(nums);
            Console.WriteLine($"->{SmallestMissingPosNum(nums)}");
            nums = new int[] { 3, -2, 0, 1, 2 };
            Helpers.PrintArray(nums);
            Console.WriteLine($"->{SmallestMissingPosNum(nums)}");
            nums = new int[] { 3, 2, 5, 1 };
            Helpers.PrintArray(nums);
            Console.WriteLine($"->{SmallestMissingPosNum(nums)}");
            nums = new int[] { 3, 1, -5, 2 };
            Helpers.PrintArray(nums);
            Console.WriteLine($"->{SmallestMissingPosNum(nums)}");


            Helpers.PrintEndTests(testPattern);
        }

        public static int SmallestMissingPosNum(int[] nums)
        {
            int i = 0;

            if (nums == null)
            {
                return -1;
            }

            while (i < nums.Length)
            {
                int j = nums[i] - 1;

                if (nums[i] <= nums.Length && nums[i] > 0 && nums[i] != nums[j])
                {
                    Helpers.Swap(nums, i, j);
                }
                else
                {
                    i++;
                }
            }

            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    return i + 1;
                }
            }

            return nums.Length + 1;
        }

        public static int[] FindCorruptPair(int[] nums)
        {
            int i = 0;

            if (nums == null)
            {
                return null;
            }

            while (i < nums.Length)
            {
                int j = nums[i] - 1;

                if (nums[i] != nums[j])
                {
                    Helpers.Swap(nums, i, j);
                }                    
                else
                {
                    i++;
                }
            }

            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    return new int[] { nums[i], i + 1 };
                }
            }

            return null;
        }

        public static List<int> FindAllDuplicateNums(int[] nums)
        {
            int i = 0;
            List<int> numbers = new List<int>();

            if (nums == null)
            {
                return null;
            }

            while (i < nums.Length)
            {
                int j = nums[i] - 1;
                
                if (nums[i] != nums[j])
                {
                    Helpers.Swap(nums, i, j);
                }                
                else
                {
                    i++;
                }
            }

            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    numbers.Add(nums[i]);
                }
            }

            return numbers;
        }

        public static int FindDuplicateNum(int[] nums)
        {
            int i = 0;

            if (nums == null)
            {
                return -1;            
            }

            while (i < nums.Length)
            {
                // Trick: This additional check allows potential early exit, no need for
                // Additional loop found in FindMissingNumber() & FindAllMissingNums()
                if (nums[i] != i + 1)
                {
                    int j = nums[i] - 1;
                    if (nums[i] != nums[j])
                    {
                        Helpers.Swap(nums, i, j);
                    }
                    else
                    {
                        return nums[i];
                    }
                }
                else
                {
                    i++;
                }
            }

            return -1;
        }

        public static List<int> FindAllMissingNums(int[] nums)
        {
            int i = 0;
            List<int> missingNums = new List<int>();

            if (nums == null)
            {
                return null;
            }

            while (i < nums.Length)
            {
                int j = nums[i] - 1;

                // nums[i] != num[j] also handles duplicates, very slick!
                if (nums[i] != nums[j])
                {
                    Helpers.Swap(nums, i, j);
                }
                else
                {
                    i++;
                }
            }

            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    missingNums.Add(i + 1);
                }
            }

            return missingNums;
        }

        public static int FindMissingNumber(int[] nums)
        {
            int i = 0;
            if (nums == null)
            {
                return -1;
            }

            while (i < nums.Length)
            {
                // Trick: nums[i] < nums.Length
                if (nums[i] < nums.Length && nums[i] != nums[nums[i]])
                {
                    Helpers.Swap(nums, nums[i], i);
                }
                else
                {
                    i++;
                }
            }

            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                {
                    return i;
                }
            }

            return nums.Length;
        }

        public static void InPlaceSort(int[] nums)
        {
            int i = 0;

            if (nums == null)
            {
                return;
            }

            while (i < nums.Length)
            {
                int j = nums[i] - 1;
                if (nums[i] != nums[j])
                {
                    Helpers.Swap(nums, i, j);
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
