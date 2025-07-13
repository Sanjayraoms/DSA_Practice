public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        int perimeter = 0;

        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 1){
                    perimeter += 4;

                    //check left
                    if(i > 0 && grid[i-1][j] == 1)
                        perimeter -= 1;
                    //check right
                    if(i < m-1 && grid[i+1][j] == 1)
                        perimeter -= 1;
                    //check top
                    if(j > 0 && grid[i][j-1] == 1)
                        perimeter -= 1;
                    //check bottom
                    if(j < n-1 && grid[i][j+1] ==1)
                        perimeter -= 1;
                }
            }
        }
        return perimeter;
    }
}