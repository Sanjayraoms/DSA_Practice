/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        var currNode = node;
        while(currNode != null){
            if(currNode.next != null){
                currNode.val = currNode.next.val;
            }
            if(currNode.next.next == null){
                currNode.next = null;
                break;
            }
            currNode = currNode.next;
        }
    }
}