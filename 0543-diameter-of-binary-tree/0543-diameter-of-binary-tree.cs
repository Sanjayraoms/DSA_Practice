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
    public int DiameterOfBinaryTree(TreeNode root) {
        int res = 0;

        int dfs(TreeNode node){
            if(node == null)
                return 0;
            var lh = dfs(node.left);
            var rh = dfs(node.right);
            res = Math.Max(res, lh+rh);
            return 1 + Math.Max(lh,rh);
        }
        dfs(root);
        return res;
    }
}