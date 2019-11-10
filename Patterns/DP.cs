using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Patterns
{
    class DP
    {
        public static void RunTests()
        {
            int n;
            string name;
            string testPattern = "DP";
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

            Helpers.PrintEndTests(testPattern);

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
