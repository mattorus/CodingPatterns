using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Patterns
{
    class Greedy
    {
        public static void RunTests()
        {
            int[] nums;
            string name, testPattern;

            testPattern = "GREEDY";
            Helpers.PrintStartTests(testPattern);

            name = "GetMaxProfit";
            Helpers.PrintStartFunctionTest(name);
            nums = new int[] { 10, 7, 5, 8, 11, 9 };
            Helpers.PrintArray(nums);
            Console.WriteLine(GetMaxProfit(nums));

            Helpers.PrintEndTests(testPattern);
        }

        static int GetMaxProfit(int[] stockPrices)
        {
            int maxPrice = 0, maxProfit = 0;

            if (stockPrices == null || stockPrices.Length < 1)
            {
                return 0;
            }

            maxPrice = stockPrices[stockPrices.Length - 1];

            for (int i = stockPrices.Length - 2; i >= 0; i--)
            {
                maxProfit = Math.Max(maxProfit, maxPrice - stockPrices[i]);
                maxPrice = Math.Max(maxPrice, stockPrices[i]);
            }

            return maxProfit;
        }
    }
}
