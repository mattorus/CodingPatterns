using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Algorithms
{
    class BFSInfo
    {
        public int Distance { get; set; }
        public int Predecessor { get; set; }
        public BFSInfo()
        {
            Distance = -1;
            Predecessor = -1;
        }

        public BFSInfo(int d, int p)
        {
            Distance = d;
            Predecessor = p;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"  Distance: {Distance}\n  Predecessor: {Predecessor}");
        }
    }
    class BreadthFirstSearch
    {

        public static void RunTests()
        {
            string testPattern = "BREADTHFIRSTSEARCH";
            Helpers.PrintStartTests(testPattern);

            string name = "DoBFS";
            Helpers.PrintStartFunctionTest(name);
            int[][] graph = new int[][]
            {
                new int[] { 1 },
                new int[] { 0, 4, 5 },
                new int[] { 3, 4, 5},
                new int[] { 2, 6 },
                new int[] { 1, 2 },
                new int[] { 1, 2, 6 },
                new int[] { 3, 5 },
                new int[] { }
            };
            int source = 3;
            BFSInfo[] info = DoBFS(graph, source);
            for (int i = 0; i < info.Length; i++)
            {
                Console.WriteLine($"BFSInfo for Vertex {i}");
                if (info[i] != null)
                {
                    info[i].PrintInfo();
                }
            }

            Helpers.PrintEndTests(testPattern);
        }

        public static BFSInfo[] DoBFS(int[][] graph, int source)
        {
            BFSInfo[] info = new BFSInfo[graph.Length];
            Queue<int> queue = new Queue<int>();
            info[source] = new BFSInfo();
            info[source].Distance = 0;

            queue.Enqueue(source);

            while (queue.Count > 0)
            {
                int cur = queue.Dequeue();

                for (int i = 0; i < graph[cur].Length; i++)
                {
                    if (info[graph[cur][i]] == null)
                    {
                        info[graph[cur][i]] = new BFSInfo(info[cur].Distance + 1, cur);
                        queue.Enqueue(graph[cur][i]);
                    }
                }
            }

            return info;
        }
    }
}
