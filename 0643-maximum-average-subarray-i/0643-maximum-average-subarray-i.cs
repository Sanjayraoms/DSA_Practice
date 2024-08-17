public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        double MaxAverage;
        double Average;
        double sum = 0;
        for(int i = 0;i < k; i++){
            sum += nums[i];
        }
        MaxAverage = (double)(sum/k);
        for(int i = 0; i < nums.Length - k; i++){
            sum = sum - nums[i] + nums[i+k];
            Average = (double)(sum/k);
            MaxAverage = Math.Max(MaxAverage,Average);
        }
        return MaxAverage;
    }
}