public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        var pq = new PriorityQueue<int,(int num,int idx)>();
        for(int i = 0; i < nums.Length; i++){
            pq.Enqueue(i,(nums[i],i));
        }
        while(k-- > 0){
            var dq = pq.Dequeue();
            nums[dq] = nums[dq] * multiplier;
            pq.Enqueue(dq,(nums[dq],dq));
        }
        return nums;
    }
}