public class Solution {
    public int MaxAbsoluteSum(int[] nums) {
        int minPrefixSum = 0;
        int maxPrefixSum = 0;
        int prefixSum = 0;

        foreach(int num in nums){
            prefixSum += num;

            minPrefixSum = Math.Min(minPrefixSum,prefixSum);
            maxPrefixSum = Math.Max(maxPrefixSum,prefixSum);
        }
        return Math.Abs(maxPrefixSum - minPrefixSum);
    }
}