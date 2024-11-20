public class Solution {
    public long MaximumSubarraySum(int[] nums, int k)
        {
            int start = 0;
            int end = 0;
            Dictionary<int, int> checkDup = new Dictionary<int, int>();
            long max = 0;
            long sum = 0;
            while (start <= nums.Length - k)
            {
                end = start + k - 1;
                for (int i = start; i <= end; i++)
                {
                    if (checkDup.ContainsKey(nums[i]))
                    {
                        checkDup.Clear();
                        max = 0;
                        if (nums[i] == nums[i - 1]) start = i;
                        else start++;
                        break;
                    }
                    else
                    {
                        checkDup[nums[i]] = 1;
                        max += nums[i];
                    }
                }
                if (max > 0)
                    break;
            }
            if (max == 0)
                return 0;
            sum = max;
            end++;
            for (int i = end; i < nums.Length; i++)
            {
                checkDup[nums[start]]--;
                if (checkDup[nums[start]] == 0)
                    checkDup.Remove(nums[start]);
                sum -= nums[start];
                sum += nums[i];
                if (!checkDup.ContainsKey(nums[i]))
                {
                    checkDup[nums[i]] = 1;
                    if(checkDup.Count == k)
                        max = Math.Max(max, sum);
                }
                else
                {
                    checkDup[nums[i]]++;
                }                
                start++;
            }
            return max;
        }
}