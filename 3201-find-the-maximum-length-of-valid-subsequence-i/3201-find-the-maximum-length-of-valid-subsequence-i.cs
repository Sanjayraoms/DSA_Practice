public class Solution {
    public int MaximumLength(int[] nums) {
        int even = 0, odd = 0, alternate = 0;
        var parity = (nums[0] & 1);

        foreach(var num in nums){
            if((num & 1) == 1)
                odd++;
            else
                even++;
            if((num & 1) == parity){
                alternate++;
                parity = 1 - parity;
            }
        }
        return Math.Max(alternate,Math.Max(even,odd));
    }
}