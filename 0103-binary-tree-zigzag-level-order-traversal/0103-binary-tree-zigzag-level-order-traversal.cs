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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        if(root == null)
            return [];
        var res = new List<IList<int>>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        bool sw = false;
        q.Enqueue(root);
        while(q.Count > 0){
            var cnt = q.Count;
            var l =new List<int>();
            while(cnt-- > 0){
                var currNode = q.Dequeue();
                if(sw){
                    l.Insert(0,currNode.val);
                }else{
                    l.Add(currNode.val);
                }
                if(currNode.left != null)
                    q.Enqueue(currNode.left);
                if(currNode.right != null)
                    q.Enqueue(currNode.right);
            }
            sw = !sw;
            res.Add(l);
        }
        return res;
    }
}