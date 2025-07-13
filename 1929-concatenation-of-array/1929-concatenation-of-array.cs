public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var res = new int[2*nums.Length];
        for(int i = 0; i < res.Length; i++){
            res[i] = nums[i%nums.Length];
        }
        return res;
    }
}