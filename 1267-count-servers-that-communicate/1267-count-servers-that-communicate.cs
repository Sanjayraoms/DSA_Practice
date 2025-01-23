public class Solution {
    public int CountServers(int[][] grid) {
        int r = grid.Length;
        int c = grid[0].Length;
        int totalServers = 0;

        int[] rows = new int[r];
        int[] cols = new int[c];

        for(int i = 0; i < r; i++){
            for(int j = 0; j < c; j++){
                if(grid[i][j] == 1){
                    rows[i]++;
                    cols[j]++;
                }
            }
        }

        for(int i = 0; i < r; i++){
            for(int j = 0; j < c; j++){
                if(grid[i][j] == 1 && Math.Max(rows[i], cols[j]) > 1){
                    totalServers++;
                }
            }
        }
        return totalServers;

    }
}