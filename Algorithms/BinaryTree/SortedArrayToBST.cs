namespace Algorithms.BinaryTree
{
    /// <summary>
    /// Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.
    /// </summary>
    public class SortedArrayToBST
    {
        public TreeNode Solution(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return null;
            }

            return SolutionImpl(nums, 0, nums.Length - 1);
        }

        private TreeNode SolutionImpl(int[] nums, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            int mid = (start + end) / 2;
            var root = new TreeNode(nums[mid]);

            root.left = SolutionImpl(nums, start, mid - 1);
            root.right = SolutionImpl(nums, mid + 1, end);

            return root;
        }
    }
}
