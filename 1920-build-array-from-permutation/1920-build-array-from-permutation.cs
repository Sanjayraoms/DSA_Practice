public class Solution {
    public int[] BuildArray(int[] nums) {
        var res = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            res[i] = nums[nums[i]];
        }
        return res;
    }
}