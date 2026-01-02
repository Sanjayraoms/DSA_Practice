public class Solution {
    public int RepeatedNTimes(int[] nums) {
        var dict = new Dictionary<int,int>();
        foreach(int num in nums){
            if(dict.ContainsKey(num))
                return num;
            else
                dict[num] = 1;
        }
        return 1;
    }
}