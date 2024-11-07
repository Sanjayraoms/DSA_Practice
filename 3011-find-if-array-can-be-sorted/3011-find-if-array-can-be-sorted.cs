public class Solution {
    public bool CanSortArray(int[] nums) {
        int prevMax = Int32.MinValue;
        int currMin = Int32.MaxValue;
        for(int i = 0; i < nums.Length - 1; i++ ){
            if(CountBits(nums[i]) == CountBits(nums[i+1])){
                currMin = Math.Min(currMin,Math.Min(nums[i],nums[i+1]));
                if(nums[i] > nums[i+1]){
                    (nums[i],nums[i+1]) = (nums[i+1],nums[i]);
                }
            }else if(currMin < prevMax){
                return false;
            }else{
                prevMax = nums[i];
                currMin = nums[i+1];
            }
        }
        return currMin > prevMax;
    }
    public int CountBits(int n){
        int count = 0;
        while(n > 0){
            count += n & 1;
            n >>= 1;
        }
        return count;
    }
}