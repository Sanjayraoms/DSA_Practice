public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int res = int.MaxValue;
        int l = 0;
        int sum = 0;

        for(int r = 0; r < nums.Length; r++){
            sum += nums[r];
            if(sum > target){
                while(sum > target){
                    res = Math.Min(res, r-l+1);
                    sum -= nums[l];
                    l++;
                }
            }
            if(sum == target)
                res = Math.Min(res, r-l+1);
        }
        return res == int.MaxValue ? 0 : res ;
    }
}