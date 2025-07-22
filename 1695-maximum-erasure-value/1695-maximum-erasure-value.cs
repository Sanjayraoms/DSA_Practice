public class Solution {
    public int MaximumUniqueSubarray(int[] nums) {
        int maxScore = 0;
        int currScore = 0;

        int l = 0;
        var distinct = new HashSet<int>();
        for(int r = 0; r < nums.Length; r++){
            while(!distinct.Add(nums[r])){
                currScore -= nums[l];
                distinct.Remove(nums[l++]);
            }
            currScore += nums[r];
            maxScore = Math.Max(maxScore,currScore);
        }
        return maxScore;
    }
}