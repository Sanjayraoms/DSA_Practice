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
    public ListNode ModifiedList(int[] nums, ListNode head) {
        if(nums.Length ==0)
           return head;
        HashSet<int> map = new HashSet<int>(nums);
        ListNode currNode = head;
        ListNode prevNode = null;
        while(currNode != null){
            if(map.Contains(currNode.val)){
                if(prevNode == null)
                    head = currNode.next;
                else
                    prevNode.next = currNode.next;
            }else
                prevNode = currNode;
            currNode = currNode.next;
        }
        return head;
    }
}