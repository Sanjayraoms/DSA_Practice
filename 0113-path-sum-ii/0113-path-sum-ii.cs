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
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        List<IList<int>> allPaths = new List<IList<int>>();
        void Traverse(TreeNode node, int tSum, List<int> path){
            path.Add(node.val);
            if(node.left == null && node.right == null && tSum == 0)
                allPaths.Add(new List<int>(path));
            if(node.left != null) Traverse(node.left,tSum - node.left.val, new List<int>(path));
            if(node.right != null) Traverse(node.right,tSum - node.right.val, new List<int>(path));
        }
        if(root != null)
            Traverse(root,targetSum - root.val,new List<int>());
        return allPaths;
    }
}