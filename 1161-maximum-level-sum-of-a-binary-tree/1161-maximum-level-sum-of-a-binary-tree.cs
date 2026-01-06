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
        int level = 0;
        int maxlevel = 0;
        int currMax = root.val;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0){
            var currCnt = q.Count;
            var currSum = 0;
            level++;
            while(currCnt-- > 0){
                var dq = q.Dequeue();
                currSum += dq.val;
                if(dq.left != null)
                    q.Enqueue(dq.left);
                if(dq.right != null)
                    q.Enqueue(dq.right);
            }
            if(currSum > currMax){
                maxlevel = level;
                currMax = currSum;
            }
        }
        return maxlevel;
    }
}