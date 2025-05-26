public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int wrtindx = 0;
        for(int readindx = 0; readindx < nums.Length; readindx++){
            if(nums[readindx] != val){
                nums[wrtindx++] = nums[readindx];
            }
        }
        return wrtindx;
    }
}