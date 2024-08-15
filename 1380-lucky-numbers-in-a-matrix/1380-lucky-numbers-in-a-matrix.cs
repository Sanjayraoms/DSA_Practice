public class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) {
        List<int> luckyNumbers = new List<int>();
        int i = 0;
        int j = 0;
        int k,l;
        while(i < matrix.Length){
            k = i;
            l = j;
            while(j < matrix[0].Length){
                if(matrix[i][j] < matrix[k][l]){
                    k = i;
                    l = j;
                }
                j++;
            }
            j = 0;
            while(j < matrix.Length){
                if(matrix[j][l] > matrix[k][l])
                   break;
                j++;
                if(j == matrix.Length)
                   luckyNumbers.Add(matrix[k][l]);
            }
            j = 0;
            i++;
        }
        return luckyNumbers;
    }
}