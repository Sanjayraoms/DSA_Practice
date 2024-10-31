public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int largest = 0;
        PriorityQueue<int,int> maxHeap = new PriorityQueue<int,int>(Comparer<int>.Create((a,b) => b-a));
        foreach(int num in nums){
            maxHeap.Enqueue(num,num);
        }
        while(k > 0){
            largest = maxHeap.Dequeue();
            k--;
        }
        return largest;
    }
}