public class Solution {
    public int LongestNiceSubarray(int[] nums) {
        int xorSum = 0;
        int currSum = 0;
        int maxCount = 0;
        int l = 0, r= 0;

        while(r < nums.Length){
            currSum += nums[r];
            xorSum = xorSum ^ nums[r];
            while(xorSum != currSum){
                currSum -= nums[l];
                xorSum = xorSum ^ nums[l];
                l++;
            }
            maxCount = Math.Max(maxCount,r-l+1);
            r++;
        }
        return maxCount;
    }
}