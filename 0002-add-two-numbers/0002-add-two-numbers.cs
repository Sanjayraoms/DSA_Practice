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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int carry = 0;
        ListNode sum = new ListNode();
        var curr = sum;
        while(l1 is not null || l2 is not null){
            var currSum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
            if(currSum > 9){
                carry = currSum / 10;
                currSum = currSum % 10;
            }else
                carry = 0;
            var newNode = new ListNode(currSum);
            curr.next = newNode;
            curr = curr.next;
            l1 = l1 == null ? null : l1.next;
            l2 = l2 == null ? null : l2.next;
        }
        if(carry > 0){
            var newNode = new ListNode(carry);
            curr.next = newNode;
        }
        return sum.next;
    }
}