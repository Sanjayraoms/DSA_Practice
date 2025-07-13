public class Solution {
    public bool IsZeroArray(int[] nums, int[][] queries)
        {
            var line = new int[nums.Length+1];
            foreach(var q in queries){
                line[q[0]] += 1;
                line[q[1]+1] -= 1;
            }
            for(int i = 1; i < line.Length; i++){
                line[i] += line[i-1];
            }

            for(int i = 0; i < nums.Length; i++){
                if(nums[i] > line[i])
                    return false;
            }
            return true;
        }
}