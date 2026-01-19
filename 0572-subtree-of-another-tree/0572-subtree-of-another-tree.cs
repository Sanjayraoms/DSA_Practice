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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root.val == subRoot.val){
            if(sameTree(root,subRoot)){
                return true;
            }
        }
        if(root.left != null){
            if(IsSubtree(root.left, subRoot))
                return true;
        } 
        if(root.right != null){
            if(IsSubtree(root.right, subRoot))
                return true;
        } 
        return false;
    }

    private bool sameTree(TreeNode t1, TreeNode t2){
        if(t1 == null || t2 == null)
            return t1 == t2;
        return t1.val == t2.val && sameTree(t1.right, t2.right) && sameTree(t1.left,t2.left);
    }
}