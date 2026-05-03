public class Solution {
    public int MaxRotateFunction(int[] nums) {
        int numSum = 0;
        int maxSum = int.MinValue;
        int f = 0;

        for(int i = 0; i < nums.Length; i++){
            numSum += nums[i];
            f += nums[i] * i;
        }
        maxSum = Math.Max(maxSum,f);

        for(int i = nums.Length-1; i > 0; i--){
            f = f + numSum - (nums.Length*nums[i]);
            maxSum = Math.Max(maxSum,f);
        }
        return maxSum;
    }
    // Formula fnext = fprev + numSum(Every element is incremented by itself) - len*last 
    //(last element becomes 0 after rotating)
}