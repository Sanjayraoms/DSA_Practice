public class Solution {
    public bool Check(int[] nums) {
        int minIndx = 0;
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] < nums[i-1])
                minIndx = i;
        }
        int iterations = nums.Length - 1;
        for(int i = minIndx+1;iterations > 0;i++){
            var indx = i % nums.Length;
            if(nums[indx] < nums[(indx==0) ? nums.Length - 1 : indx - 1]){
                return false;
            }
            iterations--;
        }
        return true;
    }
}