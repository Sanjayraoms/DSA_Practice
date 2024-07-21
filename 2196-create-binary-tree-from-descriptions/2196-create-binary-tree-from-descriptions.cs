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
    public TreeNode CreateBinaryTree(int[][] descriptions) {
        Dictionary<int,TreeNode> DictNodes = new Dictionary<int,TreeNode>();
        HashSet<int> children = new HashSet<int>();
        foreach(int[] description in descriptions){
            int parent = description[0];
            int child = description[1];
            bool isLeft = (description[2] == 1);
            if(!DictNodes.ContainsKey(parent)){
                DictNodes.Add(parent, new TreeNode(parent));
            }
            var parentNode = DictNodes[parent];
            if(!DictNodes.ContainsKey(child)){
                DictNodes.Add(child, new TreeNode(child));
            }
            var childNode = DictNodes[child];
            if(isLeft){
                parentNode.left = childNode;
            }else{
                parentNode.right = childNode;
            }
            children.Add(child);
        }
        foreach(var item in DictNodes.Keys){
            if(!children.Contains(item)){
                return DictNodes[item];
            }
        }
        return null;
    }
}