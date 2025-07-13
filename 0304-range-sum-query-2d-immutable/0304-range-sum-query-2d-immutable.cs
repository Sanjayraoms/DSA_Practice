public class NumMatrix {
    int[][] sumMat;
    public NumMatrix(int[][] matrix) {
        int ROWS = matrix.Length;
        int COLS = matrix[0].Length;

        sumMat = new int[ROWS+1][];
        for(int i = 0; i < ROWS+1; i++){
            sumMat[i] = new int[COLS+1];
        }

        for(int m = 0; m < ROWS; m++){
            var prefix = 0;
            for(int n = 0; n < COLS; n++){
                prefix += matrix[m][n];
                var above = sumMat[m][n+1];
                sumMat[m+1][n+1] = prefix + above;
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        row1++;
        col1++;
        row2++;
        col2++;

        var bottomRight = sumMat[row2][col2];
        var above = sumMat[row1 - 1][col2];
        var left = sumMat[row2][col1-1];
        var topLeft = sumMat[row1-1][col1-1];
        return bottomRight - above - left + topLeft;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */