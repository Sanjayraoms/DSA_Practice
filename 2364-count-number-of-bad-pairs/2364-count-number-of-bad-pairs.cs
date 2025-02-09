public class Solution {
    public long CountBadPairs(int[] nums) {
        long good_pairs = 0;
        long total_pairs = 0;
        var map = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++){
            total_pairs += i;
            var k = nums[i] - i;
            if(map.ContainsKey(k)){
                good_pairs += map[k];
                map[k]++;
            }else{
                map[k] = 1;
            }
        }
        return total_pairs - good_pairs;
    }
}