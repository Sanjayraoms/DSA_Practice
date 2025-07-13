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
    public TreeNode ReverseOddLevels(TreeNode root) {
        var q = new List<TreeNode>();
        int level = 0;
        q.Add(root);
        while(q.Count > 0){
            var cnt = q.Count;
            if(level++ % 2 == 1){
                var left = 0;
                var right = q.Count - 1;
                while(left < right){
                    (q[left].val,q[right].val) = (q[right].val,q[left].val);
                    left++;
                    right--;
                }
            }
            while(cnt > 0){
                var currNode = q[0];
                q.Remove(currNode);
                if(currNode.right != null)
                    q.Add(currNode.right);
                if(currNode.left != null)
                    q.Add(currNode.left);
                cnt--;
            }
        }
        return root;
    }
}