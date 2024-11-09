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
    public bool HasPathSum(TreeNode root, int targetSum) {
        int currSum = 0;
        bool hasPath = false;
        void Traverse(TreeNode node, int currSum){
            currSum = currSum + node.val;
            if(node.left == null && node.right == null && currSum == targetSum)
                hasPath = true;
            if(node.left != null) Traverse(node.left, currSum);
            if(node.right != null) Traverse(node.right, currSum);
        }
        if(root != null)
            Traverse(root,currSum);
        return hasPath;
    }
}