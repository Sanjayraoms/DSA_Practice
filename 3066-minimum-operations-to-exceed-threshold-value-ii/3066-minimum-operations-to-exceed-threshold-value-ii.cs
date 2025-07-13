public class Solution {
    public int MinOperations(int[] nums, int k) {
        var pq = new PriorityQueue<long,long>();
        int ops = 0;

        foreach(int num in nums){
            pq.Enqueue(num,num);
        }

        while(pq.Count >= 2){
            if(pq.Peek() >= k)
                break;
            ops++;
            var min1 = pq.Dequeue();
            var min2 = pq.Dequeue();
            var calc = min1*2 + min2;
            pq.Enqueue(calc,calc);
        }

        return ops;
    }
}