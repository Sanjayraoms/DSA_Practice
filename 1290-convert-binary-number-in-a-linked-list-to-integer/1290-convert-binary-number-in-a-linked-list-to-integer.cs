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
    public int GetDecimalValue(ListNode head) {
        int res = 0;
        var curr = head;
        while(curr != null){
            res = (res << 1) | curr.val;
            curr = curr.next;
        }
        return res;
    }
}