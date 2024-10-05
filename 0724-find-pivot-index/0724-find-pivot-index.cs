public class Solution {
    public int PivotIndex(int[] nums) {
        if(nums.Length == 1)
            return 0;
        int[] prefixSum = new int[nums.Length];
        int[] suffixSum = new int[nums.Length];

        prefixSum[0] = nums[0];
        for(int i=1; i < nums.Length; i++){
            prefixSum[i] = nums[i] + prefixSum[i-1];
        }

        suffixSum[suffixSum.Length - 1] = nums[nums.Length - 1];
        for(int i =nums.Length-2; i >=0; i--){
            suffixSum[i] = nums[i] + suffixSum[i+1];
        }

        for(int i= 0; i<nums.Length; i++){
            if(i == 0){
                if(suffixSum[i+1] == 0){
                    return i;
                }
            }else if(i == nums.Length-1){
                if(prefixSum[i-1] == 0){
                    return i;
                }
            }else if(prefixSum[i-1] == suffixSum[i+1])
                return i;
        }
        return -1;
    }
}