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
    public ListNode DeleteMiddle(ListNode head) {
        int totalNode = 0;
        int middleNode = 0;
        int pos = 0;
        var currentNode = head;
        var prevNode = head;
        while(currentNode != null){
            totalNode++;
            currentNode = currentNode.next;
        }
        if(totalNode == 1)
           return null;
        pos = (totalNode%2 == 0) ? 0 : 1;
        middleNode = (int)Math.Ceiling((decimal)totalNode/2);
        currentNode = head;
        while(currentNode != null){
            if(pos == middleNode){
                prevNode.next = currentNode.next;
                currentNode.next = null;
                break;
            }
            prevNode = currentNode;
            currentNode = currentNode.next;
            pos++;
        }
        return head;
    }
}