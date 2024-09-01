public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n) {
        if(original.Length != m*n)
           return [];
        int[][] arr = new int[m][];
        for(int idx = 0; idx < m; idx++)
           arr[idx] = new int[n];
        int i = 0;
        int j = 0;
        foreach(int val in original){
            if(j == n){
                i++;
                j = 0;
            }
            arr[i][j] = val;
            j++;
        }
        return arr;
    }
}