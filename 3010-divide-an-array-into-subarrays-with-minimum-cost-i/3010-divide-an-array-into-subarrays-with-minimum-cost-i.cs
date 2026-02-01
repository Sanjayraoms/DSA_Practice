public class Solution {
    public int MinimumCost(int[] nums) {
        int res = 0;
        res+= nums[0];
        int[] newArr = nums[1..];
        Array.Sort(newArr);
        return res + newArr[0] + newArr[1];
    }
}