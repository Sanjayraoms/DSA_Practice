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
    public ListNode InsertGreatestCommonDivisors(ListNode head) {
        if(head.next == null)
           return head;
        ListNode nextNode = head.next;
        ListNode prevNode = head;

        while(nextNode != null){
            var hcf = gcd(prevNode.val, nextNode.val);
            var newNode = new ListNode(hcf,nextNode);
            prevNode.next = newNode;
            prevNode = nextNode;
            nextNode = prevNode.next;
        }

        int gcd(int a, int b){
            if(a==0)
               return b;
            if(b==0)
               return a;
            if(a==b)
               return a;
            if(a>b)
               return gcd(a-b,b);
            return gcd(a,b-a);
        }

        return head;
    }


}