using System;
using System.Collections.Generic;

namespace CodingPatterns.Patterns
{
    class DP
    {
        public static void RunTests()
        {
            int[] nums, weights, profits;
            int n, capacity;
            string name;
            string testPattern;

            testPattern = "DP";
            Helpers.PrintStartTests(testPattern);

            name = "FibonacciDP";
            Helpers.PrintStartFunctionTest(name);
            n = 0;
            Console.WriteLine(FibonacciDP(n));
            n = 1;
            Console.WriteLine(FibonacciDP(n));
            n = 5;
            Console.WriteLine(FibonacciDP(n));
            n = 6;
            Console.WriteLine(FibonacciDP(n));
            n = 8;
            Console.WriteLine(FibonacciDP(n));
            n = 100;
            Console.WriteLine(FibonacciDP(n));

            name = "MaxProfitWeighted_Brute";
            Helpers.PrintStartFunctionTest(name);
            weights = new int[] { 2, 3, 1, 4 };
            profits = new int[] { 4, 5, 3, 7 };
            capacity = 5;
            Console.Write($"weights: ");
            Helpers.PrintArray(weights);
            Console.Write($"profits: ");
            Helpers.PrintArray(profits);
            Console.WriteLine($"capacity: {capacity}");
            Console.WriteLine($"maxProfit_brute_iter:  {MaxProfitWeighted_Brute(weights, profits, capacity)}");
            Console.WriteLine($"maxProfit_brute_recur: {MaxProfitWeighted_BruteRecursive(weights, profits, capacity)}");
            Console.WriteLine($"maxProfit_topDown:     {MaxProfitWeighted_TopDown(weights, profits, capacity)}");
            Console.WriteLine($"maxProfit_bottomUp:    {MaxProfitWeighted_BottomUp(weights, profits, capacity)}");
            capacity = 6;
            Console.Write($"weights: ");
            Helpers.PrintArray(weights);
            Console.Write($"profits: ");
            Helpers.PrintArray(profits);
            Console.WriteLine($"capacity: {capacity}");
            Console.WriteLine($"maxProfit_brute_iter:  {MaxProfitWeighted_Brute(weights, profits, capacity)}");
            Console.WriteLine($"maxProfit_brute_recur: {MaxProfitWeighted_BruteRecursive(weights, profits, capacity)}");
            Console.WriteLine($"maxProfit_topDown:     {MaxProfitWeighted_TopDown(weights, profits, capacity)}");
            Console.WriteLine($"maxProfit_bottomUp:    {MaxProfitWeighted_BottomUp(weights, profits, capacity)}");
            weights = new int[] { 2, 3, 1, 4 };
            profits = new int[] { 4, 5, 1, 7 };
            capacity = 6;
            Console.Write($"weights: ");
            Helpers.PrintArray(weights);
            Console.Write($"profits: ");
            Helpers.PrintArray(profits);
            Console.WriteLine($"capacity: {capacity}");
            Console.WriteLine($"maxProfit_brute_iter:  {MaxProfitWeighted_Brute(weights, profits, capacity)}");
            Console.WriteLine($"maxProfit_brute_recur: {MaxProfitWeighted_BruteRecursive(weights, profits, capacity)}");
            Console.WriteLine($"maxProfit_topDown:     {MaxProfitWeighted_TopDown(weights, profits, capacity)}");
            Console.WriteLine($"maxProfit_bottomUp:    {MaxProfitWeighted_BottomUp(weights, profits, capacity)}");
            weights = new int[] { 2, 3, 1, 4 };
            profits = new int[] { 4, 5, 2, 7 };
            capacity = 6;
            Console.Write($"weights: ");
            Helpers.PrintArray(weights);
            Console.Write($"profits: ");
            Helpers.PrintArray(profits);
            Console.WriteLine($"capacity: {capacity}");
            Console.WriteLine($"maxProfit_brute_iter:  {MaxProfitWeighted_Brute(weights, profits, capacity)}");
            Console.WriteLine($"maxProfit_brute_recur: {MaxProfitWeighted_BruteRecursive(weights, profits, capacity)}");
            Console.WriteLine($"maxProfit_topDown:     {MaxProfitWeighted_TopDown(weights, profits, capacity)}");
            Console.WriteLine($"maxProfit_bottomUp:    {MaxProfitWeighted_BottomUp(weights, profits, capacity)}");

            name = "HasEqualSubsetSumPartition";
            Helpers.PrintStartFunctionTest(name);
            nums = new int[] { 1, 2, 3, 4 };
            Helpers.PrintArray(nums);
            Console.WriteLine(HasEqualSubsetSumPartition_Iter(nums));
            Console.WriteLine(HasEqualSubsetSumPartition_DP_Recur(nums));
            nums = new int[] { 1, 1, 3, 4, 7 };
            Helpers.PrintArray(nums);
            Console.WriteLine(HasEqualSubsetSumPartition_Iter(nums));
            Console.WriteLine(HasEqualSubsetSumPartition_DP_Recur(nums));
            nums = new int[] { 2, 3, 4, 6 };
            Helpers.PrintArray(nums);
            Console.WriteLine(HasEqualSubsetSumPartition_Iter(nums));
            Console.WriteLine(HasEqualSubsetSumPartition_DP_Recur(nums));
            nums = new int[] { 1, 2, 5, 6 };
            Helpers.PrintArray(nums);
            Console.WriteLine(HasEqualSubsetSumPartition_Iter(nums));
            Console.WriteLine(HasEqualSubsetSumPartition_DP_Recur(nums));
            nums = new int[] { 1, 2, 3, 4, 5 };
            Helpers.PrintArray(nums);
            Console.WriteLine(HasEqualSubsetSumPartition_Iter(nums));
            Console.WriteLine(HasEqualSubsetSumPartition_DP_Recur(nums));
            nums = new int[] { 1, 2, 3, 4, 5, 6 };
            Helpers.PrintArray(nums);
            Console.WriteLine(HasEqualSubsetSumPartition_Iter(nums));
            Console.WriteLine(HasEqualSubsetSumPartition_DP_Recur(nums));


            Helpers.PrintEndTests(testPattern);

        }

        public static bool HasEqualSubsetSumPartition_DP_Recur(int[] nums)
        {
            int sum = 0;
            bool?[][] dp;

            if (nums == null)
            {
                return false;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            if (sum % 2 != 0)
            {
                return false;
            }

            dp = new bool?[nums.Length][];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new bool?[sum / 2 + 1];
            }

            return HasEqualSubsetSumPartition_Recur(dp, nums, sum / 2, 0);
        }

        static bool HasEqualSubsetSumPartition_Recur(bool?[][] dp, int[] nums, int sum, int curIndex)
        {
            if (sum == 0)
            {
                return true;
            }

            if (nums.Length == 0 || curIndex >= nums.Length)
            {
                return false;
            }

            if (dp[curIndex][sum] == null)
            {
                if (nums[curIndex] <= sum && HasEqualSubsetSumPartition_Recur(dp, nums, sum - nums[curIndex], curIndex + 1))
                {
                    dp[curIndex][sum] = true;

                    return true;
                }                

                dp[curIndex][sum] = HasEqualSubsetSumPartition_Recur(dp, nums, sum, curIndex + 1);
            }

            return (bool) dp[curIndex][sum];
        }

        public static bool HasEqualSubsetSumPartition_Iter(int[] nums)
        {
            IList<IList<int>> subsets = new List<IList<int>>();
            Dictionary<string, int[]> dp = new Dictionary<string, int[]>();

            if (nums == null)
            {
                return false;
            }

            subsets.Add(new List<int>());

            for (int i = 0; i < nums.Length; i++)
            {
                int size = subsets.Count;

                for (int j = 0; j < size; j++)
                {
                    List<int> setA = new List<int>(subsets[j]) { i };
                    List<int> setB = new List<int>();
                    int sumA = 0, sumB = 0;

                    setA.Sort();
                    string keyA = String.Join(",", setA);

                    if (!dp.ContainsKey(keyA))
                    {
                        for (int k = 0; k < setA.Count; k++)
                        {
                            sumA += nums[setA[k]];
                        }

                        for (int k = 0; k < nums.Length; k++)
                        {
                            if (!setA.Contains(k))
                            {
                                setB.Add(k);
                                sumB += nums[k];
                            }
                        }

                        if (sumA == sumB)
                        {
                            //Console.WriteLine($"Equal Subset Sum Partition found!");
                            //Console.Write($"SetA: ");
                            //Helpers.PrintList(setA);
                            //Console.Write($"SetB: ");
                            //Helpers.PrintList(setB);

                            return true;
                        }

                        dp.Add(keyA, new int[] { sumA, sumB });
                        setB.Sort();
                        var keyB = String.Join(",", setB);
                        dp.Add(keyB, new int[] { sumA, sumB });

                        subsets.Add(setA);
                    }
                    //else
                    //{
                    //    Console.WriteLine($"Skipping already checked partition {keyA}...");
                    //}
                }
            }

            return false;
        }
                
        static Dictionary<(int capacity, int index), int> _history;

        public static int MaxProfitWeighted_BottomUp(int[] weights, int[] profits, int capacity)
        {
            // Create a 2d grid with index x...weights.Length - 1 and y...capacity
            int[][] dp;

            if (weights == null || profits.Length == 0 || weights.Length != profits.Length || capacity <= 0)
            {
                return 0;
            }

            dp = new int[weights.Length][];

            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[capacity + 1];
            }

            for (int c = 0; c <= capacity; c++)
            {
                if(weights[0] <= c)
                {
                    dp[0][c] = profits[0];
                }
            }

            for (int i = 1; i < weights.Length; i++)
            {
                for (int c = 1; c <= capacity; c++)
                {
                    int profitA = 0, profitB = 0;

                    if (weights[i] <= c)
                    {
                        profitA = profits[i] + dp[i - 1][c - weights[i]];
                    }

                    profitB = dp[i - 1][c];

                    dp[i][c] = Math.Max(profitA, profitB);
                }
            }

            //MaxProfitWeighted_DP_BottomUp_Print(weights, profits, capacity, dp);

            return dp[weights.Length - 1][capacity];
        }

        static void MaxProfitWeighted_BottomUp_Print(int[] weights, int[] profits, int capacity, int[][] dp)
        {
            int totalProfit = dp[weights.Length - 1][capacity];
            Console.Write($"Selected item(s):");

            for (int i = weights.Length - 1; i > 0; i--)
            {
                if (totalProfit != dp[i - 1][capacity])
                {
                    Console.Write($" {weights[i]}");
                    capacity -= weights[i];
                    totalProfit -= profits[i];
                }
            }

            if (totalProfit != 0)
            {
                Console.Write($" {weights[0]}");
            }
            Console.WriteLine();
        }

        public static int MaxProfitWeighted_TopDown(int[] weights, int[] profits, int capacity)
        {
            _history = new Dictionary<(int capacity, int index), int>();

            return MaxProfitWeighted_TopDown(weights, profits, capacity, 0);
        }

        static int MaxProfitWeighted_TopDown(int[] weights, int[] profits, int capacity, int curIndex)
        {
            int profitA = 0, profitB = 0;

            if (_history.ContainsKey((capacity, curIndex)))
            {
                return _history[(capacity, curIndex)];
            }

            if (capacity <= 0 || curIndex >= profits.Length)
            {
                return 0;
            }

            if (weights[curIndex] <= capacity)
            {
                profitA = profits[curIndex] +
                    MaxProfitWeighted_TopDown(weights, profits, capacity - weights[curIndex], curIndex + 1);
            }

            profitB = MaxProfitWeighted_TopDown(weights, profits, capacity, curIndex + 1);

            _history.Add((capacity, curIndex), Math.Max(profitA, profitB));

            return _history[(capacity, curIndex)];
        }

        public static int MaxProfitWeighted_BruteRecursive(int[] weights, int[] profits, int capacity)
        {
            _history = new Dictionary<(int capacity, int index), int>();

            return MaxProfitWeighted_BruteRecursive(weights, profits, capacity, 0);
        }

        static int MaxProfitWeighted_BruteRecursive(int[] weights, int[] profits, int capacity, int curIndex)
        {
            int profitA = 0, profitB = 0;

            //if (_history.ContainsKey((capacity, index)))
            //{
            //    Console.WriteLine($"Found previous call: ({capacity}, {index})...");
            //}

            _history.TryAdd((capacity, curIndex), 0);

            if (capacity <= 0 || curIndex >= profits.Length)
            {
                return 0;
            }

            if (weights[curIndex] <= capacity)
            {
                profitA = profits[curIndex] + 
                    MaxProfitWeighted_BruteRecursive(weights, profits, capacity - weights[curIndex], curIndex + 1);
            }

            profitB = MaxProfitWeighted_BruteRecursive(weights, profits, capacity, curIndex + 1);

            return Math.Max(profitA, profitB);
        }

        public static int MaxProfitWeighted_Brute(int[] weights, int[] profits, int capacity)
        {
            int totalWeight = 0, totalProfit = 0, maxProfit = 0, length = 0;

            if (weights == null || profits == null || weights.Length != profits.Length)
            {
                return 0;
            }

            length = weights.Length;

            for (int i = 0; i < length; i++)
            {
                if (weights[i] > capacity)
                {
                    continue;
                }

                totalWeight = weights[i];
                totalProfit = profits[i];

                for (int j = i + 1; j < length; j++)
                {   
                    if (totalWeight + weights[j] > capacity)
                    {
                        // Reset weight & profit only if necessary
                        if (totalWeight == weights[i])
                        {
                            continue;
                        }

                        totalWeight = weights[i];
                        totalProfit = profits[i];
                        j--;                        
                    }
                    else
                    {
                        totalWeight += weights[j];
                        totalProfit += profits[j];
                        maxProfit = Math.Max(maxProfit, totalProfit);
                    }
                }
            }

            return maxProfit;
        }

        public static int FibonacciDP(int n, int[] lookup)
        {
            if (lookup[n] == -1)
            {
                if (n <= 1)
                {
                    lookup[n] = n;
                }
                else
                {
                    lookup[n] = FibonacciDP(n - 1, lookup) + FibonacciDP(n - 2, lookup);
                }
            }

            return lookup[n];
        }

        public static int FibonacciDP(int n)
        {
            int max = 1000;
            int[] lookup = new int[max];

            if (n > max)
            {
                throw new Exception($"n cannot be greater than {max}");
            }

            for (int i = 0; i < max; i++)
            {
                lookup[i] = -1;
            }

            return FibonacciDP(n, lookup);
        }
    }
}
