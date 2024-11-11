public class Solution {
    public int MaxIncreasingSubarrays(IList<int> nums)
        {
            int prev = 0;
            int curr = 1;
            int ans = 0;

            for(int i = 1; i < nums.Count;i++){
                if(nums[i] > nums[i-1]){
                    curr++;
                }else{
                    prev = curr;
                    curr = 1;
                }
                ans = Math.Max(ans,Math.Max(curr/2,Math.Min(prev,curr)));
            }
            return ans;
        }
}