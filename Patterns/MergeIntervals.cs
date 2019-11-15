using CodingPatterns.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Patterns
{
    class MergeIntervals
    {
        public static void RunTests()
        {
            List<int[]> intervals, left, right, appts, meetings, result, jobs;
            int[] insert;
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

            name = "InsertInterval";
            Helpers.PrintStartFunctionTest(name);
            intervals = new List<int[]>();
            intervals.Add(new int[] { 1, 3 });
            intervals.Add(new int[] { 5, 7 });
            intervals.Add(new int[] { 8, 12 });
            Console.WriteLine("intervals");
            Helpers.PrintList(intervals);
            insert = new int[] { 4, 6 };
            result = InsertInterval(intervals, insert);
            Console.WriteLine("result");
            Helpers.PrintList(result);
            Console.WriteLine("intervals");
            Helpers.PrintList(intervals);
            insert = new int[] { 4, 10 };
            result = InsertInterval(intervals, insert);
            Console.WriteLine("result");
            Helpers.PrintList(result);
            intervals = new List<int[]>();
            intervals.Add(new int[] { 2, 3 });
            intervals.Add(new int[] { 5, 7 });
            Console.WriteLine("intervals");
            Helpers.PrintList(intervals);
            insert = new int[] { 1, 4 };
            result = InsertInterval(intervals, insert);
            Console.WriteLine("result");
            Helpers.PrintList(result);

            name = "IntervalIntersection";
            Helpers.PrintStartFunctionTest(name);
            left = new List<int[]>
            {
                new int[] { 1, 3 },
                new int[] { 5, 6 },
                new int[] { 7, 9 }
            };
            right = new List<int[]>
            {
                new int[] { 2, 3 },
                new int[] { 5, 7 }
            };
            result = IntervalIntersection(left, right);
            Console.WriteLine("result");
            Helpers.PrintList(result);
            left = new List<int[]>
            {
                new int[] { 1, 3 },
                new int[] { 5, 7 },
                new int[] { 9, 12 }
            };
            right = new List<int[]>
            {
                new int[] { 5, 10 }
            };
            result = IntervalIntersection(left, right);
            Console.WriteLine("result");
            Helpers.PrintList(result);
            left = new List<int[]>
            {
                new int[] { 1, 3 },
                new int[] { 5, 7 },
                new int[] { 9, 12 }
            };
            right = new List<int[]>
            {
                new int[] { 6, 8 },
                new int[] { 10, 11 }
            };
            result = IntervalIntersection(left, right);
            Console.WriteLine("result");
            Helpers.PrintList(result);

            name = "CanAttendAppts";
            Helpers.PrintStartFunctionTest(name);
            appts = new List<int[]>
            {
                new int[] { 1, 4 },
                new int[] { 2, 5 },
                new int[] { 7, 9 }
            };
            Helpers.PrintList(appts);
            Console.WriteLine($"=>{CanAttendAppts(appts)}");
            appts = new List<int[]>
            {
                new int[] { 6, 7 },
                new int[] { 2, 4 },
                new int[] { 8, 12 }
            };
            Helpers.PrintList(appts);
            Console.WriteLine($"=>{CanAttendAppts(appts)}");
            appts = new List<int[]>
            {
                new int[] { 4, 5 },
                new int[] { 2, 3 },
                new int[] { 3, 6 }
            };
            Helpers.PrintList(appts);
            Console.WriteLine($"=>{CanAttendAppts(appts)}");

            name = "MinMeetingRooms";
            Helpers.PrintStartFunctionTest(name);
            meetings = new List<int[]>
            {
                new int[] { 1, 4 },
                new int[] { 2, 5 },
                new int[] { 7, 9 }
            };
            Helpers.PrintList(meetings);
            Console.WriteLine($"->{MinMeetingRooms(meetings)}");
            Console.WriteLine($"->{MinMeetingRoomsHeap(meetings)}");
            meetings = new List<int[]>
            {
                new int[] { 6, 7 },
                new int[] { 2, 4 },
                new int[] { 8, 12 }
            };
            Helpers.PrintList(meetings);
            Console.WriteLine($"->{MinMeetingRooms(meetings)}");
            Console.WriteLine($"->{MinMeetingRoomsHeap(meetings)}");
            meetings = new List<int[]>
            {
                new int[] { 1, 4 },
                new int[] { 2, 3 },
                new int[] { 3, 6 }
            };
            Helpers.PrintList(meetings);
            Console.WriteLine($"->{MinMeetingRooms(meetings)}");
            Console.WriteLine($"->{MinMeetingRoomsHeap(meetings)}");
            meetings = new List<int[]>
            {
                new int[] { 4, 5 },
                new int[] { 2, 3 },
                new int[] { 2, 4 },
                new int[] { 3, 5 }
            };
            Helpers.PrintList(meetings);
            Console.WriteLine($"->{MinMeetingRooms(meetings)}");
            Console.WriteLine($"->{MinMeetingRoomsHeap(meetings)}");

            name = "MinMeetingRooms";
            Helpers.PrintStartFunctionTest(name);
            jobs = new List<int[]>
            {
                new int[] { 1, 4, 3 },
                new int[] { 2, 5, 4 },
                new int[] { 7, 9, 6 }
            };
            Helpers.PrintList(jobs);
            Console.WriteLine($"maxLoad: {MaxCpuLoad(jobs)}");
            jobs = new List<int[]>
            {
                new int[] { 6, 7, 10 },
                new int[] { 2, 4, 11 },
                new int[] { 8, 12, 15 }
            };
            Helpers.PrintList(jobs);
            Console.WriteLine($"maxLoad: {MaxCpuLoad(jobs)}");
            jobs = new List<int[]>
            {
                new int[] { 1, 4, 2 },
                new int[] { 2, 4, 1 },
                new int[] { 3, 6, 5 }
            };
            Helpers.PrintList(jobs);
            Console.WriteLine($"maxLoad: {MaxCpuLoad(jobs)}");



            Helpers.PrintEndTests(testPattern);
        }

        public static int MaxCpuLoad(List<int[]> jobs)
        {
            Stack<int> jobStack = new Stack<int>();
            int[][] start;
            int[] end;
            int i = 0, j = 0, cpuLoad = 0, maxLoad = 0;

            if (jobs == null)
            {
                return 0;
            }

            start = new int[jobs.Count][];
            end = new int[jobs.Count];
            jobs.Sort((x, y) => x[0].CompareTo(y[0]));

            for (i = 0; i < jobs.Count; i++)
            {
                start[i] = new int[] { jobs[i][0], jobs[i][2] };
                end[i] = jobs[i][1];
            }

            i = 0;
            j = 0;
            while (i < start.Length && j < end.Length)
            {
                if (start[i][0] < end[j])
                {
                    jobStack.Push(start[i][1]);
                    cpuLoad += start[i][1];
                    i++;
                }
                else
                {
                    cpuLoad -= jobStack.Pop();
                    j++;
                }

                maxLoad = Math.Max(maxLoad, cpuLoad);
            }

            while (i < start.Length)
            {
                jobStack.Push(start[i][1]);
                cpuLoad += start[i][1];
                i++;
            }

            maxLoad = Math.Max(maxLoad, cpuLoad);

            return maxLoad;
        }

        public static int MinMeetingRoomsHeap(List<int[]> meetings)
        {
            int minRooms = 0;
            MinHeap<int[]> heap = new MinHeap<int[]>(Constants.CompareCoordY);

            meetings.Sort((x, y) => x[0].CompareTo(y[0]));

            // For each meeting, remove all meetings from heap with end time <= meeting start time
            // Add meeting to heap
            // minRooms = Max(minRooms, heap.Count)
            foreach (int[] meeting in meetings)
            {
                while (heap.Count > 0 && meeting[0] >= heap.Peek()[1])
                {
                    heap.Remove();
                }

                heap.Add(meeting);
                minRooms = Math.Max(minRooms, heap.Count);
                Console.WriteLine($"heap after adding meeting [{meeting[0]},{meeting[1]}]:\n{heap.ToString()}");
            }            
            
            return minRooms;
        }

        public static int MinMeetingRooms(List<int[]> meetings)
        {
            int minRooms = 0, start = 0, end = 0;

            if (meetings == null || meetings.Count < 1)
            {
                return 0;
            }

            // Start with 1 room for all meetings (assume no overlap)
            minRooms = 1;

            // Sort meetings by start time ascending
            meetings.Sort((x, y) => x[0].CompareTo(y[0]));
            
            // Start with first meeting
            start = meetings[0][0];
            end = meetings[0][1];

            // Use merge interval algorithm to find any overlaps
            for (int i = 1; i < meetings.Count; i++)
            { 
                if ((start < meetings[i][0] && meetings[i][0] < end) ||
                    (meetings[i][0] < start && start < meetings[i][1]))
                {
                    // Add 1 room for each additional overlap
                    minRooms++;
                    start = Math.Max(start, meetings[i][0]);
                    end = Math.Min(end, meetings[i][1]);
                }
                else
                {
                    start = meetings[i][0];
                    end = meetings[i][1];
                }
            }

            return minRooms;
        }

        public static bool CanAttendAppts(List<int[]> appts)
        {
            if (appts == null)
            {
                return true;
            }

            appts.Sort((x, y) => x[0].CompareTo(y[0]));

            // If there is any overlap between appointments, person can not attend all appts           
            for (int i = 1; i < appts.Count; i++)
            {
                if (appts[i][0] < appts[i - 1][1])
                {
                    return false;
                }
            }

            return true;
        }

        public static List<int[]> IntervalIntersection(List<int[]> left, List<int[]> right)
        {
            List<int[]> merged = new List<int[]>();
            int i = 0, j = 0;

            if (left == null)
            {
                return right;
            }
            if (right == null)
            {
                return left;
            }

            // Check each next interval pair from left & right
            while (i < left.Count && j < right.Count)
            {
                if ((left[i][0] >= right[j][0] && left[i][0] <= right[j][1]) ||
                    (right[j][0] >= left[i][0] && right[j][0] <= left[i][1]))
                {
                    merged.Add(new int[] { Math.Max(left[i][0], right[j][0]), Math.Min(left[i][1], right[j][1]) });
                }

                if (left[i][1] < right[j][1])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return merged;
        }

        public static List<int[]> InsertInterval(List<int[]> intervals, int[] insert)
        {
            List<int[]> merged = new List<int[]>();
            int start = 0, end = 0, i;

            if (intervals == null || insert == null)
            {
                return intervals;
            }

            // Find where insert overlaps
            // Make start = insert[0] & end = insert[1]
            // Find where start <= intervals[i][1] || intervals[i][0] <= end

            start = insert[0];
            end = insert[1];

            for (i = 0; i < intervals.Count && intervals[i][1] < start; i++)
            {
                merged.Add(intervals[i]);
            }
            
            start = Math.Min(start, intervals[i][0]);
            end = Math.Max(end, intervals[i][1]);
            
            for (i += 1; i < intervals.Count; i++)
            {
                if (intervals[i][0] <= end)
                {
                    end = Math.Max(end, intervals[i][1]);
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
