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
    public IList<int> RightSideView(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        List<int> right = new List<int>();
        int levelCtr = 0;
        TreeNode lastnode = null;
        if(root != null){
            q.Enqueue(root);
        }
        while(q.Count > 0){
            levelCtr = q.Count;
            while(levelCtr > 0){
                lastnode = q.Dequeue();
                if(lastnode.left != null) q.Enqueue(lastnode.left);
                if(lastnode.right != null) q.Enqueue(lastnode.right);
                levelCtr--;
            }            
            right.Add(lastnode.val);            
        }
        return right;
    }
}