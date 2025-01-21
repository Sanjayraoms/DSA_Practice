public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var map = new Dictionary<int,int>();
        foreach(int num in nums){
            if(map.ContainsKey(num))
                return true;
            else
                map[num] = 1;
        }
        return false;
    }
}