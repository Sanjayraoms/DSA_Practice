public class Solution {
    public int LargestMagicSquare(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;

        //Prefix sum of rows
        int[][] rowSum = new int[m][];
        for(int i = 0; i < m; ++i){
            rowSum[i] = new int[n];
            rowSum[i][0] = grid[i][0];
            for(int j = 1; j < n; j++){
                rowSum[i][j] = rowSum[i][j-1] + grid[i][j];
            }
        }

        //Prefix sum of columns
        int[][] colSum = new int [m][];
        for (int i = 0; i < m; ++i) {
            colSum[i] = new int[n];
        }
        for (int j = 0; j < n; ++j) {
            colSum[0][j] = grid[0][j];
            for (int i = 1; i < m; ++i) {
                colSum[i][j] = colSum[i - 1][j] + grid[i][j];
            }
        }

        //Loop through all the edges from the largest to smallest
        for(int edge = Math.Min(m,n); edge >= 2 ; --edge){
            for(int i = 0; i+edge <= m; ++i){
                for(int j = 0; j+edge <= n; ++j){
                    int checkSum = rowSum[i][j + edge - 1] - (j > 0 ? rowSum[i][j-1] : 0);
                    bool check = true;

                    //Check each row
                    for(int k = i+1; k < i+edge; ++k){
                        if(rowSum[k][j+edge-1] - (j > 0 ? rowSum[k][j-1] : 0) != checkSum){
                            check =false;
                            break;
                        }
                    }
                    if(!check) continue;

                    //Check each column
                    for(int l = j; l < j+ edge; ++l){
                        if(colSum[i+edge-1][l] - (i > 0 ? colSum[i-1][l] : 0) != checkSum){
                            check = false;
                            break;
                        }
                    }

                    if(!check) continue;

                    //Check Diagonal
                    int d1 = 0, d2 = 0;
                    for(int o = 0; o < edge; ++o){
                        d1 += grid[i+o][j+o];
                        d2 += grid[i+o][j+edge-1-o];
                    }
                    if(d1 == checkSum && d2 == checkSum)
                        return edge;
                }
            }
        }
        return 1;
    }
}