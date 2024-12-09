public class Solution {
    public bool[] IsArraySpecial(int[] nums, int[][] queries) {
        int len = nums.Length;
        int[] prefixSum = new int[len];
        prefixSum[0] = 1;
        bool[] result = new bool[queries.Length];
        for(int i = 1;i < len; i++){
            if((nums[i] & 1) != (nums[i-1] & 1)){
                prefixSum[i] = prefixSum[i-1] + 1;
            }else
                prefixSum[i] = 1;
        }
        for(int j = 0; j < queries.Length; j++){
            if((queries[j][1]-queries[j][0] + 1) <= prefixSum[queries[j][1]]){
                result[j] = true;
            }else
                result[j] = false;
        }
        return result;
    }
}