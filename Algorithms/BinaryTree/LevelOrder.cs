namespace Algorithms.BinaryTree
{
    /// <summary>
    /// Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).
    /// </summary>
    public class LevelOrder
    {
        private Dictionary<int, IList<int>> levels = new Dictionary<int, IList<int>>();

        public IList<IList<int>> Solution(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();

            SolutionImpl(root, 0);

            foreach (var k in levels)
            {
                result.Add(k.Value);
            }

            return result;
        }

        private void SolutionImpl(TreeNode root, int level)
        {
            if (root == null)
            {
                return;
            }

            if (!levels.ContainsKey(level))
            {
                levels.Add(level, new List<int>());
            }

            levels[level].Add(root.val);

            SolutionImpl(root.left, level + 1);
            SolutionImpl(root.right, level + 1);
        }
    }
}
