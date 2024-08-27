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
    public ListNode OddEvenList(ListNode head) {
        if(head == null || head.next == null || head.next.next == null)
           return head;
        Queue<ListNode> q = new Queue<ListNode>();
        var currOdd = head;
        while(currOdd.next != null){
            q.Enqueue(currOdd.next);
            if(currOdd.next.next != null){
                currOdd.next = currOdd.next.next;
                currOdd = currOdd.next;
            }else
                break;
        }
        while(q.Count > 0){
            currOdd.next = q.Dequeue();
            currOdd = currOdd.next;
        }
        currOdd.next = null;
        return head;
    }
}