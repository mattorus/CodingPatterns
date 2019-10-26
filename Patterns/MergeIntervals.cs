using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Patterns
{
    class MergeIntervals
    {
        public static void RunTests()
        {
            List<int[]> intervals;
            List<int[]> result = new List<int[]>();
            string name;
            string testPattern = "MERGEINTERVALS";
            Helpers.PrintStartTests(testPattern);
            
            name = "MergeIntervalOverlap";
            Helpers.PrintStartFunctionTest(name);
            intervals = new List<int[]>();
            intervals.Add(new int[] { 1, 4 });
            intervals.Add(new int[] { 2, 5 });
            intervals.Add(new int[] { 7, 9 });
            Console.WriteLine("intervals");
            Helpers.PrintList(intervals);
            result = MergeIntervalOverlap(intervals);
            Console.WriteLine("result");
            Helpers.PrintList(result);
            intervals = new List<int[]>();
            intervals.Add(new int[] { 6, 7 });
            intervals.Add(new int[] { 2, 4 });
            intervals.Add(new int[] { 5, 9 });
            Console.WriteLine("intervals");
            Helpers.PrintList(intervals);
            result = MergeIntervalOverlap(intervals);
            Console.WriteLine("result");
            Helpers.PrintList(result);
            intervals = new List<int[]>();
            intervals.Add(new int[] { 1, 4 });
            intervals.Add(new int[] { 2, 6 });
            intervals.Add(new int[] { 3, 5 });
            Console.WriteLine("intervals");
            Helpers.PrintList(intervals);
            result = MergeIntervalOverlap(intervals);
            Console.WriteLine("result");
            Helpers.PrintList(result);

            Helpers.PrintEndTests(testPattern);
        }

        public static List<int[]> MergeIntervalOverlap(List<int[]> intervals)
        {
            List<int[]> merged = new List<int[]>();
            int start = 0, end = 0;

            if (intervals == null || intervals.Count < 2)
            {
                return intervals;
            }            

            // Sort to ensure a.start <= b.start
            intervals.Sort((x, y) => x[0].CompareTo(y[0]));
                        
            start = intervals[0][0];
            end = intervals[0][1];

            // If prev interval start <= a.end, then prev interval end = max(a.end, b.end)
            // Otherwise, reset prev interval to current interval
            for (int i = 1; i < intervals.Count; i++)
            {
                if (intervals[i][0] <= end)
                {
                    end = Math.Max(intervals[i][1], end);
                }
                else
                {
                    merged.Add(new[] { start, end });
                    start = intervals[i][0];
                    end = intervals[i][1];
                }
            }

            merged.Add(new[] { start, end });

            return merged;            
        }
    }
}
