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
    public TreeNode ReplaceValueInTree(TreeNode root) {
        int lvlCtr = 0;
        int levelSum = 0;
        var queue = new Queue<TreeNode>();
        var levelSums = new List<int>();
        queue.Enqueue(root);
        while(queue.Count > 0){
            lvlCtr = queue.Count;
            levelSum = 0;
            while(lvlCtr > 0){
                var currNode = queue.Dequeue();
                levelSum += currNode.val;
                if(currNode.right != null) queue.Enqueue(currNode.right);
                if(currNode.left != null) queue.Enqueue(currNode.left);
                lvlCtr--;
            }
            levelSums.Add(levelSum);
        }
        root.val = 0;
        queue.Enqueue(root);
        var levelIndex = 1;
        var siblingSum = 0;
        while(queue.Count > 0){
            lvlCtr = queue.Count;
            while(lvlCtr > 0){
                var currNode = queue.Dequeue();
                siblingSum = 0;
                if(currNode.right != null)  siblingSum += currNode.right.val; 
                if(currNode.left != null)   siblingSum += currNode.left.val;
                if(currNode.right != null){
                    currNode.right.val = levelSums[levelIndex] - siblingSum;
                    queue.Enqueue(currNode.right);
                }
                if(currNode.left != null){
                    currNode.left.val = levelSums[levelIndex] - siblingSum;
                    queue.Enqueue(currNode.left);
                }
                lvlCtr--;
            }
            levelIndex++;
        }
        return root;
    }
}