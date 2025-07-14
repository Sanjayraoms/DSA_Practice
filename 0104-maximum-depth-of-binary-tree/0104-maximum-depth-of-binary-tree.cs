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
    public int MaxDepth(TreeNode root) {
        //Base case
        if(root == null)
            return 0;

        //Hypothesis that this function gives height for any node
        int lh = MaxDepth(root.left);
        int rh = MaxDepth(root.right);

        //Induction we need to take max of left and right and add it to current node for total height
        return 1 + Math.Max(lh, rh);
    }
}