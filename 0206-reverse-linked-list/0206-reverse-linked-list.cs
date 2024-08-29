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
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prevNode = null;
        ListNode currNode = head;
        ListNode swapNode = null;
        while(currNode != null){
            swapNode = currNode.next;
            currNode.next = prevNode;
            prevNode = currNode;
            currNode = swapNode;
        }
        head = prevNode;
        return head;
    }
}