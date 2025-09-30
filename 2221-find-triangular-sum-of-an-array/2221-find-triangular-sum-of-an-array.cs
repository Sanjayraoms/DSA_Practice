public class Solution {
    public int TriangularSum(int[] nums) {
        if(nums.Length == 1)
            return nums[0];
        var currArr = new List<int>();
        for(int i = 0; i < nums.Length - 1; i++){
            var currNum = (nums[i] + nums[i+1]) % 10;
            currArr.Add(currNum);
        }
        return TriangularSum(currArr.ToArray());
    }
}