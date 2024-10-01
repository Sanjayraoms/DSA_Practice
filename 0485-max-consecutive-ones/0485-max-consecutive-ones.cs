public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxCons = 0;
        int currMax = 0;
        foreach(int num in nums){
            if(num == 1){
                currMax++;
            }else{
                maxCons = Math.Max(maxCons,currMax);
                currMax = 0;
            }
        }
        maxCons = Math.Max(maxCons,currMax);
        return maxCons;
    }
}