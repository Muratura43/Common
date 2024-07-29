namespace Algorithms.BinaryTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public override string ToString()
        {
            return val.ToString();
        }

        public static void DFS(TreeNode node, Action<TreeNode>? action = null)
        {
            if (node == null)
            {
                return;
            }

            action?.Invoke(node);

            if (node.left != null)
            {
                DFS(node.left, action);
            }

            if (node.right != null)
            {
                DFS(node.right, action);
            }
        }

        public static void BFS(TreeNode node, Action<TreeNode>? action = null)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var tempNode = queue.Dequeue();
                action?.Invoke(tempNode);

                if (tempNode.left != null)
                {
                    queue.Enqueue(tempNode.left);
                }

                if (tempNode.right != null)
                {
                    queue.Enqueue(tempNode.right);
                }
            }
        }
    }
}
