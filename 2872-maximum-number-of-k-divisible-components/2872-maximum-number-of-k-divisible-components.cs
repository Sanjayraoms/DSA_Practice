public class Solution {
    public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k) {
        if(edges.Length == 0)
            return 1;
        Dictionary<int,List<int>> adjList = new Dictionary<int,List<int>>();
        for(int i = 0; i < edges.Length; i++){
            var v1 = edges[i][0];
            var v2 = edges[i][1];
            if(!adjList.ContainsKey(v1)){
                adjList[v1] = new List<int>();
            }
            if(!adjList.ContainsKey(v2)){
                adjList[v2] = new List<int>();
            }
            adjList[v1].Add(v2);
            adjList[v2].Add(v1);
        }
        int res = 0;
        long total = 0;
        long dfs(int curr, int parent){
            total = values[curr];
            foreach(int val in adjList[curr]){
                if(val != parent)
                    total += dfs(val,curr);
            }
            if(total % k == 0)
                res++;
            return total;
        }
        dfs(0,-1);
        return res;
    }
}