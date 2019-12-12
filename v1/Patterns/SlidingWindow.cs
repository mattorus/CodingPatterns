using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingPatterns.Patterns
{
    class SlidingWindow
    {

        public static void RunTests()
        {
            string testPattern = "SLIDINGWINDOW";
            Helpers.PrintStartTests(testPattern);

            string name = "MinWindowSubstring";
            Helpers.PrintStartFunctionTest(name);
            string str = "aabdec";
            string pattern = "abc";
            Console.WriteLine($"minWindowSubstring: {MinWindowSubstring(str, pattern)}");
            str = "abdabca";
            pattern = "abc";
            Console.WriteLine($"minWindowSubstring: {MinWindowSubstring(str, pattern)}");
            str = "adcad";
            pattern = "abc";
            Console.WriteLine($"minWindowSubstring: {MinWindowSubstring(str, pattern)}");
            str = "abdabca";
            pattern = "cba";
            Console.WriteLine($"minWindowSubstring: {MinWindowSubstring(str, pattern)}");
            str = "Greetings, friend! Super happy to be here!";
            pattern = "egy";
            Console.WriteLine($"minWindowSubstring: {MinWindowSubstring(str, pattern)}");

            Helpers.PrintEndTests(testPattern);
        }

        public static string MinWindowSubstring(string str, string pattern)
        {
            Dictionary<char, int> patternCounts = new Dictionary<char, int>();
            int i = 0, j = 0, minLength = Int32.MaxValue, minStart = -1;
            string minSubstring = "";

            if (String.IsNullOrEmpty(str) || String.IsNullOrEmpty(pattern))
            {
                return "";
            }

            for (int k = 0; k < pattern.Length; k++)
            {
                if (!patternCounts.ContainsKey(pattern[k]))
                {
                    patternCounts[pattern[k]] = 0;
                }

                patternCounts[pattern[k]]++;
            }

            while (j < str.Length - 1 && i <= j)
            {
                while (patternCounts.Values.Max() > 0 && j < str.Length)
                {
                    // grow
                    if (patternCounts.ContainsKey(str[j]))
                    {
                        patternCounts[str[j]]--;
                    }

                    j++;
                }

                while (patternCounts.Values.Max() <= 0 && i < str.Length)
                {
                    // Update min info, if necessary
                    if (j - i < minLength)
                    {
                        minStart = i;
                        minLength = j - i;
                    }

                    // shrink
                    if (i < str.Length && patternCounts.ContainsKey(str[i]))
                    {
                        patternCounts[str[i]]++;
                    }

                    i++;
                }
            }

            if (minLength < Int32.MaxValue)
            {
                minSubstring = str.Substring(minStart, minLength);
            }

            return minSubstring;
        }

    }
}
