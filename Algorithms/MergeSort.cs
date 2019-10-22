using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Algorithms
{
    class MergeSort
    {

        public static void RunTests()
        {
            string testPattern = "MERGESORT";
            Helpers.PrintStartTests(testPattern);
            string name = "DoSort";
            Helpers.PrintStartFunctionTest(name);
            int[] arr = { 4, 21, 2, 8, 20, 2 };
            int p = 0;
            Helpers.PrintArray(arr);
            DoSort(arr, p, arr.Length - 1);
            Helpers.PrintArray(arr);
            arr = new[] { 4, 3, 2, 1 };
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

        public static void DoMerge(int[] arr, int p, int q, int r)
        {

            // O(1) space
            // O(n^2) time
            //for (int i = p; i < r; i++)
            //{
            //    for (int j = i + 1; j <= r; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            int temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}

            // O(n) space
            // O(n) time
            int[] left = new int[q + 1 - p];
            int[] right = new int[r - q];

            Array.Copy(arr, p, left, 0, (q + 1 - p));
            Array.Copy(arr, q + 1, right, 0, (r - q));

            // Method 1:
            //int i = 0, j = 0;
            //for (int k = p; k <= r; k++)
            //{
            //    if (i < left.Length)
            //    {
            //        if (j < right.Length && right[j] < left[i])
            //        {
            //            arr[k] = right[j++];
            //        }
            //        else
            //        {
            //            arr[k] = left[i++];
            //        }
            //    }
            //    else
            //    {
            //        arr[k] = right[j++];
            //    }
            //}

            // Method 2:
            int i = 0, j = 0, k = p;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    arr[k] = left[i++];
                }
                else
                {
                    arr[k] = right[j++];
                }

                k++;
            }

            while (k <= r)
            {
                if (i < left.Length)
                {
                    arr[k] = left[i++];
                }
                else
                {
                    arr[k] = right[j++];
                }

                k++;
            }
        }

        public static void DoSort(int[] arr, int p, int r)
        {
            int q = (p + r) / 2;

            if (arr == null || arr.Length < 2 || r == p) 
            {
                return;
            }
            
            DoSort(arr, p, q);
            DoSort(arr, q + 1, r);

            DoMerge(arr, p, q, r);
        }
    }
}
