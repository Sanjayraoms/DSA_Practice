public class Solution {
    public bool HasIncreasingSubarrays(IList<int> nums, int k) {
        int prevInc = 0;
        int currInc = 1;
        for(int i = 1; i < nums.Count; i++){
            if(nums[i] > nums[i-1])
                currInc++;
            else{
                prevInc = currInc;
                currInc = 1;
            }
            if(currInc >= 2*k || (currInc >= k && prevInc >= k))
                return true;
        }
        return false;
    }
}