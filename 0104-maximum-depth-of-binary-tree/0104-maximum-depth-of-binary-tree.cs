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
        int depth = 0;
        if(root == null)
            return depth;
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        while(q.Count > 0){
            var len = q.Count;
            depth++;
            while(len-- > 0){
                var curr = q.Dequeue();
                if(curr.left != null) q.Enqueue(curr.left);
                if(curr.right != null) q.Enqueue(curr.right);
            }
        }
        return depth;
    }
}