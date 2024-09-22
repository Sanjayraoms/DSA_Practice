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
        if(root == null)
            return [];
        List<int> visited = new List<int>();
        void Traverse(TreeNode node){
            if(node.left != null) Traverse(node.left);
            visited.Add(node.val);
            if(node.right != null) Traverse(node.right);
        }
        Traverse(root);
        return visited;
    }
}