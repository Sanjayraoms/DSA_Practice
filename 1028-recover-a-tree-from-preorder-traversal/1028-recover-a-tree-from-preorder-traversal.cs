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
    public TreeNode RecoverFromPreorder(string traversal) {
        Stack<TreeNode> st = new Stack<TreeNode>();
        int dashes = 0;
        int i = 0;

        while(i < traversal.Length){
            if(traversal[i] == '-'){
                dashes++;
                i++;
            }
            else{
                var j = i;
                while(j < traversal.Length && traversal[j] != '-')
                    j++;
                var val = Convert.ToInt32(traversal.Substring(i,j-i));
                var curr = new TreeNode(val);

                while(st.Count > dashes)
                    st.Pop();
                if(st.Count > 0){
                    if(st.Peek().left == null)
                        st.Peek().left = curr;
                    else
                        st.Peek().right = curr;
                }
                st.Push(curr);
                i = j;
                dashes = 0;
            }
        }
        while(st.Count > 1)
            st.Pop();
        return st.Peek();
    }
}