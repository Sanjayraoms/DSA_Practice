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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        if(root == null)
            return [];
        var res = new List<IList<int>>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0){
            var len = q.Count;
            var currList = new List<int>();
            while(len-- > 0){
                var currNode = q.Dequeue();
                currList.Add(currNode.val);
                if(currNode.left != null)
                    q.Enqueue(currNode.left);
                if(currNode.right != null)
                    q.Enqueue(currNode.right);
            }
            res.Add(currList);
        }
        return res;
    }
}