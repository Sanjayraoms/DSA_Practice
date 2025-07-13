public class Solution {
    public int WaysToSplitArray(int[] nums) {
        long[] prefixSum = new long[nums.Length];
        long total = 0;
        int res = 0;
        prefixSum[0] = nums[0];
        total += nums[0];
        for(int i = 1; i < nums.Length; i++){
            prefixSum[i] = nums[i] + prefixSum[i-1];
            total += nums[i];
        }
        for(int i = 0 ; i < nums.Length - 1; i++){
            var nextSum = total - prefixSum[i];
            if(prefixSum[i] >= nextSum)
                res++;
        }
        return res;
    }
}