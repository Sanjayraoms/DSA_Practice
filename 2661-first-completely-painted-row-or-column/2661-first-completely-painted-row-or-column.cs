public class Solution {
    public int FirstCompleteIndex(int[] arr, int[][] mat) {
        int m = mat.Length, n = mat[0].Length;
        var matValPos = new int[arr.Length+1][];

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                matValPos[mat[i][j]] = new int[]{i,j};
            }
        }

        int[] row_cnt = new int[m];
        int[] col_cnt = new int[n];
        for(int i = 0; i < arr.Length; i++){
            var paint = matValPos[arr[i]];
            var r = paint[0];
            var c = paint[1];
            row_cnt[r]++;
            col_cnt[c]++;
            if(row_cnt[r] == n || col_cnt[c] == m)
                return i;
        }
        return 0;
    }
}