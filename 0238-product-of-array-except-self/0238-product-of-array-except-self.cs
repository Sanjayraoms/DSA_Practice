public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] prefixProd = new int[n];
        int[] suffixProd = new int[n];
        int[] res = new int[n];

        prefixProd[0] = nums[0];
        for(int i = 1; i < n; i++){
            prefixProd[i] = prefixProd[i-1] * nums[i];
        }
        
        suffixProd[n-1] = nums[n-1];
        for(int i = n-2; i>=0; i--){
            suffixProd[i] = suffixProd[i+1] * nums[i];
        }

        for(int i = 0 ; i < n; i++){
            if(i == 0)
               res[i] = suffixProd[i];
            else if(i == n-1)
               res[i] = prefixProd[i-1];
            else
               res[i] = prefixProd[i-1] * suffixProd[i+1];
        }
        return res;
    }
}