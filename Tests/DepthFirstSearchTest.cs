namespace CodingPatterns.Tests
{
    using CodingPatterns.DataStructures;
    using CodingPatterns.Patterns;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using FluentAssertions;

    [TestClass]
    public class DepthFirstSearchTest
    {
        [DataTestMethod]
        [DataRow(10, false)]
        [DataRow(23, true)]
        [DataRow(16, false)]
        [DataRow(25, false)]
        [DataRow(28, true)]
        public void TestHasPathSum(int sum, bool expectedResult)
        {
            TreeNode root = new TreeNode(12)
            {
                Left = new TreeNode(7),
                Right = new TreeNode(1)
            };
            root.Left.Left = new TreeNode(9);
            root.Right.Left = new TreeNode(10);
            root.Right.Right = new TreeNode(5);

            DFS.HasPathSum(root, sum).Should().Be(expectedResult);
        }
    }
}
