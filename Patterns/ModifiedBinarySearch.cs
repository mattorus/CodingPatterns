using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Patterns
{
    public class ArrayReader
    {
        private int[] _arr;

        public ArrayReader(int[] arr)
        {
            this._arr = arr;
        }

        public int Get(int index)
        {
            if (index >= _arr.Length)
            {
                return int.MaxValue;
            }

            return _arr[index];
        }

        public int[] GetArray()
        {
            return _arr;
        }
    }

    class ModifiedBinarySearch
    {
        public static void RunTests()
        {
            ArrayReader reader;
            int[] nums, range;
            int key;
            string name;
            string testPattern = "MODIFIEDBINARYSEARCH";
            Helpers.PrintStartTests(testPattern);

            name = "OrderAgnosticsBinarySearch";
            Helpers.PrintStartFunctionTest(name);
            Console.WriteLine(OrderAgnosticBinarySearch(new int[] { 4, 6, 10 }, 6));
            Console.WriteLine(OrderAgnosticBinarySearch(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 5));
            Console.WriteLine(OrderAgnosticBinarySearch(new int[] { 10, 6, 4 }, 10));
            Console.WriteLine(OrderAgnosticBinarySearch(new int[] { 10, 6, 5, 4 }, 4));
            Console.WriteLine(OrderAgnosticBinarySearch(new int[] { 1 }, 1));
            Console.WriteLine(OrderAgnosticBinarySearch(new int[] { 1 }, 14));

            name = "FindCeiling";
            Helpers.PrintStartFunctionTest(name);
            Console.WriteLine(FindCeiling(new int[] { 4, 6, 10 }, 6));
            Console.WriteLine(FindCeiling(new int[] { 1, 3, 8, 10, 15 }, 12));
            Console.WriteLine(FindCeiling(new int[] { 4, 6, 10 }, 17));
            Console.WriteLine(FindCeiling(new int[] { 4, 6, 10 }, -1));

            name = "NextLetter";
            Helpers.PrintStartFunctionTest(name);
            Console.WriteLine(NextLetter(new char[] { 'a', 'c', 'f', 'h' }, 'f'));
            Console.WriteLine(NextLetter(new char[] { 'a', 'c', 'f', 'h' }, 'b'));
            Console.WriteLine(NextLetter(new char[] { 'a', 'c', 'f', 'h' }, 'm'));
            Console.WriteLine(NextLetter(new char[] { 'a', 'c', 'f', 'h' }, 'h'));
            Console.WriteLine(NextLetter(new char[] { 'a', 'c', 'd', 'g', 'm' }, 'a'));
            Console.WriteLine(NextLetter(new char[] { 'a', 'c', 'd', 'g', 'm' }, 'b'));
            Console.WriteLine(NextLetter(new char[] { 'a', 'c', 'd', 'g', 'm' }, 'c'));
            Console.WriteLine(NextLetter(new char[] { 'a', 'c', 'd', 'g', 'm' }, 'd'));
            Console.WriteLine(NextLetter(new char[] { 'a', 'c', 'd', 'g', 'm' }, 'k'));
            Console.WriteLine(NextLetter(new char[] { 'a', 'c', 'd', 'g', 'm' }, 'n'));
            Console.WriteLine(NextLetter(new char[] { 'a', 'c', 'd', 'g', 'm' }, 'z'));

            name = "FindRange";
            Helpers.PrintStartFunctionTest(name);
            nums = new int[] { 4, 6, 6, 6, 9 };
            key = 6;
            Helpers.PrintArray(nums);
            range = FindRangeFirstTry(nums, key);
            Console.WriteLine($"-> [{range[0]},{range[1]}]");
            range = FindRange(nums, key);
            Console.WriteLine($"-> [{range[0]},{range[1]}]");
            nums = new int[] { 1, 3, 8, 10, 15 };
            key = 10;
            Helpers.PrintArray(nums);
            range = FindRangeFirstTry(nums, key);
            Console.WriteLine($"-> [{range[0]},{range[1]}]");
            range = FindRange(nums, key);
            Console.WriteLine($"-> [{range[0]},{range[1]}]");
            nums = new int[] { 1, 3, 8, 10, 15 };
            key = 12;
            Helpers.PrintArray(nums);
            range = FindRangeFirstTry(nums, key);
            Console.WriteLine($"-> [{range[0]},{range[1]}]");
            range = FindRange(nums, key);
            Console.WriteLine($"-> [{range[0]},{range[1]}]");

            name = "InfiniteArrayFindKey";
            Helpers.PrintStartFunctionTest(name);
            reader = new ArrayReader(new int[] { 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30 });
            key = 16;
            Helpers.PrintArray(reader.GetArray());
            Console.WriteLine(InfiniteArrayFindKey(reader, key));
            key = 11;
            Helpers.PrintArray(reader.GetArray());
            Console.WriteLine(InfiniteArrayFindKey(reader, key));
            reader = new ArrayReader(new int[] { 1, 3, 8, 10, 15 });
            key = 15;
            Helpers.PrintArray(reader.GetArray());
            Console.WriteLine(InfiniteArrayFindKey(reader, key));
            key = 200;
            Helpers.PrintArray(reader.GetArray());
            Console.WriteLine(InfiniteArrayFindKey(reader, key));

            name = "FindMindDiffElement";
            Helpers.PrintStartFunctionTest(name);
            nums = new int[] { 4, 6, 10 };
            key = 7;
            Helpers.PrintArray(nums);
            Console.WriteLine(FindMinDiffElement(nums, key));
            nums = new int[] { 4, 6, 10 };
            key = 4;
            Helpers.PrintArray(nums);
            Console.WriteLine(FindMinDiffElement(nums, key));
            nums = new int[] { 1, 3, 8, 10, 15 };
            key = 12;
            Helpers.PrintArray(nums);
            Console.WriteLine(FindMinDiffElement(nums, key));
            nums = new int[] { 4, 6, 10 };
            key = 17;
            Helpers.PrintArray(nums);
            Console.WriteLine(FindMinDiffElement(nums, key));

            Helpers.PrintEndTests(testPattern);
        }

        static int FindMinDiffElement(int[] nums, int key)
        {
            int start = 0, mid = 0, end = 0;

            if (nums == null || nums.Length < 1 || nums[0] > key)
            {
                return -1;
            }

            if (nums[0] > key)
            {
                return nums[0];
            }

            if (nums[nums.Length - 1] < key)
            {
                return nums[nums.Length - 1];
            }

            end = nums.Length - 1;

            while (start <= end)
            {
                mid = start + (end - start) / 2;

                if (nums[mid] < key)
                {
                    start = mid + 1;
                }
                else if (nums[mid] > key)
                {
                    end = mid - 1;
                }
                else
                {
                    return nums[mid];
                }
            }

            if (nums[start] - key < (key - nums[end]))
            {
                return nums[start];
            }

            return nums[end];
        }

        static int InfiniteArrayFindKey(ArrayReader reader, int key)
        {
            int start = 0, mid = 0, end = 1;

            if (reader.Get(0) >= key)
            {
                if (reader.Get(0) == key)
                {
                    return 0;
                }

                return -1;
            }

            while (reader.Get(end) <= key && reader.Get(end) != int.MaxValue)
            {
                end *= 2;
            }

            while (start <= end)
            {
                mid = start + (end - start) / 2;

                if (reader.Get(mid) > key)
                {
                    end = mid - 1;
                }
                else if(reader.Get(mid) < key)
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        static int[] FindRange(int[] nums, int key)
        {
            int[] range = { -1, -1 };

            if (nums == null || nums.Length < 1)
            {
                return range;
            }

            range[0] = FindRange(nums, key, false);
            if (range[0] != -1)
            {
                range[1] = FindRange(nums, key, true);
            }

            return range;
        }

        static int FindRange(int[] nums, int key, bool findMaxIndex)
        {
            int keyIndex = -1, start = 0, end = nums.Length - 1;

            while (start <= end)
            {
                var mid = start + (end - start) / 2;

                if (nums[mid] > key)
                {
                    end = mid - 1;
                }
                else if (nums[mid] < key)
                {
                    start = mid + 1;
                }
                else
                {
                    keyIndex = mid;
                    if (findMaxIndex)
                    {
                        start = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }
            }

            return keyIndex;
        }
        
        static int[] FindRangeFirstTry(int[] nums, int key)
        {
            int[] range = { -1, -1 };
            int start = 0, end = 0, mid = 0;

            if (nums == null || nums.Length < 1)
            {
                return range;
            }

            end = nums.Length - 1;
            mid = start + (end - start) / 2;

            // Perform Binary Search to find key
            while (start <= end)
            {
                mid = start + (end - start) / 2;

                if (nums[mid] < key)
                {
                    start = mid + 1;
                }
                else if (nums[mid] > key)
                {
                    end = mid - 1;
                }
                else 
                {
                    break;
                }
            }

            // Grow range
            if (nums[mid] == key)
            {
                start = mid;
                end = mid;

                while (start > 0 && end < nums.Length - 1 && nums[start] == key && nums[end] == key)
                {
                    start--;
                    end++;
                }

                range = new int[] { start + 1, end - 1};
            }            

            return range;
        }
        
        static char NextLetter(char[] letters, char key)
        {
            int mid = 0, start = 0, end = 0;

            if (letters == null)
            {
                return ' ';
            }

            end = letters.Length - 1;

            if (key < letters[0] || key >= letters[end] || letters.Length < 2)
            {
                return letters[0];
            }

            while (start <= end)
            {
                mid = start + (end - start) / 2;

                if (letters[mid] > key)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return letters[start];
        }

        static int FindCeiling(int[] arr, int key)
        {
            int start, mid, end;

            if (arr == null || arr.Length < 1 || key > arr[^1])
            {
                return -1;
            }

            start = 0;
            end = arr.Length - 1;

            while (start <= end)
            {
                mid = start + (end - start) / 2;

                if (arr[mid] > key)
                {
                    end = mid - 1;
                }
                else if (arr[mid] < key)
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

        static int OrderAgnosticBinarySearch(int[] arr, int key)
        {
            if (arr == null || arr.Length < 1)
            {
                return -1;
            }
            var start = 0;
            var end = arr.Length - 1;
            var isAsc = (arr[start] < arr[end]);

            return OrderAgnosticBinarySearch(arr, key, start, end, isAsc);
        }

        static int OrderAgnosticBinarySearch(int[] arr, int key, int start, int end, bool isAsc)
        {
            var mid =  start + (end - start) / 2;

            if (start > end)
            {
                return -1;
            }

            if (arr[mid] == key)
            {
                return mid;
            }

            if (isAsc ? arr[mid] > key : arr[mid] < key)
            {
                return OrderAgnosticBinarySearch(arr, key, start, mid - 1, isAsc);
            }
            else
            {
                return OrderAgnosticBinarySearch(arr, key, mid + 1, end, isAsc);
            }
            
        }
    }
}
