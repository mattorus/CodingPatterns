using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Algorithms
{
    class Recursion
    {

        public static void RunTests()
        {
            string testPattern = "RECURSION";
            Helpers.PrintStartTests(testPattern);

            string name = "Power";
            Helpers.PrintStartFunctionTest(name);
            double x = 25;
            int n = 5;
            Console.WriteLine($"x: {x}, n: {n} => {Power(x, n)}");
            x = 25;
            n = 6;
            Console.WriteLine($"x: {x}, n: {n} => {Power(x, n)}");
            x = 25;
            n = -5;
            Console.WriteLine($"x: {x}, n: {n} => {Power(x, n)}");
            x = 2.000000;
            n = 0;
            Console.WriteLine($"x: {x}, n: {n} => {Power(x, n)}");
            x = 3.000000;
            n = 2;
            Console.WriteLine($"x: {x}, n: {n} => {Power(x, n)}");
            x = 5.000000;
            n = 3;
            Console.WriteLine($"x: {x}, n: {n} => {Power(x, n)}");
            x = 2.000000;
            n = -2;
            Console.WriteLine($"x: {x}, n: {n} => {Power(x, n)}");
            x = 5.000000;
            n = -3;
            Console.WriteLine($"x: {x}, n: {n} => {Power(x, n)}");
            Console.WriteLine();

            Helpers.PrintEndTests(testPattern);
        }

        public static double Power(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            if (n < 0)
            {
                return 1 / Power(x, n * -1);
            }

            if (n % 2 != 0)
            {
                return x * Power(x, n - 1);
            }
            else
            {
                return Power(x, n / 2) * Power(x, n / 2);
            }
        }
    }
}
