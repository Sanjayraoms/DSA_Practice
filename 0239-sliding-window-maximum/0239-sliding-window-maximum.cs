public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var res = new int[nums.Length -k + 1];
        var pq = new PriorityQueue<(int val,int indx),int>();
        int idx = 0;

        for(int j = 0; j < nums.Length; j++){
            pq.Enqueue((nums[j],j), -nums[j]);
            if(j >= k-1){
                while(pq.Peek().indx <= j-k){
                    pq.Dequeue();
                }
                res[idx++] = pq.Peek().val;
            }
        }
        return res;
    }
}