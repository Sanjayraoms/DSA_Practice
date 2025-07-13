public class Solution {
    public IList<int> EventualSafeNodes(int[][] graph) {
        var safe = new Dictionary<int,bool>();
        var res = new List<int>();
        bool dfs(int i){
            if(safe.ContainsKey(i))
                return safe[i];
            safe[i] = false;
            foreach(int val in graph[i]){
                if(!dfs(val)){
                    return safe[i];
                }
            }
            safe[i] = true;
            return safe[i];
        }
        for(int i = 0; i< graph.Length; i++){
            if(dfs(i)){
                res.Add(i);
            }
        }
        return res;
    }
}