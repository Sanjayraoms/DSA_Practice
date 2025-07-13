public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int len = nums.Length;
        int[] prefixProd = new int[len];
        int[] suffixProd = new int[len];

        prefixProd[0] = nums[0];
        for(int i = 1; i < nums.Length; i++){
            prefixProd[i] = prefixProd[i-1]*nums[i];
        }
        suffixProd[len-1] = nums[len-1];

        for(int i = len-2; i >= 0; i--){
            suffixProd[i] = suffixProd[i+1]*nums[i];
        }

        for(int i = 0; i < nums.Length; i++){
            var left = (i-1) < 0 ? 1 :  prefixProd[i-1];
            var right = (i+1) >= len ? 1 : suffixProd[i+1];
            nums[i] = left * right;
        }
        return nums;
    }
}