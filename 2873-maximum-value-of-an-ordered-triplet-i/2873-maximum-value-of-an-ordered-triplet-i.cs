public class Solution {
    public long MaximumTripletValue(int[] nums) {
        long max_diff = 0;
        long max_left = 0;
        long max_val = 0;

        for(int i = 0; i < nums.Length; i++){
            max_val = Math.Max(max_val, max_diff * nums[i]);
            max_diff = Math.Max(max_diff, max_left - nums[i]);
            max_left = Math.Max(max_left,nums[i]);
        }
        return max_val;
    }
}