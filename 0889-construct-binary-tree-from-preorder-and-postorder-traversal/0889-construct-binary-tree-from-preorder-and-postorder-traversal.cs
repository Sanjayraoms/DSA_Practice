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
    public TreeNode ConstructFromPrePost(int[] preorder, int[] postorder) {
        int N = preorder.Length;
        var posrorderIdx = new Dictionary<int,int>();
        for(int i = 0; i < postorder.Length; i++){
            posrorderIdx[postorder[i]] = i;
        }

        TreeNode build(int i1, int i2, int j1){
            if(i1 > i2)
                return null;
            var root = new TreeNode(preorder[i1]);
            if(i1 != i2){
                var left_val = preorder[i1+1];
                var mid = posrorderIdx[left_val];
                var left_size = mid - j1 + 1;

                root.left = build(i1+1, i1+left_size, j1);
                root .right = build(i1+left_size+1,i2,mid+1);
            }
            return root;
        }

        return build(0,N-1,0);
    }
}