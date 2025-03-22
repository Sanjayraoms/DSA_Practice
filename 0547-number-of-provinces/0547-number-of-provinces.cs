public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        int findParent(int n,ref int[] par){
            var res = n;
            while(res != par[res]){
                par[res] = par[par[res]];
                res = par[res];
            }
            return res;
        }
        int Union(int n1, int n2, ref int[] rank, ref int[] par){
            var p1 = findParent(n1, ref par);
            var p2 = findParent(n2, ref par);

            if(p1 == p2)
                return 0;
            if(rank[p1] > rank[p2]){
                par[p2] = p1;
                rank[p1]++;
            }else{
                par[p1] = p2;
                rank[p2]++; 
            }
            return 1;
        }

        int m = isConnected.Length;
        int n = isConnected[0].Length;
        var parent = new int[isConnected.Length];
        for(int i = 0; i < parent.Length; i++)
            parent[i] = i;
        var rank = new int[isConnected.Length];
        var res = m;
        for(int i = 0; i < m ; i++){
            for(int j = 0; j < n; j++){
                if(isConnected[i][j] == 1){
                    res -= Union(i,j,ref rank, ref parent);
                }
            }
        }

        return res;
    }
}