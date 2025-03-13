public class Solution {
    public int MinZeroArray(int[] nums, int[][] queries) {
        int k = 0, sum = 0;
        var diffArr = new int[nums.Length + 1];

        for(int i = 0; i < nums.Length; i++){
            while(sum+diffArr[i] < nums[i]){
                k++;
                if(k > queries.Length)
                    return -1;
                var left = queries[k-1][0];
                var right = queries[k-1][1];
                var val = queries[k-1][2];

                if(right >= i){
                    diffArr[Math.Max(i,left)] += val;
                    diffArr[right+1] -= val;
                }
            }
            sum += diffArr[i];
        }
        return k;
    }
}