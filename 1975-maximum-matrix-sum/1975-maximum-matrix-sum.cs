public class Solution {
    public long MaxMatrixSum(int[][] matrix) {
        long res = 0;
        int neg_cnt = 0;
        int mat_min = int.MaxValue;
        foreach(int[] arr in matrix){
            foreach(int val in arr){
                res += Math.Abs(val);
                if(val < 0)
                    neg_cnt++;
                mat_min = Math.Min(mat_min,Math.Abs(val));
            }
        }
        if(neg_cnt % 2 == 1)
            res -= (2 * mat_min);
        return res;
    }
}