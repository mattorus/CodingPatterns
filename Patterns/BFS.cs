using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPatterns.Patterns
{
    class BFS
    {

        public static void RunTests()
        {
            string testPattern = "BFS";
            Helpers.PrintStartTests(testPattern);

            string name = "BinaryTreeRightView";
            Helpers.PrintStartFunctionTest(name);
            TreeNode root = new TreeNode(12);
            root.Left = new TreeNode(7);
            root.Right = new TreeNode(1);
            root.Left.Left = new TreeNode(9);
            root.Right.Left = new TreeNode(10);
            root.Right.Right = new TreeNode(5);
            root.Left.Left.Left = new TreeNode(3);
            int[] rightView = BinaryTreeRightView(root);
            Helpers.PrintArray(rightView);
            root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);
            root.Left.Left = new TreeNode(4);
            root.Right.Left = new TreeNode(5);
            root.Right.Right = new TreeNode(6);
            root.Left.Left.Left = new TreeNode(7);
            rightView = BinaryTreeRightView(root);
            Helpers.PrintArray(rightView);

            root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);
            root.Left.Left = new TreeNode(4);
            root.Left.Right = new TreeNode(5);
            root.Right.Left = new TreeNode(6);
            root.Right.Right = new TreeNode(7);
            rightView = BinaryTreeRightView(root);
            Helpers.PrintArray(rightView);

            Helpers.PrintEndTests(testPattern);
        }

        public static int[] BinaryTreeRightView(TreeNode root)
        {
            List<int> rightView = new List<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();

            if (root == null)
            {
                return null;
            }

            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                TreeNode curNode = queue.Peek();
                for (int i = 0; i < levelSize; i++)
                {
                    curNode = queue.Dequeue();

                    if (curNode.Left != null)
                    {
                        queue.Enqueue(curNode.Left);
                    }
                    if (curNode.Right != null)
                    {
                        queue.Enqueue(curNode.Right);
                    }
                }

                rightView.Add(curNode.Val);
            }

            return rightView.ToArray();
        }
    }
}
