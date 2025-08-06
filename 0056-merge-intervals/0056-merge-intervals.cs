public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));
        var res = new LinkedList<int[]>();
        for(int i = 0; i < intervals.Length; i++){
            if(res.Count == 0 || res.Last.Value[1] < intervals[i][0]){
                res.AddLast(intervals[i]);
            }else{
                res.Last.Value[1] = Math.Max(res.Last.Value[1], intervals[i][1]);
            }
        }
        return res.ToArray();
    }
}