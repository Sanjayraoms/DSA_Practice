public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        int res = 0;

        foreach(int num in set){
            if(!set.Contains(num-1)){
                var length = 1;
                while(set.Contains(num+length)){
                    length++;
                }
                res = Math.Max(res,length);
            }
        }
        return res;
    }
}