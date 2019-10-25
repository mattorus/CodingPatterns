using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Patterns
{
    class TwoPointers
    {

        public static void RunTests()
        {
            int[] arr;
            int[] pairSum;
            int targetSum;
            string name;
            string testPattern = "TWOPOINTERS";
            Helpers.PrintStartTests(testPattern);

            name = "PairWithSum";
            Helpers.PrintStartFunctionTest(name);
            arr = new[] { 1, 2, 3, 4, 6 };
            targetSum = 6;
            pairSum = PairWithSum(arr, targetSum);
            Helpers.PrintArray(arr);
            Console.WriteLine($"  pairSum: [{pairSum[0]}, {pairSum[1]}]");
            arr = new[] { 2, 5, 9, 11 };
            targetSum = 11;
            pairSum = PairWithSum(arr, targetSum);
            Helpers.PrintArray(arr);
            Console.WriteLine($"  pairSum: [{pairSum[0]}, {pairSum[1]}]");

            name = "RemoveDuplicates";
            Helpers.PrintStartFunctionTest(name);
            arr = new[] { 2, 3, 3, 3, 6, 9, 9 };
            Helpers.PrintArray(arr);
            Console.WriteLine($" Dupeless arr.Length: {RemoveDuplicates(arr)}");
            arr = new[] { 2, 2, 2, 11 };
            Helpers.PrintArray(arr);
            Console.WriteLine($" Dupeless arr.Length: {RemoveDuplicates(arr)}");
            
            name = "MakeSquares";
            Helpers.PrintStartFunctionTest(name);
            arr = new[] { -2, -1, 0, 2, 3 };
            Helpers.PrintArray(arr);
            Helpers.PrintArray(MakeSquares(arr));
            arr = new[] { -3, -1, 0, 1, 2 };
            Helpers.PrintArray(arr);
            Helpers.PrintArray(MakeSquares(arr));

            name = "TripletZeroSum";
            Helpers.PrintStartFunctionTest(name);
            arr = new[] { -3, 0, 1, 2, -1, 1, -2 };
            Array.Sort(arr);
            Helpers.PrintArray(arr);
            Helpers.PrintListList(TripletZeroSum(arr));
            Console.WriteLine();
            arr = new[] { -5, 2, -1, -2, 3 };
            Helpers.PrintArray(arr);
            Helpers.PrintListList(TripletZeroSum(arr));
            Console.WriteLine();
            arr = new[] { 4, -1, 0, -3, 1, 1 };
            Helpers.PrintArray(arr);
            Helpers.PrintListList(TripletZeroSum(arr));
            Console.WriteLine();

            name = "TripletTargetCloseSum";
            Helpers.PrintStartFunctionTest(name);
            arr = new[] { -2, 0, 1, 2 };
            targetSum = 2;
            Helpers.PrintArray(arr);
            Console.WriteLine($"  targetSum: {targetSum}");
            Console.WriteLine($"    ClosestSum: {TripletTargetCloseSum(arr, targetSum)}");
            arr = new[] { 2, -1, 1, -3 };
            targetSum = 1;
            Helpers.PrintArray(arr);
            Console.WriteLine($"  targetSum: {targetSum}");
            Console.WriteLine($"    ClosestSum: {TripletTargetCloseSum(arr, targetSum)}");
            arr = new[] { 1, 0, 1, 1 };
            targetSum = 100;
            Helpers.PrintArray(arr);
            Console.WriteLine($"  targetSum: {targetSum}");
            Console.WriteLine($"    ClosestSum: {TripletTargetCloseSum(arr, targetSum)}");

            name = "TripletSumLessThan";
            Helpers.PrintStartFunctionTest(name);
            arr = new[] { -1, 0, 2, 3 };
            targetSum = 3;
            Helpers.PrintArray(arr);
            Console.WriteLine($"   Count of sum < target: {TripletSumLessThan(arr, targetSum)}");
            arr = new[] { -1, 4, 2, 1, 3 };
            targetSum = 5;
            Helpers.PrintArray(arr);
            Console.WriteLine($"   Count of sum < target: {TripletSumLessThan(arr, targetSum)}");
            arr = new[] { -1, 0, 2, 3 };
            targetSum = 2;
            Helpers.PrintArray(arr);
            Console.WriteLine($"   Count of sum < target: {TripletSumLessThan(arr, targetSum)}");
            arr = new[] { -1, 4, 2, 1, 3 };
            targetSum = 3;
            Helpers.PrintArray(arr);
            Console.WriteLine($"   Count of sum < target: {TripletSumLessThan(arr, targetSum)}");
            arr = new[] { -1, 0, 2, 3 };
            targetSum = 6;
            Helpers.PrintArray(arr);
            Console.WriteLine($"   Count of sum < target: {TripletSumLessThan(arr, targetSum)}");
            arr = new[] { -1, 4, 2, 1, 3 };
            targetSum = 9;
            Helpers.PrintArray(arr);
            Console.WriteLine($"   Count of sum < target: {TripletSumLessThan(arr, targetSum)}");

            name = "SubarraysProductLessThan";
            Helpers.PrintStartFunctionTest(name);
            arr = new[] { 2, 5, 3, 10 };
            targetSum = 30;
            IList<IList<int>> subArrays = SubarraysProductLessThan(arr, targetSum);
            Helpers.PrintListList(subArrays);
            arr = new[] { 8, 2, 6, 5 };
            targetSum = 50;
            subArrays = SubarraysProductLessThan(arr, targetSum);
            Helpers.PrintListList(subArrays);
            arr = new[] { 3, 5, 1, 0, 2, 6, 5 };
            targetSum = 200;
            subArrays = SubarraysProductLessThan(arr, targetSum);
            Helpers.PrintListList(subArrays);
            arr = new[] { 3, 5, 1, 4, 2, 6, 5 };
            targetSum = 200;
            subArrays = SubarraysProductLessThan(arr, targetSum);
            Helpers.PrintListList(subArrays);

            Helpers.PrintEndTests(testPattern);
        }

        public static IList<IList<int>> SubarraysProductLessThan(int[] arr, int targetSum)
        {
            IList<IList<int>> subArrays = new List<IList<int>>();
            HashSet<int> added = new HashSet<int>();
            int i = 0, j = 0, product = 0;

            if (arr == null)
            {
                return null;
            }

            while (i < arr.Length)
            {
                product = arr[i];
                if (product < targetSum)
                {
                    IList<int> curProduct = new List<int>();
                    j = i;

                    while (product < targetSum && i <= j && j < arr.Length)
                    {   
                        curProduct.Add(arr[j]);

                        if (!added.Contains(j))
                        {
                            subArrays.Add(new List<int> { arr[j] });
                        }

                        added.Add(j);

                        if (j > i) // Seems unnecessary, may be a way to build this into algorithm
                        {
                            subArrays.Add(new List<int>(curProduct));
                        }

                        j++;

                        if (j < arr.Length)
                        {
                            product *= arr[j];
                        }
                    }
                }

                i++;
            }

            return subArrays;
        }


        public static int TripletSumLessThan(int[] arr, int targetSum)
        {
            int sum = 0;

            if (arr == null)
            {
                return -1;
            }


            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 2; i++)
            {
                int j = i + 1, k = arr.Length - 1;
                while (j < k)
                {
                    //Console.WriteLine($"({i}: {arr[i]}, {j}: {arr[j]}, {k}: {arr[k]})");
                    if (arr[j] + arr[k] < targetSum - arr[i])
                    {
                        sum += k - j;
                        j++;
                    }
                    else 
                    {
                        k--;
                    }              
                }
            }                       

            return sum;
        }

        public static int TripletTargetCloseSum(int[] arr, int targetSum)
        {
            int minSum = Int32.MaxValue;

            if (arr == null)
            {
                return minSum;
            }

            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                int j = i + 1, k = arr.Length - 1, target = targetSum - arr[i];

                while (j < k)
                {
                    int curSum = arr[i] + arr[j] + arr[k];
                    int curDiff = Math.Abs(targetSum - curSum);
                    
                    if (curDiff < Math.Abs(targetSum - minSum))
                    {
                        minSum = curSum;
                    }

                    if (curSum > targetSum)
                    {
                        k--;
                    }
                    else if (curSum < targetSum)
                    {
                        j++;
                    }
                    else
                    {
                        return curSum;
                    }
                }
            }

            return minSum;
        }

        public static IList<IList<int>> TripletZeroSum(int[] arr)
        {
            IList<IList<int>> tripletSums = new List<IList<int>>();

            if (arr == null)
            {
                return null;
            }

            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                int j = i + 1, k = arr.Length - 1;
                while (j < k)
                {
                    int sum = arr[j] + arr[k];
                    if (sum < -arr[i])
                    {
                        j++;
                    }
                    else if (sum > -arr[i])
                    {
                        k--;
                    }
                    else // sum == -arr[i]
                    {
                        if (arr[k - 1] == arr[j + 1] || (arr[k] != arr[k - 1] && arr[j] != arr[j + 1])) // Ensure no dupes
                        {
                            tripletSums.Add(new List<int> { arr[i], arr[j++], arr[k--] });                            
                        }
                        else
                        {
                            if (arr[j] == arr[j + 1])
                            {
                                j++;
                            }
                            if (arr[k] == arr[k - 1])
                            {
                                k--;
                            }
                        }
                    }
                }
            }

            return tripletSums;
        }

        public static int[] MakeSquares(int[] arr)
        {
            int[] squares;
            int j = 0;

            if (arr == null)
            {
                return null;
            }

            squares = new int[arr.Length];

            while (arr[j] < 0)
            {
                j++;
            }

            for (int i = j - 1, k = 0; k < squares.Length; k++)
            {
                int leftSquare = Int32.MaxValue, rightSquare = Int32.MaxValue;

                if (i >= 0)
                {
                    leftSquare = arr[i] * arr[i];
                }
                if (j < arr.Length)
                {
                    rightSquare = arr[j] * arr[j];
                }
                if (leftSquare < rightSquare)
                {
                    squares[k] = leftSquare;
                    i--;
                }
                else
                {
                    squares[k] = rightSquare;
                    j++;
                }
            }

            return squares;
        }

        public static int RemoveDuplicates(int[] arr)
        {
            int i = 1;

            if (arr == null)
            {
                return 0;
            }

            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[i - 1] != arr[j])
                {
                    arr[i] = arr[j];
                    i++;
                }
            }

            return i;
        }

        public static int RemoveDuplicatesX(int[] arr)
        {
            HashSet<int> uniques = new HashSet<int>();
            int numDuplicates = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (uniques.Contains(arr[i]))
                {
                    numDuplicates++;
                }
                else
                {
                    uniques.Add(arr[i]);
                }
            }

            return arr.Length - numDuplicates;
        }

        public static int[] PairWithSum(int[] arr, int targetSum)
        {
            // Create two pointers, starting at i = 0 and j = arr.Length - 1
            // Loop until i >= j:
            //   Compare arr[i] + arr[j] to targetSum
            //      if == targetSum, return [i, j]
            //      if < targetSum, increment i
            //      if > targetSum, decrement j
            //
            int i, j;
            int[] pairSum = { -1, -1 };

            if (arr == null || arr.Length < 2)
            {
                return pairSum;
            }

            i = 0;
            j = arr.Length - 1;

            while (i < j)
            {
                int sum = arr[i] + arr[j];
                if (sum == targetSum)
                {
                    pairSum = new[] { i, j };
                    break;
                }
                else if (sum < targetSum)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return pairSum;
        }
    }
}
