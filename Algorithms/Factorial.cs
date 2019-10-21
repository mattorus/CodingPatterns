using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Algorithms
{
    class Factorial
    {
        public Factorial() { }

        public static void RunTests()
        {
            string testPattern = "FACTORIAL";
            Helpers.PrintStartTests(testPattern);
        }

        public static int FindFactorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }

    }
}
