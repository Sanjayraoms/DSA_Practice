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
    public int PathSum(TreeNode root, int targetSum) {
        int res = 0;

        void checkSum(TreeNode node,int currSum){
            if(node==null)
                return;
            currSum = currSum + node.val;
            if(currSum == targetSum)
                res++;
            if(node.left!=null) checkSum(node.left,currSum);
            if(node.right!=null) checkSum(node.right,currSum);
        }

        void Traverse(TreeNode node){
            if(node==null)
                return;
            checkSum(node,0);
            if(node.left!=null) Traverse(node.left);
            if(node.right!=null) Traverse(node.right);
        }
        Traverse(root);
        return res;
    }
}