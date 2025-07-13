public class Solution {
    public int MajorityElement(int[] nums) {
        int vote = 1;
        int curr = nums[0];

        for(int i=1; i < nums.Length; i++){
            if(nums[i] == curr)
                vote++;
            else
                vote--;
            if(vote == 0){
                curr = nums[i];
                vote = 1;
            }
        }
        return curr;
    }
}