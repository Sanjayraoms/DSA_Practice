public class Solution {
    public long MaximumSubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> checkDup = new Dictionary<int, int>();
            long max = 0;
            long currSum = 0;
            for(int i = 0; i < k ; i++){
                currSum+=nums[i];
                if(checkDup.ContainsKey(nums[i]))
                    checkDup[nums[i]]++;
                else
                    checkDup[nums[i]] = 1;
            }
            if(checkDup.Count == k)
                max = currSum;
            for(int i = 1; i <= nums.Length - k;i++){
                checkDup[nums[i-1]]--;
                currSum -= nums[i-1];
                if(checkDup[nums[i-1]] == 0)
                    checkDup.Remove(nums[i-1]);
                if(checkDup.ContainsKey(nums[i+k-1])){
                    checkDup[nums[i+k-1]]++;
                }else{
                    checkDup[nums[i+k-1]] = 1;
                }
                currSum += nums[i+k-1];
                if(checkDup.Count == k)
                    max = Math.Max(max,currSum);
            }
            return max;
        }
}