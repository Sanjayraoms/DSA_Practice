public class Solution {
    public int MaximumCount(int[] nums) {
        int negCtr = 0;
        int posCtr = 0;

        foreach(int num in nums){
            if(num < 0)
                negCtr++;
            else if(num > 0)
                posCtr++;
        }
        return Math.Max(posCtr,negCtr);
    }
}