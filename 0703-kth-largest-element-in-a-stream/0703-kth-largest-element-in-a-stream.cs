public class KthLargest {
    PriorityQueue<int,int> pq = new();
    int Kth;

    public KthLargest(int k, int[] nums) {
        Kth = k;
        foreach(int num in nums){
            pq.Enqueue(num,num);
            if(pq.Count > k){
                pq.Dequeue();
            }
        }
    }
    
    public int Add(int val) {
        pq.Enqueue(val,val);
        if(pq.Count > Kth){
            pq.Dequeue();
        }
        return pq.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */