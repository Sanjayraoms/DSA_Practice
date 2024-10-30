public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i = 0;
        int j = nums.Length - 1;
        while(i <= j){
            if(nums[i] != val)
                i++;
            else if(nums[j] != val){
                nums[i++] = nums[j--]; 
            }else
                j--;
        }
        return i;
    }
}