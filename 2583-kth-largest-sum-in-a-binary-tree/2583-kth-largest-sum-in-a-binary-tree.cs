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
    public long KthLargestLevelSum(TreeNode root, int k) {
        long levelSum = 0;
        var queue = new Queue<TreeNode>();
        var priority = new PriorityQueue<long,long>();
        queue.Enqueue(root);
        while(queue.Count > 0){
            levelSum = 0;
            var cnt = queue.Count;
            while(cnt > 0){
                var currNode = queue.Dequeue();
                levelSum = levelSum + currNode.val;
                if(currNode.left != null)  queue.Enqueue(currNode.left);
                if(currNode.right != null)  queue.Enqueue(currNode.right);
                cnt--;
            }
            priority.Enqueue(levelSum,levelSum);
            if(priority.Count > k)  priority.Dequeue();
        }
        return priority.Count < k ? -1 : priority.Dequeue();
    }
}