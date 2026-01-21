public class Solution {
    public int[] MinBitwiseArray(IList<int> nums) {
        var res = new int[nums.Count];

        for(int i =0; i < nums.Count; i++){
            int x = nums[i];
            int r = -1;
            int d = 1;
            while((x&d) != 0){
                r = x - d;
                d<<=1;
            } 
            res[i] = r;
        }
        return res;
    }
}