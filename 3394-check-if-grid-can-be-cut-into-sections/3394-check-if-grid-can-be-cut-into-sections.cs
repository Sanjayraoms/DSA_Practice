public class Solution {
    public bool CheckValidCuts(int n, int[][] rectangles) {
        var x = new int[rectangles.Length][];
        var y = new int[rectangles.Length][];

        for(int i = 0; i < rectangles.Length; i++){
            x[i] = new int[]{rectangles[i][0], rectangles[i][2]};
            y[i] = new int[]{rectangles[i][1], rectangles[i][3]};
        }
        Array.Sort(x,(a,b) => a[0].CompareTo(b[0]));
        Array.Sort(y,(a,b) => a[0].CompareTo(b[0]));

        int nonOverLapping(int[][] intervals){
            var count = 0;
            var prev_end = -1;
            foreach(var interval in intervals){
                if(prev_end <= interval[0]){
                    count++;
                }
                prev_end = Math.Max(prev_end,interval[1]);
            }
            return count;
        }

        return Math.Max(nonOverLapping(x),nonOverLapping(y)) >= 3;
    }
}