public class Solution {
    public int[] MaxSubsequence(int[] nums, int k) {
        PriorityQueue<(int val,int index),(int val,int index)> pq = new();
        for(int i = 0; i < nums.Length; i++){
            pq.Enqueue((nums[i],i), (-nums[i],i));
        }
        PriorityQueue<int,int> pqIndx = new();
        int[] res = new int[k];
        while(k-- > 0){
            var p = pq.Dequeue();
            pqIndx.Enqueue(p.val,p.index);
        }
        int indx=0;
        while(pqIndx.Count > 0){
            res[indx++] = pqIndx.Dequeue();
        }
        return res;
    }
}