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
    List<int> visited = new List<int>();
    public IList<int> PreorderTraversal(TreeNode root) {
        if(root!=null)
            Traverse(root);
        return visited;
    }
    private void Traverse(TreeNode node){
        visited.Add(node.val);
        if(node.left!=null) Traverse(node.left);
        if(node.right!=null) Traverse(node.right);
    }
}