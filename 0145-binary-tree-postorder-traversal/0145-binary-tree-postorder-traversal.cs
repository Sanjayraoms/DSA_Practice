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
    public IList<int> PostorderTraversal(TreeNode root) {
        if(root != null)
            PostOrder(root);
        return visited;        
    }
    void PostOrder(TreeNode node){
        if(node.left!= null) PostOrder(node.left);
        if(node.right!=null) PostOrder(node.right);
        visited.Add(node.val);
    }
}