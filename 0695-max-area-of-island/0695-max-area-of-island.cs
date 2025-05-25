public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int ROWS = grid.Length;
        int COLS = grid[0].Length;

        int dfs(int p,int q){
            if(p < 0 || p >= ROWS || q < 0 || q >= COLS || grid[p][q] == 0)
                return 0;
            grid[p][q] = 0;
            return 1+dfs(p-1,q)+dfs(p+1,q)+dfs(p,q-1)+dfs(p,q+1);
        }
        int max = 0;
        for(int i = 0; i < ROWS; i++){
            for(int j = 0; j < COLS; j++){
                if(grid[i][j] == 1){
                   max = Math.Max(max,dfs(i,j));
                }
            }
        }
        return max;
    }
}