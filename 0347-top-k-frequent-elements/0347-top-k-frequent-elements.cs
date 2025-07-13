public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int[] res = new int[k];
        var freq = new Dictionary<int,int>();
        foreach(int num in nums){
            if(freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }
        var pq = new PriorityQueue<int,int>();
        foreach(int key in freq.Keys){
            pq.Enqueue(key,-freq[key]);
        }

        for(int i = 0; i < k; i++){
            res[i] = pq.Dequeue();
        }
        return res;
    }
}