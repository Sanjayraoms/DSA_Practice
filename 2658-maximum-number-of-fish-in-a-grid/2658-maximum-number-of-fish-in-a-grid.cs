public class Solution {
    public int FindMaxFish(int[][] grid) {
        int ROWS = grid.Length;
        int COLS = grid[0].Length;

        int DFS(int r, int c){
            var fish = 0;
            if(r < 0 || c < 0 || r == ROWS || c == COLS || grid[r][c] == 0)
                return 0;
            fish = grid[r][c];
            grid[r][c] = 0;
            var neigbors = new int[][]{new int[]{r+1,c},
                                       new int[]{r-1,c},
                                       new int[]{r,c+1},
                                       new int[]{r,c-1}};
            foreach(var nb in neigbors){
                fish += DFS(nb[0],nb[1]);
            }
            return fish;
        }

        
        int res = 0;
        for(int i = 0; i < ROWS; i++){
            for(int j = 0; j < COLS; j++){
                if(grid[i][j] > 0){
                    res = Math.Max(res,DFS(i,j));
                }
            }
        }
        return res;
    }
}