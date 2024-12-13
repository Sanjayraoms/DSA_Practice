public class Solution {
    public long FindScore(int[] nums) {
        int len = nums.Length;
        long res = 0;
        PriorityQueue<int,(int,int)> pq = new PriorityQueue<int,(int,int)>();
        int[] idxMarked = new int[len];
        for(int i = 0; i< len; i++){
            pq.Enqueue(i,(nums[i],i));
        }
        while(pq.Count > 0){
            var dq = pq.Dequeue();
            if(idxMarked[dq] == 0){
                idxMarked[dq] = 1;
                res += nums[dq];
                if(dq - 1 >= 0)
                    idxMarked[dq-1] = 1;
                if(dq + 1 < len)
                    idxMarked[dq+1] = 1;
            }
        }
        return res;
    }
}