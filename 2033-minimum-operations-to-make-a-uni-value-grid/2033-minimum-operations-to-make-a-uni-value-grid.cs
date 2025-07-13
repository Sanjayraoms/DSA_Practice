public class Solution {
    public int MinOperations(int[][] grid, int x) {
        int m = grid.Length;
        int n = grid[0].Length;

        var newArr = new int[m+n];
        var indx = 0;
        var total = 0;
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] % x != grid[0][0] % x)
                    return -1;
                newArr[indx++] = grid[i][j];
                total += grid[i][j];
            }
        }

        Array.Sort(newArr);
        int res = int.MaxValue;
        int prefix = 0;
        for(int k = 0; k < newArr.Length; k++){
            var cost_left = (newArr[k] * k) - prefix;
            var cost_right = total - prefix - (newArr[k] * (newArr.Length - k));
            int operations = (cost_left + cost_right) / x;
            res = Math.Min(res,operations);
            prefix += newArr[k];
        }
        return res;
    }
}