public class Solution {
    public int CountDays(int days, int[][] meetings) {
        Array.Sort(meetings,(a,b) => a[0].CompareTo(b[0]));
        int prev_end = 0;
        foreach(var meet in meetings){
            var start = Math.Max(meet[0],prev_end+1);
            var end = meet[1];
            days -= Math.Max(end-start+1,0);
            prev_end = Math.Max(prev_end,end);
        }
        return days;
    }
}