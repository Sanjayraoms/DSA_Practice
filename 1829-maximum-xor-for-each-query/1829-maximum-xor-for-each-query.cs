public class Solution {
    public int[] GetMaximumXor(int[] nums, int maximumBit) {
        int[] res = new int[nums.Length];
        int mask = (1 << maximumBit) - 1;
        int XORnum = 0;
        foreach(int num in nums){
            XORnum ^= num;
        }
        int j = 0;
        for(int i = nums.Length-1; i >= 0; i--){
            res[j] = XORnum ^ mask;
            XORnum ^= nums[i];
            j++;
        }
        return res;
    }
}