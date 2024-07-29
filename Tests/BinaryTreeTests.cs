using Algorithms.BinaryTree;

namespace Tests
{
    public class BinaryTreeTests
    {
        [Test]
        public void TestDFS()
        {
            var n = new TreeNode(5,
                new TreeNode(4,
                    new TreeNode(2),
                    new TreeNode(8,
                        new TreeNode(1))),
                new TreeNode(6,
                    new TreeNode(3),
                    new TreeNode(7)));

            TreeNode.DFS(n, Console.WriteLine);
        }

        [Test]
        public void TestBFS()
        {
            var n = new TreeNode(5,
                new TreeNode(4,
                    new TreeNode(2),
                    new TreeNode(8,
                        new TreeNode(1))),
                new TreeNode(6,
                    new TreeNode(3),
                    new TreeNode(7)));

            TreeNode.BFS(n, Console.WriteLine);
        }

        [Test]
        public void TestIsValidBinaryTree()
        {
            var n = new TreeNode(5,
                new TreeNode(1),
                new TreeNode(7,
                    new TreeNode(6),
                    new TreeNode(8)));

            var bt = new IsValidBST();
            var result = bt.Solution(n);

            Assert.True(result);
        }

        [Test]
        public void TestIsNotValidBinaryTree()
        {
            var n = new TreeNode(5,
                new TreeNode(4,
                    new TreeNode(2),
                    new TreeNode(8,
                        new TreeNode(1))),
                new TreeNode(6,
                    new TreeNode(3),
                    new TreeNode(7)));

            var bt = new IsValidBST();
            var result = bt.Solution(n);

            Assert.IsFalse(result);
        }

        [Test]
        public void TestLevelOrderBinaryTree()
        {
            var n = new TreeNode(3,
                new TreeNode(9),
                new TreeNode(20,
                    new TreeNode(15),
                    new TreeNode(7)));

            var bt = new LevelOrder();
            var result = bt.Solution(n);

            Assert.IsNotNull(result);
            // == [[3],[9,20],[15,7]]
        }

        [Test]
        public void TestSortedArrayToBST()
        {
            var n = new int[] { -10, -3, 0, 5, 9 };

            var bt = new SortedArrayToBST();
            var result = bt.Solution(n);

            Assert.IsNotNull(result);
            // == [0,-3,9,-10,null,5]
        }

        [Test]
        public void TestCommonAncestors()
        {
            var n = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(4),
                    new TreeNode(5)),
                new TreeNode(3,
                    new TreeNode(6),
                    new TreeNode(7)));

            var bt = new FindCommonAncestor();
            var result = bt.Solution(n, 5, 6);

            Assert.That(result, Is.EqualTo(1));
        }
    }
}
