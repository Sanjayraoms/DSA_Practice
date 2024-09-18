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
    public int GoodNodes(TreeNode root) {
        int goodNodes = 1;
        void Traverse(TreeNode node, TreeNode currGoodNode){
            if(node.right !=null){
                if(node.right.val >= currGoodNode.val){
                   goodNodes++;
                   Traverse(node.right,node.right);
                }else
                    Traverse(node.right,currGoodNode);
            }
            if(node.left !=null){
                if(node.left.val >= currGoodNode.val){
                   goodNodes++;
                   Traverse(node.left,node.left);
                }else
                    Traverse(node.left,currGoodNode);
            }
        }
        Traverse(root,root);
        return goodNodes;
    }
}