using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Algorithms
{
    // Directed graph is defined by edges [vStart, vEnd], where vStart is the start vertex and vEnd is the end vertex.
    // Ex: [1, 0], [2, 1], [3, 2], [3, 1]
    //
    //     3
    //    / \
    //   2   |
    //   |\  |
    //   | \ |
    //   |  \|
    //   0   1

    class TopologicalSort
    {
        public int NumVertices { get; set; }
        int[][] Graph { get; set; }
        public IList<int> AdjacencyList { get; set; }
        public IList<int> SourceVertices { get; set; }
        public IList<int> SinkVertices { get; set; }

        public TopologicalSort() { }

        public TopologicalSort(int[][] g, int n = 0) 
        {
            Graph = g;
            NumVertices = n;
            InitVertices();
        }

        /// <summary>
        /// Topological Sort for (directed) Graph
        /// </summary>
        /// <returns>Topologically sorted edge array</returns>
        public IList<int> DoSort()
        {
            // BFS for source nodes
            // - Find source nodes
            // - Queue up source nodes

            return null;
        }


        private void InitVertices()
        {
            SourceVertices = new List<int>();
            int vCount = 0;
            // Find the count of incoming edges for each vertex
            Dictionary<int, int> edgeCounts = new Dictionary<int, int>();

            Console.WriteLine("Initializing...");
            for (int i = 0; i < Graph.Length; i++)
            {
                if (!edgeCounts.ContainsKey(Graph[i][0]))
                {
                    edgeCounts.Add(Graph[i][0], 0);
                    vCount++;
                }
                if (!edgeCounts.ContainsKey(Graph[i][1]))
                {
                    edgeCounts.Add(Graph[i][1], 0);
                    vCount++;
                }

                edgeCounts[Graph[i][1]]++;
            }

            if (vCount != NumVertices)
            {
                if (NumVertices > 0)
                {
                    Console.WriteLine("ERROR: Incorrect vertex count!");
                    Console.WriteLine($"\tNumVertices given was {NumVertices}, but found {vCount} vert{(vCount != 1 ? "ices" : "ex")}");
                }

                Console.WriteLine($"\tUpdating NumVertices to {vCount}");
            }

            NumVertices = vCount;

            // Calculate source vertices (no incoming edges)
            foreach (KeyValuePair<int, int> pair in edgeCounts)
            {
                Console.WriteLine($"Vertex: {pair.Key} has {pair.Value} edg{(pair.Value != 1 ? "es" : "e")}");
                if (pair.Value == 0)
                {
                    SourceVertices.Add(pair.Key);
                }
            }

            // Calculate sink vertices (no outgoing edges)
        }
    }
}
