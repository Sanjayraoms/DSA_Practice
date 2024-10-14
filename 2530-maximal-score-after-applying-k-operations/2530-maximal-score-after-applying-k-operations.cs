public class Solution {
    public long MaxKelements(int[] nums, int k) {
        long res = 0;
        var maxHeapComparer = Comparer<int>.Create((x, y) => y-x);
        PriorityQueue<int,int> maxHeap = new(maxHeapComparer);
        foreach(int num in nums){
            maxHeap.Enqueue(num,num);
        }
        while(k!=0){
            var val = maxHeap.Dequeue();
            res = res + val;
            val = (val+2)/3;
            maxHeap.Enqueue(val,val);
            k--;
        }
        return res;
    }
}