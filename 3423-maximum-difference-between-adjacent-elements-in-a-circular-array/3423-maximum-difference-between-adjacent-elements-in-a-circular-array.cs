public class Solution {
    public int MaxAdjacentDistance(int[] nums) {
        int res = -100;
        for(int i = 1; i < nums.Length;i++){
            var diff = Math.Abs(nums[i] - nums[i-1]);
            res = Math.Max(res,diff);
        }
        var circ = Math.Abs(nums[^1] - nums[0]);
        res = Math.Max(res,circ);
        return res;
    }
}