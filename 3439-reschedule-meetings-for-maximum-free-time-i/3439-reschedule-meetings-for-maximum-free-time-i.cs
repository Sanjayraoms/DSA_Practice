public class Solution {
    public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime) {
        int windowSum = 0;
        int[] gaps = new int[startTime.Length+1];
        gaps[0] = startTime[0];
        for(int i = 1; i < startTime.Length; i++){
            gaps[i] = startTime[i] - endTime[i-1];
        }
        gaps[^1] = eventTime - endTime[^1];
        
        for(int i = 0; i <= k;i++){
            windowSum += gaps[i];
        }
        int freeTime = windowSum;
        for(int i = k+1; i < gaps.Length; i++){
            windowSum += gaps[i] - gaps[i-(k+1)];
            freeTime = Math.Max(windowSum,freeTime);
        }
        return freeTime;
    }
}