public class Solution {
    public int MinOperations(int[] nums, int k) {
        Array.Sort(nums);
        if(nums[0] < k)
            return -1;
        HashSet<int> set = new HashSet<int>(nums);
        if(set.Contains(k))
            return set.Count - 1;
        return set.Count;
    }
}