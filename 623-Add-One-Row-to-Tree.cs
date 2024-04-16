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
    public TreeNode AddOneRow(TreeNode root, int val, int depth) {
        if(depth == 1)
        {
            TreeNode node = new(val);
            node.left = root;
            root = node;
        }
        else
        {
            Helper(root, val, depth, 1);
        }
        return root;
    }

    void Helper(TreeNode root, int val, int depth, int level)
    {
        if(root == null)
        {
            return;
        }
        if(level == depth-1)
        {
            TreeNode node = new(val);
            node.left = root.left;
            root.left = node;

            node = new(val);
            node.right = root.right;
            root.right = node;

        }

        Helper(root.left, val, depth, level+1);
        Helper(root.right, val, depth, level+1);

    }
}