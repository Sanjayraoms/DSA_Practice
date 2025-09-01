public class Solution {
    public double MaxAverageRatio(int[][] classes, int extraStudents) {
        var pq = new PriorityQueue<int[],double>();
        double avg = 0;
        double res = 0;
        foreach(var cls in classes){
            avg = profit(cls[0],cls[1]);
            pq.Enqueue(cls,avg);
        }
        while(extraStudents-- > 0){
            var dq = pq.Dequeue();
            dq[0]++;
            dq[1]++;
            avg = profit(dq[0],dq[1]);
            pq.Enqueue(dq,avg);
        }
        while(pq.Count > 0){
            var dq = pq.Dequeue();
            avg = (double)dq[0]/dq[1];
            res += avg;
        }
        return res/classes.Length;
    }
    public double profit(int i,int j){
        var oldavg = (double)i++/j++;
        var newavg = (double)i/j;
        return oldavg - newavg;
    }
}