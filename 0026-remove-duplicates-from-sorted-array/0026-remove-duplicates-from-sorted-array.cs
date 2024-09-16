public class Solution {
    public int RemoveDuplicates(int[] nums)
        {
            int k = 0;
            int j = 1;
            int prev = nums[k];
            while (j < nums.Length)
            {
                if (nums[k] != nums[j])
                {
                    if (nums[j] != prev)
                    {
                        k++;
                        nums[k] = nums[j];
                    }
                    j++;
                    prev = nums[k];
                }
                else
                {
                    j++;
                }
            }
            return k+1;
        }
}