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
            
            Console.WriteLine("Testing FindFactorial()");
            Console.WriteLine("--------------------------");
            int fact = 0;
            Console.WriteLine(Iter_FindFactorial(fact));
            Console.WriteLine(Rec_FindFactorial(fact));
            fact = 1;
            Console.WriteLine(Iter_FindFactorial(fact));
            Console.WriteLine(Rec_FindFactorial(fact));
            fact = 2;
            Console.WriteLine(Iter_FindFactorial(fact));
            Console.WriteLine(Rec_FindFactorial(fact));
            fact = 5;
            Console.WriteLine(Iter_FindFactorial(fact));
            Console.WriteLine(Rec_FindFactorial(fact));
            fact = 10;
            Console.WriteLine(Iter_FindFactorial(fact));
            Console.WriteLine(Rec_FindFactorial(fact));

            Helpers.PrintEndTests(testPattern);
        }

        public static int Iter_FindFactorial(int n)
        {
            int fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }

        public static int Rec_FindFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Rec_FindFactorial(n - 1);
        }

    }
}
