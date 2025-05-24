public class Solution {
    public int NumIslands(char[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        int res = 0;

        void dfs(int p, int q){
            if(p < 0 || p >= m || q < 0 || q >= n || grid[p][q] == '0')
                return;
            grid[p][q] = '0';
            dfs(p-1,q);
            dfs(p+1,q);
            dfs(p,q-1);
            dfs(p,q+1);
        }

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == '1'){
                    res++;
                    dfs(i,j);
                }
            }
        }

        return res;
    }
}