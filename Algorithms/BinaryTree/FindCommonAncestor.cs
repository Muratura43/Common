namespace Algorithms.BinaryTree
{
    public class FindCommonAncestor
    {
        public int Solution(TreeNode root, int n, int m)
        {
            List<int> pathN = new List<int>();
            List<int> pathM = new List<int>();

            if (!FindPath(root, n, pathN) || !FindPath(root, m, pathM))
            {
                return -1;
            }

            int result = -1;
            for (int i = 0; i < pathN.Count && i < pathM.Count; i++)
            {
                if (pathN[i] != pathM[i])
                {
                    break;
                }

                result = pathN[i];
            }

            return result;
        }

        private bool FindPath(TreeNode root, int n, List<int> path)
        {
            if (root == null)
            {
                return false;
            }

            path.Add(root.val);

            if (root.val == n)
            {
                return true;
            }

            if (root.left != null && FindPath(root.left, n, path))
            {
                return true;
            }

            if (root.right != null && FindPath(root.right, n, path))
            {
                return true;
            }

            path.RemoveAt(path.Count() - 1);

            return false;
        }
    }
}
