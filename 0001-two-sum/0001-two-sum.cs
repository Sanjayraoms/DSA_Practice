public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int[] res = new int[2];
        int diff = 0;
        for(int i = 0; i < nums.Length; i++){
            diff = target - (nums[i]);
            if(map.ContainsKey(diff))
               return new int[]{i,map[diff]};
            if(!map.ContainsKey(nums[i]))
               map[nums[i]] = i;
        }
        return res;
    }
}