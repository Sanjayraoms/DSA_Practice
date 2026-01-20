public class Solution {
    public int[] MinBitwiseArray(IList<int> nums) {
        var ans = new int[nums.Count];

        for(int i = 0; i < nums.Count; i++){
            int og = nums[i];
            int cd = -1;
            for(int j = 1; j < og; j++){
                if((j | (j+1)) == og){
                    cd = j;
                    break;
                }
            }
            ans[i] = cd;
        }
        return ans;
    }
}