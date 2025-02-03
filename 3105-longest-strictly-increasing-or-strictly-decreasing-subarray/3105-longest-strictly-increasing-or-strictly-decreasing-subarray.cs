public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        int inc = 1;
        int dec = 1;
        int currInc = 1;
        int currDec = 1;

        for(int i = 1; i < nums.Length; i++){
            if(nums[i] > nums[i-1]){
                currInc++;
                inc = Math.Max(inc,currInc);
                currDec = 1;
            }else if(nums[i] < nums[i-1]){
                currDec++;
                dec = Math.Max(dec,currDec);
                currInc = 1;
            }else{
                currDec = 1;
                currInc = 1;
            }
        }

        return Math.Max(inc,dec);
    }
}