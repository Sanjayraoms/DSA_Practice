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
    public int[][] SpiralMatrix(int m, int n, ListNode head) {
        int[][] spiral = new int[m][];
        for(int i = 0; i< m; i++){
            spiral[i] = new int[n];
            for(int j = 0 ; j< n;j++){
                spiral[i][j] = -1;
            }
        }
        int dir = 0;
        int top = 0;
        int bottom = m-1;
        int left = 0;
        int right = n-1;
        var currNode = head;
        while(currNode != null &&(top<=bottom && left <=right)){
            switch(dir){
                case 0:
                   for(int k = top; k <= right && currNode!=null ; k++){
                      spiral[top][k] = currNode.val;
                      currNode = currNode.next;
                   }
                   top++;
                   dir++;
                   break;
                case 1:
                   for(int l = top; l <= bottom && currNode!=null ; l++){
                      spiral[l][right] = currNode.val;
                      currNode = currNode.next;
                   }
                   right--;
                   dir++;
                   break;
                case 2:
                   for(int o = right; o >= left && currNode!=null ; o--){
                      spiral[bottom][o] = currNode.val;
                      currNode = currNode.next;
                   }
                   bottom--;
                   dir++;
                   break;
                case 3:
                   for(int p = bottom; p >= top && currNode!=null ; p--){
                      spiral[p][left] = currNode.val;
                      currNode = currNode.next;
                   }
                   left++;
                   dir = 0;
                   break;
                default :
                   break;
            }
        }
        return spiral;
    }
}