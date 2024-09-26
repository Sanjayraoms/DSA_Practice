public class Solution {
    public int MissingNumber(int[] nums) {
        HashSet<int> distnums = new HashSet<int>(nums);
        for(int i = 0; i<=nums.Length;i++){
            if(!nums.Contains(i))
                return i;
        }
        return 0;
    }
}