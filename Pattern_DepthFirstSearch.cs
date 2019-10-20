using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns
{
    class Pattern_DepthFirstSearch
    {

        public Pattern_DepthFirstSearch() { }

        // TreeDFS
        public static int PathsForSumIter(TreeNode root, int sum)
        {
            return PathsForSumIter(new Stack<TreeNode>(), root, sum);
        }

        public static void RunTests()
        {
            Console.WriteLine("PathsForSumIter");
            Console.WriteLine("--------------------------");
            TreeNode root = new TreeNode(12);
            root.Left = new TreeNode(7);
            root.Right = new TreeNode(1);
            root.Left.Left = new TreeNode(4);
            root.Right.Left = new TreeNode(10);
            root.Right.Right = new TreeNode(5);
            int sum = 11;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Checking root {root.Val} for path sum: {sum}");
            Console.WriteLine("------------------------------------------");
            int numPaths = PathsForSumIter(root, sum);
            Console.WriteLine($"Tree has {numPaths} pat{(numPaths != 1 ? "hs" : "h")}");
            sum = 18;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Checking root {root.Val} for path sum: {sum}");
            Console.WriteLine("------------------------------------------");
            numPaths = PathsForSumIter(root, sum);
            Console.WriteLine($"Tree has {numPaths} pat{(numPaths != 1 ? "hs" : "h")}");
            sum = 23;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Checking root {root.Val} for path sum: {sum}");
            Console.WriteLine("------------------------------------------");
            numPaths = PathsForSumIter(root, sum);
            Console.WriteLine($"Tree has {numPaths} pat{(numPaths != 1 ? "hs" : "h")}");
        }

        private static int PathsForSumIter(Stack<TreeNode> treeStack, TreeNode root, int sum)
        {
            TreeNode curNode = root;
            Stack<TreeNode> leftStack, rightStack;
            int leftCount = 0, rightCount = 0;

            if (curNode == null)
            {
                return 0;
            }

            if (curNode.Left == null && curNode.Right == null)
            {
                int count = 0;

                Console.Write($"  ");
                while (true)
                {
                    if (sum == curNode.Val)
                    {
                        Console.Write($"*");
                        count++;
                    }
                    Console.Write($"{curNode.Val}");

                    sum -= curNode.Val;

                    if (treeStack.Count == 0)
                    {   
                        break;
                    }
                    else
                    {
                        Console.Write("<-");
                    }

                    curNode = treeStack.Pop();
                }
                Console.WriteLine();

                return count;
            }
            else
            {
                treeStack.Push(curNode);
                // Need to reverse array of existing stack to make perfect copy
                TreeNode[] tree = treeStack.ToArray();
                Array.Reverse(tree); 
                leftStack = new Stack<TreeNode>(tree);
                rightStack = new Stack<TreeNode>(tree);

                leftCount += PathsForSumIter(leftStack, curNode.Left, sum);
                rightCount += PathsForSumIter(rightStack, curNode.Right, sum);

                return leftCount + rightCount;
            }
        }

        public static int PathsForSum(TreeNode root, int sum)
        {
            IList<IList<int>> paths = new List<IList<int>>();

            // Find and return all paths, that must end at leaf nodes, whose nodes add up to sum parameter
            // Algorithm:
            // - Recursive helper function:
            //   - Parameters - root, sum, curList
            //   - Return value - ??
            // - Start from each leaf node (recurse until left == null && right == null)
            //   - Add node val to total and head of curList
            //   - If total == sum, add list to paths
            //   - Else, return/move to other path
            
            return PathsForSumDFS(root, sum);
        }

        private static int PathsForSumDFS(TreeNode root, int sum)
        {
            return -1;
        }

        private static IList<IList<int>> PathsForSum(TreeNode root, int sum, int total, IList<IList<int>> paths, IList<int> curList)
        {
            if (curList == null)
            {
                curList = new List<int>();
            }

            if (root == null)
            {
                return null;
            }

            if (root.Left == null && root.Right == null)
            {
                if (total + root.Val <= sum)
                {
                    curList.Insert(0, root.Val);
                    if (total == sum)
                    {
                        paths.Add(curList);
                    }
                }
                
            }

            return paths;
        }

        // GraphDFS
    }
}
