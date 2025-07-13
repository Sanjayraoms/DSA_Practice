public class Solution {
    public int MaxAscendingSum(int[] nums) {
        if(nums.Length == 1)
            return nums[0];
        int[] ascSums = new int[nums.Length];
        ascSums[0] = nums[0]; 
        int res = ascSums[0];
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] > nums[i-1]){
                ascSums[i] = ascSums[i-1] + nums[i];
            }else{
                ascSums[i] = nums[i];
            }
            res = Math.Max(res,ascSums[i]);
        }
        return res;
    }
}