public class Solution {
    public int MinOperations(int[] nums) {
        int firstZero = -1;
        int minOperation = 0;
        for(int i = 0; i< nums.Length; i++){
            if(nums[i] == 0){
                firstZero = i;
                break;
            }
        }
        if(firstZero == -1)
            return minOperation;
        
        for(int i = firstZero+2; i < nums.Length; i++){
            if(nums[i-2] == 0){
                nums[i-2] = nums[i-2] ^ 1;
                nums[i-1] = nums[i-1] ^ 1;
                nums[i] = nums[i] ^ 1;
                minOperation++;
            }
        }
        var sum = 0;
        foreach(int num in nums){
            sum += num;
        }
        if(sum == nums.Length)
            return minOperation;
        return -1;
    }
}