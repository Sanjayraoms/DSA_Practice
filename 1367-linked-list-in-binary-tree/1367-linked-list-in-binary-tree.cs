/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
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
    public bool IsSubPath(ListNode head, TreeNode root) {
        Queue<TreeNode> tree = new Queue<TreeNode>();
        tree.Enqueue(root);
        var currListNode = head;
        while(tree.Count > 0){
            var currTreeNode = tree.Dequeue();
            if(currTreeNode.val == head.val){
                if(head.next == null)
                    return true;
                if(Traverse(currTreeNode,head))
                    return true;
            }
            if(currTreeNode.left != null)
               tree.Enqueue(currTreeNode.left);
            if(currTreeNode.right != null)
               tree.Enqueue(currTreeNode.right);
        }
        bool Traverse(TreeNode node, ListNode current){
            currListNode = current;
            if(currListNode.next == null)
               return true;
            else
               currListNode = currListNode.next;

            if(node.left != null && node.left.val == currListNode.val){
                if(Traverse(node.left,current.next))
                   return true;
            }
            if(node.right != null && node.right.val == current.next.val){
                if(Traverse(node.right,current.next))
                   return true;
            }  
            return false;
        }
        return false;
    }
}