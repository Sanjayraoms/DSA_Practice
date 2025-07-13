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
    public void ReorderList(ListNode head) {
        var slow = head;
        var fast = head;

        //Find the middle
        while(fast != null && fast.next != null){
            fast = fast.next.next;
            slow = slow.next;
        }
        var right = slow.next;

        //Reverse from the mid and reversed becomes right
        ListNode prev = slow.next = null;
        ListNode next = null;
        var curr = right;

        while(curr != null){
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        //Merge left and right
        var left = head;
        while(prev != null){
            var temp1 = left.next;
            var temp2 = prev.next;
            left.next = prev;
            prev.next = temp1;
            left = temp1;
            prev = temp2;

        }
    }
}