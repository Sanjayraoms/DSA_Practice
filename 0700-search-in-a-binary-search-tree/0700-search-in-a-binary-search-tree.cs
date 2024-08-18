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
    public TreeNode SearchBST(TreeNode root, int val) {
        var currentNode = root;
        while(currentNode != null){
            if(currentNode.val == val)
               return currentNode;
            else{
                if(val > currentNode.val)
                   currentNode = currentNode.right;
                else
                   currentNode = currentNode.left;
            }
        }
        return currentNode;
    }
}