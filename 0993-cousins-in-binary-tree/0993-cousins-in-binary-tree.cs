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
    public bool IsCousins(TreeNode root, int x, int y) {
        int twice = 0;
        int levelCtr = 0;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0){
            levelCtr = q.Count;
            twice = 0;
            while(levelCtr > 0){
                var currNode = q.Dequeue();
                if(currNode.right != null) q.Enqueue(currNode.right);
                if(currNode.left != null) q.Enqueue(currNode.left);
                if(currNode.right!= null && (currNode.right.val == x || currNode.right.val == y)){
                    twice++;
                    if(twice==2)
                        return true;
                    else{
                        levelCtr--;
                        continue;
                    }
                }
                if(currNode.left != null && (currNode.left.val == x || currNode.left.val == y)){
                    twice++;
                    if(twice==2)
                        return true;
                    else{
                        levelCtr--;
                        continue;
                    }
                }
                levelCtr--;
            }
        }
        return false;
    }
}