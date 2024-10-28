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
    public int MaxLevelSum(TreeNode root) {
        long maxSum = Int64.MinValue;
        long currmaxSum = Int64.MinValue;
        int level = 0;
        int currlevel = 0;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0){
            currlevel++;
            var ctr = q.Count;
            currmaxSum = 0;
            while(ctr > 0){
                var currNode = q.Dequeue();
                currmaxSum += currNode.val;
                if(currNode.left != null) q.Enqueue(currNode.left);
                if(currNode.right != null) q.Enqueue(currNode.right);
                ctr--;
            }
            if(currmaxSum > maxSum){
                maxSum = currmaxSum;
                level = currlevel;
            }
        }
        return level;
    }
}