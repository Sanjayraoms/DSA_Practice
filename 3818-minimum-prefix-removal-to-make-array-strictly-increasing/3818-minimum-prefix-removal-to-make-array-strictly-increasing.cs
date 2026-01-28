public class Solution {
    public int MinimumPrefixLength(int[] nums) {
        for(int i = nums.Length - 2; i >= 0; i--){
            if(nums[i] >= nums[i+1]){
                return i+1;
            }
        }
        return 0;
    }
}