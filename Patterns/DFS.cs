using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Patterns
{
    class DFS
    {
        public static void RunTests()
        {
            string testPattern = "DFS";
            Helpers.PrintStartTests(testPattern);
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
            Console.WriteLine($"numPaths: {numPaths}");
            sum = 18;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Checking root {root.Val} for path sum: {sum}");
            Console.WriteLine("------------------------------------------");
            numPaths = PathsForSumIter(root, sum);
            Console.WriteLine($"numPaths: {numPaths}");
            sum = 23;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Checking root {root.Val} for path sum: {sum}");
            Console.WriteLine("------------------------------------------");
            numPaths = PathsForSumIter(root, sum);
            Console.WriteLine($"numPaths: {numPaths}");
            Console.WriteLine("--------------------------");
            Console.WriteLine("PathsForSumRec");
            Console.WriteLine("--------------------------");
            root = new TreeNode(12);
            root.Left = new TreeNode(7);
            root.Right = new TreeNode(1);
            root.Left.Left = new TreeNode(4);
            root.Right.Left = new TreeNode(10);
            root.Right.Right = new TreeNode(5);
            sum = 11;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Checking root {root.Val} for path sum: {sum}");
            Console.WriteLine("------------------------------------------");
            numPaths = PathsForSumRec(root, sum);
            Console.WriteLine($"numPaths: {numPaths}");
            sum = 18;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Checking root {root.Val} for path sum: {sum}");
            Console.WriteLine("------------------------------------------");
            numPaths = PathsForSumRec(root, sum);
            Console.WriteLine($"numPaths: {numPaths}");
            sum = 23;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Checking root {root.Val} for path sum: {sum}");
            Console.WriteLine("------------------------------------------");
            numPaths = PathsForSumRec(root, sum);
            Console.WriteLine($"numPaths: {numPaths}");

            string name = "TreeDiameter";
            Helpers.PrintStartFunctionTest(name);
            var treeInfo = TreeDiameter(root);
            Console.WriteLine($"maxPath: {treeInfo.Item1}, maxDepth: {treeInfo.Item2}");
            root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);
            root.Left.Left = new TreeNode(4);
            root.Right.Left = new TreeNode(5);
            root.Right.Right = new TreeNode(6);
            treeInfo = TreeDiameter(root);
            Console.WriteLine($"maxPath: {treeInfo.Item1}, maxDepth: {treeInfo.Item2}");
            root.Left.Left = null;
            root.Right.Left.Left = new TreeNode(7);
            root.Right.Left.Right = new TreeNode(8);
            root.Right.Right.Left = new TreeNode(9);
            root.Right.Left.Right.Left = new TreeNode(10);
            root.Right.Right.Left.Left = new TreeNode(11);
            treeInfo = TreeDiameter(root);
            Console.WriteLine($"maxPath: {treeInfo.Item1}, maxDepth: {treeInfo.Item2}");
            root.Right.Left.Right.Left.Left = new TreeNode(9);
            treeInfo = TreeDiameter(root);
            Console.WriteLine($"maxPath: {treeInfo.Item1}, maxDepth: {treeInfo.Item2}");
            root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);
            root.Left.Left = new TreeNode(4);
            root.Right.Left = new TreeNode(5);
            root.Right.Right = new TreeNode(6);
            Console.WriteLine($"maxPathSum: {MaxPathSum(root)}");
            root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);
            Console.WriteLine($"maxPathSum: {MaxPathSum(root)}");
            root.Left.Left = new TreeNode(1);
            root.Left.Right = new TreeNode(3);
            root.Right.Left = new TreeNode(5);
            root.Right.Right = new TreeNode(6);
            root.Right.Left.Left = new TreeNode(7);
            root.Right.Left.Right = new TreeNode(8);
            root.Right.Right.Left = new TreeNode(9);
            Console.WriteLine($"maxPathSum: {MaxPathSum(root)}");
            root = new TreeNode(-1);
            root.Left = new TreeNode(-3);
            Console.WriteLine($"maxPathSum: {MaxPathSum(root)}");

            Helpers.PrintEndTests(testPattern);
        }

        private static int _maxPathSum = 0;

        public static (int MaxPath, int MaxDepth) MaxPathSum(TreeNode root)
        {
            if (root == null)
            {
                return (0, 0);
            }

            if (root.Left == null && root.Right == null)
            {
                return (root.Val, 1);
            }

            var leftInfo = MaxPathSum(root.Left);
            var rightInfo = MaxPathSum(root.Right);

            int maxDepth = 1 + Math.Max(leftInfo.MaxDepth, rightInfo.MaxDepth);
            int maxChildPath = Math.Max(leftInfo.MaxPath, rightInfo.MaxPath);
            int maxPath = root.Val + leftInfo.MaxPath + rightInfo.MaxPath;
            
            return (Math.Max(maxPath, maxChildPath), maxDepth);
        }

        public static (int MaxPath, int MaxDepth) TreeDiameter(TreeNode root)
        {
            if (root == null)
            {
                return (0, 0);
            }

            if (root.Left == null && root.Right == null)
            {
                return (0, 1);
            }

            var leftInfo = TreeDiameter(root.Left);
            var rightInfo = TreeDiameter(root.Right);
            
            int maxDepth = 1 + Math.Max(leftInfo.MaxDepth, rightInfo.MaxDepth);            
            int maxChildPath = Math.Max(leftInfo.MaxPath, rightInfo.MaxPath);
            int maxPath = 1 + leftInfo.MaxDepth + rightInfo.MaxDepth;

            return (Math.Max(maxPath, maxChildPath), maxDepth);
        }

        // TreeDFS
        public static int PathsForSumIter(TreeNode root, int sum)
        {
            return PathsForSumIter(new Stack<TreeNode>(), root, sum);
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

        public static int PathsForSumRec(TreeNode root, int sum)
        {
            int numPaths = 0, leftNumPaths = 0, rightNumPaths = 0;

            if (root == null)
            {
                return 0;
            }

            if (root.Val == sum)
            {
                numPaths++;
            }

            leftNumPaths += PathsForSumRec(root.Left, sum - root.Val) + PathsForSumRec(root.Left, sum);
            rightNumPaths += PathsForSumRec(root.Right, sum - root.Val) + PathsForSumRec(root.Right, sum);

            numPaths += leftNumPaths + rightNumPaths;

            return numPaths;
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
