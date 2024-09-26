public class Solution {
    public int MissingNumber(int[] nums) {
        // HashSet<int> distnums = new HashSet<int>(nums);
        // for(int i = 0; i<=nums.Length;i++){
        //     if(!nums.Contains(i))
        //         return i;
        // }
        // return 0;
        Array.Sort(nums);
        for(int i = 0; i< nums.Length;i++){
            if(i!=nums[i])
                return i;
        }
        return nums.Length;
    }
}