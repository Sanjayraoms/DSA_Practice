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
    public TreeNode SubtreeWithAllDeepest(TreeNode root) {
        TreeNode first = null, last = null;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0){
            var size = q.Count;
            first = q.Peek();
            while(size-- > 0){
                last = q.Dequeue();
                if(last.right != null) q.Enqueue(last.right);
                if(last.left != null) q.Enqueue(last.left);
            }
        }
        return LCA(root,first.val,last.val);
    }
    public TreeNode LCA(TreeNode root,int n1,int n2){
        if(root == null) return null;
        if(root.val == n1 || root.val == n2)
            return root;
        TreeNode left = LCA(root.left,n1,n2);
        TreeNode right = LCA(root.right,n1,n2);

        if(left != null && right != null) 
            return root;
        if(left != null) 
            return left;
        else 
            return right;
    }
}