public class Solution {
    public bool CanPartition(int[] nums) {
        var totalSum = 0;
        foreach(int num in nums){
            totalSum += num;
        }
        if((totalSum & 1) == 1)
            return false;
        var targetSum = totalSum/2;
        var dp = new HashSet<int>();
        dp.Add(0);
        for(int i = nums.Length-1; i >=0; i--){
            var nextDp = new HashSet<int>();
            foreach(var n in dp){
                if(n+nums[i] == targetSum)
                    return true;
                nextDp.Add(n+nums[i]);
                nextDp.Add(n);
            }
            dp = nextDp;
        }
        return dp.Contains(targetSum);
    }
}