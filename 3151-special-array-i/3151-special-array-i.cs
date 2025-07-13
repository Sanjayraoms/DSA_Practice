public class Solution {
    public bool IsArraySpecial(int[] nums) {
        if(nums.Length == 1)
            return true;
        bool isEven = (nums[0]%2 ==0) ? true : false;
        for(int i = 1; i < nums.Length; i++){
            if(isEven && nums[i] % 2 == 0){
                return false;
            }else if(!isEven && nums[i] % 2 == 1)
                return false;
            isEven = !isEven;
        }
        return true;
    }
}