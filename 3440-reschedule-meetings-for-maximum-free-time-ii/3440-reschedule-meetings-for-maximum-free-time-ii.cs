public class Solution {
    public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime) {
        var n = startTime.Length;

        var gaps = new int[n+1];
        gaps[0] = startTime[0];
        gaps[n] = eventTime - endTime[n-1];

        for(int i = 1; i < n; i++){
            gaps[i] = startTime[i] - endTime[i-1];
        }

        var largestRight = new int[n+1];
        for(int i = n-1; i>= 0; i--){
            largestRight[i] = Math.Max(largestRight[i+1],gaps[i+1]);
        }

        int ans = 0, largestLeft = 0;

        for(int i = 0; i< n; i++){
            var duration = endTime[i] - startTime[i];

            if(largestLeft >= duration || largestRight[i+1] >= duration)
                ans = Math.Max(ans, gaps[i]+gaps[i+1]+duration);

            ans = Math.Max(ans,gaps[i]+gaps[i+1]);

            largestLeft = Math.Max(largestLeft,gaps[i]);
        }
        return ans;
    }
}