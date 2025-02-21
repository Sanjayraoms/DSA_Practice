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
public class FindElements {
    HashSet<int> vals;
    TreeNode rootRe;
    public FindElements(TreeNode root) {
        vals = new HashSet<int>();
        rootRe = root;
        rootRe.val = 0;
        vals.Add(0);
        recoverTree(rootRe);
    }

    private void recoverTree(TreeNode node){
        if(node.left != null){
            node.left.val = 2*node.val + 1;
            recoverTree(node.left);
            vals.Add(node.left.val);
        }
        if(node.right != null){
            node.right.val = 2*node.val + 2;
            recoverTree(node.right);
            vals.Add(node.right.val);
        }
    }
    
    public bool Find(int target) {
        return vals.Contains(target);
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */