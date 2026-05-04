public class Solution {
    public int[][] Transpose(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        var res = new int[n][];

        for(int i = 0; i < m ; i++){
            for(int j = 0; j < n; j++){
                if(i == 0)
                    res[j] = new int[m];
                res[j][i] = matrix[i][j];
            }
        }
        return res;
    }
}