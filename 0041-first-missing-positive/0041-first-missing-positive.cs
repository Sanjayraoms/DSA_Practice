public class Solution {
    public int FirstMissingPositive(int[] nums) {
        var set = new HashSet<int>();
        int max = 1;
        foreach(int num in nums){
            set.Add(num);
            max = Math.Max(max,num);
        }
        for(int i = 1; i < max; i++){
            if(!set.Contains(i))
                return i;
        }
        return ++max;
    }
}