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
    public IList<int> PostorderTraversal(TreeNode root) {
        if(root == null)
            return [];
        List<int> visited = new();
        if(root.left != null) visited.AddRange(PostorderTraversal(root.left));
        if(root.right != null) visited.AddRange(PostorderTraversal(root.right));
        visited.Add(root.val);
        return visited;
    }
}