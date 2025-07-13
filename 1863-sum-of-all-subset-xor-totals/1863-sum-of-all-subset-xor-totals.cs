public class Solution {
    public int SubsetXORSum(int[] nums) {
        int dfs(int i, int total){
            if(i == nums.Length)
                return total;
            return dfs(i+1, total ^ nums[i]) + dfs(i+1,total);
        }
        return dfs(0,0);
    }
}