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
    public int MinimumOperations(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int res = 0;
        while(q.Count > 0){
            int[] level = new int[q.Count];
            var len = q.Count;
            var idx = 0;
            while(len-- > 0){
                var currNode = q.Dequeue();
                level[idx++] = currNode.val;
                if(currNode.left != null)
                    q.Enqueue(currNode.left);
                if(currNode.right != null)
                    q.Enqueue(currNode.right);
            }
            res += CountSwaps(level);
        }
        return res;
    }

    public int CountSwaps(int[] nums){
        int cnt = 0;
        int[] sorted = new int[nums.Length];
        Array.Copy(nums,sorted,nums.Length);
        Array.Sort(sorted);
        Dictionary<int,int> mapIdx = new Dictionary<int,int>();
        for(int i = 0; i< nums.Length; i++){
            mapIdx[nums[i]] = i;
        }
        for(int i = 0; i< nums.Length; i++){
            if(nums[i] != sorted[i]){
                var j = mapIdx[sorted[i]];
                (nums[i],nums[j]) = (nums[j],nums[i]);
                mapIdx[nums[j]] = j;
                cnt++;
            }
        }
        return cnt;
    }
}