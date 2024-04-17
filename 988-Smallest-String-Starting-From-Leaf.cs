/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public string SmallestFromLeaf(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        Dictionary<TreeNode, string> nodeToSuffix = new Dictionary<TreeNode, string>();
        queue.Enqueue(root);
        nodeToSuffix.Add(root, ((char)('a' + root.val)).ToString());

        string result = null;

        while (queue.Count > 0) {
            TreeNode node = queue.Dequeue();
            string suffix = nodeToSuffix[node];

            if (node.left == null && node.right == null) {
                if (result == null || suffix.CompareTo(result) < 0) {
                    result = suffix;
                }
            }

            if (node.left != null) {
                queue.Enqueue(node.left);
                nodeToSuffix[node.left] = ((char)('a' + node.left.val)) + suffix;
            }
            if (node.right != null) {
                queue.Enqueue(node.right);
                nodeToSuffix[node.right] = ((char)('a' + node.right.val)) + suffix;
            }
        }

        return result;
    }
}