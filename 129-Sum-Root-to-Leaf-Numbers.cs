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
    public int SumNumbers(TreeNode root) {
        if (root == null) return 0;

        int totalSum = 0;
        Queue<TreeNode> nodes = new Queue<TreeNode>();
        Queue<int> sums = new Queue<int>();

        nodes.Enqueue(root);
        sums.Enqueue(root.val);

        while (nodes.Count > 0) {
            TreeNode node = nodes.Dequeue();
            int currentSum = sums.Dequeue();

            if (node.left == null && node.right == null) {
                totalSum += currentSum;
            }

            if (node.left != null) {
                nodes.Enqueue(node.left);
                sums.Enqueue(currentSum * 10 + node.left.val);
            }

            if (node.right != null) {
                nodes.Enqueue(node.right);
                sums.Enqueue(currentSum * 10 + node.right.val);
            }
        }

        return totalSum;
    }
}