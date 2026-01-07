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
    public int MaxProduct(TreeNode root) {
        int MOD = 1_000_000_007;
        int totalSum = TraverseSum(root);
        long maxProduct = 0;

        long FindMaxProduct(TreeNode node){
            long currSum = node.val;
            if(node.right != null)
                currSum += FindMaxProduct(node.right);
            if(node.left != null)
                currSum += FindMaxProduct(node.left);
            maxProduct = Math.Max(maxProduct,(totalSum-currSum)*currSum);
            return currSum;
        }
        FindMaxProduct(root);
        return (int)(maxProduct % MOD);
    }
    public int TraverseSum(TreeNode root){
        var sum = root.val;
        if(root.right != null)
            sum += TraverseSum(root.right);
        if(root.left != null)
            sum += TraverseSum(root.left);
        return sum;
    }
}