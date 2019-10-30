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
            string name;
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
