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
    public int PairSum(ListNode head) {
        int maxSum = int.MinValue;
        int cntr = 1;
        int len = 0;
        Stack<int> rev = new Stack<int>();
        var currNode = head;
        while(currNode != null){
            rev.Push(currNode.val);
            currNode = currNode.next;
        }
        currNode = head;
        len = rev.Count;
        while(cntr <= len/2){
            maxSum = Math.Max(maxSum,(currNode.val + rev.Pop()));
            currNode = currNode.next;
            cntr++;
        }
        return maxSum;
    }
}