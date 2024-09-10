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
    public ListNode[] SplitListToParts(ListNode head, int k) {
        var currNode = head;
        int len = 0;
        List<ListNode> splitList = new List<ListNode>();
        while(currNode != null){
            len++;
            currNode = currNode.next;
        }
        int small = len/k;
        int big = small+1;
        int bigNodes = len % k;
        int smallNodes = k - bigNodes;
        currNode = head;
        var newHead = head;
        var tail = head;
        while(bigNodes > 0){
            newHead = currNode;
            tail = newHead;
            for(int i = 1; i< big; i++ ){
                if(tail == null)
                   break;
                tail = tail.next;
            }
            if(tail != null){
                currNode = tail.next != null ? tail.next : null;
                tail.next = null; 
            }else{
                currNode = tail;
            }
            splitList.Add(newHead);
            bigNodes--;
        }
        while(smallNodes > 0){
            newHead = currNode;
            tail = newHead;
            for(int i = 1; i< small; i++ ){
                if(tail == null)
                   break;
                tail = tail.next;
            }
            if(tail != null){
                currNode = tail.next != null ? tail.next : null;
                tail.next = null; 
            }else{
                currNode = tail;
            }
            splitList.Add(newHead);
            smallNodes--;
        }
        return splitList.ToArray();
    }
}