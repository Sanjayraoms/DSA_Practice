public class Solution {
    public int[] FindXSum(int[] nums, int k, int x) {
        var res = new List<int>();
        var freq = new Dictionary<int,int>();
        for(int i = 0; i < k; i++){
            if(!freq.ContainsKey(nums[i]))
                freq[nums[i]] = 0;
            freq[nums[i]]++;
        }
        res.Add(ComputeXSum(freq,x));
        for(int i = k; i < nums.Length; i++){
            int outNum = nums[i-k];
            int inNum = nums[i];

            freq[outNum]--;
            if(freq[outNum] == 0)
                freq.Remove(outNum);
            if(!freq.ContainsKey(inNum))
                freq[inNum]=0;
            freq[inNum]++;
            res.Add(ComputeXSum(freq,x));
        }
        return res.ToArray();
    }

    private int ComputeXSum(Dictionary<int,int> freq, int x){
        int sum = 0;
        var pq = new PriorityQueue<int,(int frqPriority,int valPriority)>();
        foreach(int key in freq.Keys){
            pq.Enqueue(key, (-freq[key],-key));
        }
        while(x--> 0 && pq.Count > 0){
            var dq = pq.Dequeue();
            sum += dq*freq[dq];
        }
        return sum;
    }
}