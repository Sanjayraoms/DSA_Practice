public class Solution {
    public int[] ApplyOperations(int[] nums) {
        for(int m = 0; m < nums.Length - 1; m++){
            if(nums[m] == nums[m+1]){
                nums[m] = nums[m] * 2;
                nums[m+1] =0;
            }
        }
        int i = 0, j = 1;
        while(i < nums.Length && j < nums.Length){
            if(nums[i] == 0 && nums[j] != 0){
                (nums[i],nums[j]) = (nums[j],nums[i]);
                i++;
                j++;
            }else if(nums[i] == 0 && nums[j] == 0)
                j++;
            else{
                i++;
                j++;
            }
        }
        return nums;
    }
}