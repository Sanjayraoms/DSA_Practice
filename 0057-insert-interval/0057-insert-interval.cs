public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        var res = new List<int[]>();

        for(int i = 0; i < intervals.Length; i++){
            if(intervals[i][1] < newInterval[0])
                res.Add(intervals[i]);
            else if(newInterval[1] < intervals[i][0]){
                res.Add(newInterval);
                res.AddRange(intervals.Skip(i));
                return res.ToArray();
            }
            else{
                var swap = new int[]{Math.Min(intervals[i][0],newInterval[0]),
                                     Math.Max(intervals[i][1],newInterval[1])};
                newInterval = swap;
            }
        }
        res.Add(newInterval);
        return res.ToArray();
    }
}