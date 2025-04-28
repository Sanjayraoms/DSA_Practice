public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int res = 0;
        int currSum = 0;
        var prefixMap = new Dictionary<int,int>();

        prefixMap[0] = 1;
        foreach(int num in nums){
            currSum += num;
            var diff = currSum - k;

            if(prefixMap.ContainsKey(diff))
                res += prefixMap[diff];
            
            if(prefixMap.ContainsKey(currSum))
                prefixMap[currSum]++;
            else
                prefixMap[currSum] = 1;
        }
        return res;
    }
}