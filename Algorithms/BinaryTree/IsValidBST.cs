namespace Algorithms.BinaryTree
{
    public class IsValidBST
    {
        private TreeNode prev;

        public bool Solution(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            if (!Solution(root.left))
            {
                return false;
            }

            if (prev != null && root.val <= prev.val)
            {
                return false;
            }

            prev = root;

            return Solution(root.right);
        }
    }
}
