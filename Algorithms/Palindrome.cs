using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Algorithms
{
    class Palindrome
    {

        public static void RunTests()
        {
            string testPattern = "PALINDROME";
            Helpers.PrintStartTests(testPattern);
            string name = "IsPalindrome";
            Helpers.PrintStartFunctionTest(name);

            string pal = "hannah";
            Console.WriteLine($"{pal}: {IsPalindrome(pal)}");
            Console.WriteLine($"{pal}: {IsPalindrome(pal, 0, pal.Length - 1)}");
            pal = "bbb";
            Console.WriteLine($"{pal}: {IsPalindrome(pal)}");
            Console.WriteLine($"{pal}: {IsPalindrome(pal, 0, pal.Length - 1)}");
            pal = "aaaa";
            Console.WriteLine($"{pal}: {IsPalindrome(pal)}");
            Console.WriteLine($"{pal}: {IsPalindrome(pal, 0, pal.Length - 1)}");
            pal = "arbitraryyrartibra";
            Console.WriteLine($"{pal}: {IsPalindrome(pal)}");
            Console.WriteLine($"{pal}: {IsPalindrome(pal, 0, pal.Length - 1)}");
            pal = "arbitrarybyrartibra";
            Console.WriteLine($"{pal}: {IsPalindrome(pal)}");
            Console.WriteLine($"{pal}: {IsPalindrome(pal, 0, pal.Length - 1)}");
            pal = "arbitraryrrartibra";
            Console.WriteLine($"{pal}: {IsPalindrome(pal)}");
            Console.WriteLine($"{pal}: {IsPalindrome(pal, 0, pal.Length - 1)}");
            pal = "motor";
            Console.WriteLine($"{pal}: {IsPalindrome(pal)}");
            Console.WriteLine($"{pal}: {IsPalindrome(pal, 0, pal.Length - 1)}");
            pal = "rotor";
            Console.WriteLine($"{pal}: {IsPalindrome(pal)}");
            Console.WriteLine($"{pal}: {IsPalindrome(pal, 0, pal.Length - 1)}");
            pal = "racecar";
            Console.WriteLine($"{pal}: {IsPalindrome(pal)}");
            Console.WriteLine($"{pal}: {IsPalindrome(pal, 0, pal.Length - 1)}");
            pal = "foobar";
            Console.WriteLine($"{pal}: {IsPalindrome(pal)}");
            Console.WriteLine($"{pal}: {IsPalindrome(pal, 0, pal.Length - 1)}");

            Helpers.PrintEndTests(testPattern);
        }
        public static bool IsPalindrome(string s)
        {
            if (String.IsNullOrEmpty(s) || s.Length < 2)
            {
                return true;
            }

            return IsPalindrome(s, 0, s.Length - 1);

            //return s[0] == s[s.Length - 1] && IsPalindrome(s.Substring(1, s.Length - 2));
        }

        public static bool IsPalindrome(string s, int i, int j)
        {
            if (String.IsNullOrEmpty(s) || s.Length < 2 || j <= i)
            {
                return true;
            }

            return s[i] == s[j] && IsPalindrome(s, i + 1, j - 1);
        }

    }
}
