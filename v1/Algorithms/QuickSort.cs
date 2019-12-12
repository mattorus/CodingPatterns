using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Algorithms
{
    class QuickSort
    {
        public static void RunTests()
        {
            string testPattern = "QUICKSORT";
            Helpers.PrintStartTests(testPattern);

            string name = "DoSort";
            Helpers.PrintStartFunctionTest(name);
            int[] arr = { 4, 21, 2, 8, 20, 2 };
            int p = 0;
            Helpers.PrintArray(arr);
            DoSort(arr, p, arr.Length - 1);
            Helpers.PrintArray(arr);
            arr = new[] { 4, 2, 1, 3 };
            Helpers.PrintArray(arr);
            DoSort(arr, p, arr.Length - 1);
            Helpers.PrintArray(arr);
            arr = new[] { 4, 3, 2, 1, 0, -1, -99 };
            Helpers.PrintArray(arr);
            DoSort(arr, p, arr.Length - 1);
            Helpers.PrintArray(arr);
            arr = new[] { 1, 2, 3, 4 };
            Helpers.PrintArray(arr);
            DoSort(arr, p, arr.Length - 1);
            Helpers.PrintArray(arr);
            arr = new[] { 2 };
            Helpers.PrintArray(arr);
            DoSort(arr, p, arr.Length - 1);
            Helpers.PrintArray(arr);
            arr = new int[] { };
            Helpers.PrintArray(arr);
            DoSort(arr, p, arr.Length - 1);
            Helpers.PrintArray(arr);
            arr = null;
            Helpers.PrintArray(arr);
            DoSort(arr, p, 0);
            Helpers.PrintArray(arr);

            Helpers.PrintEndTests(testPattern);
        }

        public static void DoSort(int[] arr, int p, int r)
        {
            int j, q;

            if (arr == null || arr.Length < 2 || r <= p)
            {
                return;
            }

            // First attempt
            // Smelly code
            //i = p;
            //j = r - 1;
            //q = r;

            //while (i <= j)
            //{
            //    if (arr[j] <= arr[r])
            //    {
            //        temp = arr[i];
            //        arr[i] = arr[j];
            //        arr[j] = temp;
            //        i++;
            //    }
            //    else
            //    {
            //        j--;
            //    }
            //}

            //if (arr[i] > arr[r])
            //{
            //    q = i;
            //    temp = arr[q];
            //    arr[q] = arr[r];
            //    arr[r] = temp;
            //}

            // 2nd Attempt
            q = p;
            j = p;

            while (j < r)
            {
                if (arr[j] <= arr[r])
                {
                    Helpers.Swap(arr, q++, j++);
                }
                else
                {
                    j++;
                }
            }

            Helpers.Swap(arr, q, r);

            DoSort(arr, p, q - 1);
            DoSort(arr, q + 1, r);
        }
    }
}
