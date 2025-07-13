public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var adjList = new Dictionary<int,List<int>>();
        for(int i = 0; i < numCourses; i++){
            adjList[i] = new List<int>();
        }
        foreach(var preReq in prerequisites){
            adjList[preReq[0]].Add(preReq[1]);
        }
        var visited = new HashSet<int>();
        var res = new HashSet<int>();
        bool dfs(int crs){
            if(visited.Contains(crs))
                return false;
            if(res.Contains(crs)){
                return true;
            }
            visited.Add(crs);
            foreach(int ls in adjList[crs]){
                if(!dfs(ls))
                    return false;
            }
            visited.Remove(crs);
            res.Add(crs);
            return true;
        }
        for(int i = 0; i < numCourses; i++){
            if(!dfs(i))
                return [];
        }
        return res.ToArray();
    }
}