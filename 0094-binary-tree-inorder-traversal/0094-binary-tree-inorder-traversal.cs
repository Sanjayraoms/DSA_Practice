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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> visited = new();
        if(root == null)
            return visited;
        if(root.left != null)
            visited.AddRange(InorderTraversal(root.left));
        visited.Add(root.val);
        if(root.right != null)
            visited.AddRange(InorderTraversal(root.right));
        return visited;
    }
}