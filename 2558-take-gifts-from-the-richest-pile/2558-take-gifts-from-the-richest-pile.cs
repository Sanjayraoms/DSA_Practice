public class Solution {
    public long PickGifts(int[] gifts, int k) {
        PriorityQueue<int,int> q = new PriorityQueue<int,int>(Comparer<int>.Create((a,b) => b-a));
        foreach(int gift in gifts){
            q.Enqueue(gift,gift);
        }
        while(k > 0){
            var num = q.Dequeue();
            var sqrd = (int)Math.Sqrt(num);
            q.Enqueue(sqrd,sqrd);
            k--;
        }
        long res = 0;
        while(q.Count > 0){
            res += q.Dequeue();
        }
        return res;
    }
}