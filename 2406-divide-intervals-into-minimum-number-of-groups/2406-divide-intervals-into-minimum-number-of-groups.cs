public class Solution {
    public int MinGroups(int[][] intervals) {
        int res = 0;
        int[] left = new int[intervals.Length];
        int[] right = new int[intervals.Length];
        for(int i = 0; i < intervals.Length; i++){
            left[i] = intervals[i][0];
            right[i] = intervals[i][1];
        }
        Array.Sort(left);
        Array.Sort(right);
        int m = 0;
        int n = 0;

        while(m < intervals.Length){
            if(left[m] <= right[n])
                m++;
            else
                n++;
            res = Math.Max(res,m-n);
        }
        return res;
    }
}