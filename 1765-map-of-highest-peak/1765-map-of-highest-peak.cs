public class Solution {
    public int[][] HighestPeak(int[][] isWater) {
        int m = isWater.Length;
        int n = isWater[0].Length;

        var res = new int[m][];
        var q = new Queue<int[]>();
        for(int i = 0; i < m; i++){
            res[i] = new int[n];
            Array.Fill(res[i],-1);
            for(int j = 0; j < n; j++){
                if(isWater[i][j] == 1){
                    res[i][j] = 0;
                    q.Enqueue(new int[]{i,j});
                }
            }
        }

        while(q.Count > 0){
            var pop = q.Dequeue();
            var r = pop[0];
            var c = pop[1];
            var h = res[r][c];

            var neighbors = new int[][]{new int[]{r+1,c},
                                        new int[]{r-1,c},
                                        new int[]{r,c+1},
                                        new int[]{r,c-1}};
            foreach(int[] nb in neighbors){
                if(nb[0] < 0 || nb[1] < 0 || nb[0] == m || nb[1] == n || res[nb[0]][nb[1]] != -1)
                    continue;
                res[nb[0]][nb[1]] = h+1;
                q.Enqueue(new int[]{nb[0],nb[1]});
            }
        }

        return res;
    }
}