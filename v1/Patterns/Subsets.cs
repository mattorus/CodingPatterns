using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Patterns
{
    class Subsets
    {
        public static void RunTests()
        {
            int[] nums;
            int n;
            string name, str;
            string testPattern = "SUBSETS";
            Helpers.PrintStartTests(testPattern);

            name = "FindSubsets";
            Helpers.PrintStartFunctionTest(name);
            nums = new int[] { 1, 3 };
            Helpers.PrintListList(FindSubsets(nums));
            nums = new int[] { 1, 5, 3 };
            Helpers.PrintListList(FindSubsets(nums));
            nums = new int[] { 1, 5, 3, 9 };
            Helpers.PrintListList(FindSubsets(nums));

            name = "FindDistinctSubsets";
            Helpers.PrintStartFunctionTest(name);
            nums = new int[] { 1, 3, 3 };
            Helpers.PrintListList(FindDistinctSubsets(nums));
            nums = new int[] { 1, 5, 3, 3 };
            Helpers.PrintListList(FindDistinctSubsets(nums));
            nums = new int[] { 1, 5, 3, 3, 5 };
            Helpers.PrintListList(FindDistinctSubsets(nums));
            nums = new int[] { 1, 2, 3, 1, 2, 3 };
            Helpers.PrintListList(FindDistinctSubsets(nums));

            name = "FindAllPermutations";
            Helpers.PrintStartFunctionTest(name);
            nums = new int[] { 1, 3, 5 };
            Helpers.PrintListList(FindAllPermutations(nums));
            nums = new int[] { 1, 2, 3, 5 };
            Helpers.PrintListList(FindAllPermutations(nums));
            nums = new int[] { 1, 2, 3, 4, 5 };
            Helpers.PrintListList(FindAllPermutations(nums));

            name = "FindCasePermutations";
            Helpers.PrintStartFunctionTest(name);
            str = "ad52";
            Helpers.PrintList(FindCasePermutations(str));
            str = "ab7c";
            Helpers.PrintList(FindCasePermutations(str));
            str = "ab7ca7f56ew";
            Helpers.PrintList(FindCasePermutations(str));

            name = "FindBalancedParens";
            Helpers.PrintStartFunctionTest(name);
            n = 2;
            Helpers.PrintList(FindBalancedParens(n));
            n = 3;
            Helpers.PrintList(FindBalancedParens(n));
            n = 4;
            Helpers.PrintList(FindBalancedParens(n));

            name = "FindAllSubstrings";
            Helpers.PrintStartFunctionTest(name);
            //str = "abc";
            //Helpers.PrintList(FindGeneralizedAbbreviations(str));
            //str = "abcd";
            //Helpers.PrintList(FindGeneralizedAbbreviations(str));
            //str = "ab";
            //Helpers.PrintList(FindGeneralizedAbbreviations(str));
            str = "abcd";
            Console.Write($"{str} => ");
            Helpers.PrintList(FindAllSubstrings(str));

            name = "FindGeneralizedAbbreviations";
            Helpers.PrintStartFunctionTest(name);
            str = "ab";
            Console.Write($"{str} => ");
            Helpers.PrintList(FindGeneralizedAbbreviations(str));
            str = "BAT";
            Console.Write($"{str} => ");
            Helpers.PrintList(FindGeneralizedAbbreviations(str));
            str = "code";
            Console.Write($"{str} => ");
            Helpers.PrintList(FindGeneralizedAbbreviations(str));



            Helpers.PrintEndTests(testPattern);
        }

        public static IList<string> FindGeneralizedAbbreviations(string word)
        {
            // start with empty string
            // Loop:
            //    On each string from previous loop:
            //      1: Abbreviate current character with a fixed character used as counter '_', 
            //          "_" -> 1; "__" -> 2; etc.
            //      2: Add current character to output (skip abbreviation)

            List<string> abbrStrs = new List<string>();

            if (word == null)
            {
                return null;
            }

            abbrStrs.Add("");

            for (int i = 0; i < word.Length; i++)
            {
                List<string> temp = new List<string>();
                int size = abbrStrs.Count;
                
                for (int j = 0; j < size; j++)
                {
                    // Abbreviate
                    temp.Add(abbrStrs[j] + '_');                    

                    // Add letter
                    StringBuilder sb = new StringBuilder(abbrStrs[j]);
                    // Convert any existing, consecutive '_' into their respective count
                    int abbrIndex = sb.ToString().IndexOf('_');
                    if (abbrIndex >= 0)
                    {
                        int count = 0;
                        
                        for (int k = abbrIndex; k < sb.Length && sb.ToString()[k] == '_'; k++, count++) ;

                        sb.Remove(abbrIndex, count);
                        sb.Insert(abbrIndex, count);
                    }

                    sb.Append(word[i]);
                    temp.Add(sb.ToString());
                }

                abbrStrs = new List<string>(temp);
            }

            // Final conversion
            for (int i = 0; i < abbrStrs.Count; i++)
            {
                int abbrIndex = abbrStrs[i].IndexOf('_');

                if (abbrIndex >= 0)
                {
                    StringBuilder sb = new StringBuilder(abbrStrs[i]);
                    int count = 0;

                    for (int j = abbrIndex; j < sb.Length && sb.ToString()[j] == '_'; j++, count++) ;

                    sb.Remove(abbrIndex, count);
                    sb.Insert(abbrIndex, count);
                    abbrStrs[i] = sb.ToString();
                }
            }

            return abbrStrs;
        }

        public static IList<string> FindAllSubstrings(string word)
        {
            List<string> substrings = new List<string>();

            if (String.IsNullOrEmpty(word))
            {
                return null;
            }

            // Add empty string
            substrings.Add("");

            // Add each individual letter
            List<string> strs = new List<string>();
            for (int i = 0; i < word.Length; i++)
            {
                strs.Add("" + word[i]);
            }

            substrings.AddRange(strs);

            // Loop until done
            for (int i = 0; i < word.Length - 1; i++)
            {
                string[] temp = new string[strs.Count - 1];
                for (int j = 0, k = i + 1; j < strs.Count - 1 && k < word.Length; j++, k++)
                {
                    temp[j] = strs[j] + word[k];
                }

                substrings.AddRange(temp);
                strs = new List<string>(temp);
            }

            return substrings;
        }

        public static IList<string> FindBalancedParens(int n)
        {
            IList<string> combinations = new List<string>();
            IList<(string str, int openCount, int closeCount)> permutations = new List<(string str, int openCount, int closeCount)>();

            if (n < 1)
            {
                return null;
            }

            permutations.Add(("", 0, 0));

            for (int i = 0; i < 2 * n; i++)
            {
                IList<(string str, int openCount, int closeCount)> temp = new List<(string str, int openCount, int closeCount)>();
                int size = permutations.Count;

                for (int j = 0; j < size; j++)
                {                                        
                    StringBuilder sb = new StringBuilder(permutations[j].str);
                    int openCount = permutations[j].openCount;
                    int closeCount = permutations[j].closeCount;

                    // OpenCount can't be > N
                    if (openCount < n)
                    {
                        string tempStr = sb.ToString() + '(';
                        temp.Add((tempStr, openCount + 1, closeCount));
                            
                        if (i == (2 * n) - 1)
                        {
                            combinations.Add(tempStr);
                        }
                    }

                    // To keep parentheses balanced, we can add a ')' only when we have openCount > closedCount
                    if (openCount > closeCount)
                    {
                        string tempStr = sb.ToString() + ')';
                        temp.Add((tempStr, openCount, closeCount + 1));

                        if (i == (2 * n) - 1)
                        {
                            combinations.Add(tempStr);
                        }
                    }                    
                }

                permutations = new List<(string str, int openCount, int closeCount)>(temp);
            }

            return combinations;
        }

        public static IList<string> FindCasePermutations(string str)
        {
            IList<string> permutations = new List<string>();

            if (String.IsNullOrEmpty(str))
            {
                return null;
            }

            permutations.Add(str);

            for (int i = 0; i < str.Length; i++)
            {
                int size = permutations.Count;

                for (int j = 0; j < size; j++)
                {
                    if (Char.IsLetter(str, i))
                    {
                        StringBuilder sb = new StringBuilder(permutations[j]);

                        if (Char.IsUpper(str[i]))
                        {
                            sb[i] = Char.ToLower(str[i]);
                        }
                        else
                        {
                            sb[i] = Char.ToUpper(str[i]);
                        }

                        permutations.Add(sb.ToString());
                    }
                }
            }

            return permutations;
        }

        public static IList<IList<int>> FindAllPermutations(int[] nums)
        {
            IList<IList<int>> permutations = new List<IList<int>>();

            if (nums == null)
            {
                return null;
            }

            permutations.Add(new List<int>());

            for (int i = 0; i < nums.Length; i++)
            {
                IList<IList<int>> temp = new List<IList<int>>();
                int size = permutations.Count;
                
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < permutations[j].Count + 1; k++)
                    {
                        IList<int> perm = new List<int>(permutations[j]);
                        perm.Insert(k, nums[i]);
                        temp.Add(perm);
                    }
                    
                }

                permutations = new List<IList<int>>(temp);
            }

            return permutations;
        }

        public static IList<IList<int>> FindDistinctSubsets(int[] nums)
        {
            IList<IList<int>> subsets = new List<IList<int>>();
            if (nums == null)
            {
                return null;
            }

            Array.Sort(nums);
            subsets.Add(new List<int>());
            int j = 0, k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                j = 0;

                // Handle dupes
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    j = k + 1;
                }

                k = subsets.Count - 1;

                while (j <= k)
                {
                    List<int> set = new List<int>(subsets[j]);                    
                    set.Add(nums[i]);                    
                    subsets.Add(set);
                    j++;
                }            
            }

            return subsets;
        }

        public static IList<IList<int>> FindSubsets(int[] nums)
        {
            IList<IList<int>> subsets = new List<IList<int>>();

            if (nums == null)
            {
                return null;
            }

            // Start with an empty set: [[]]
            subsets.Add(new List<int>());
            // Add the first number to all the existing subsets, then the 2nd, and so on...
            for (int i = 0; i < nums.Length; i++)
            {
                int size = subsets.Count;
                for (int j = 0; j < size; j++)
                {
                    List<int> set = new List<int>(subsets[j])
                    {
                        nums[i]
                    };
                    subsets.Add(set);
                }
            }

            return subsets;
        }
    }
}
