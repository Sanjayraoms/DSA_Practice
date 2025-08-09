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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> visited = new();
        if(root == null)
            return visited;
        visited.Add(root.val);
        if(root.left != null) visited.AddRange(PreorderTraversal(root.left));
        if(root.right != null) visited.AddRange(PreorderTraversal(root.right));
        return visited;
    }
}