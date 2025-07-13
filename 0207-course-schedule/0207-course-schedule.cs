public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var adjList = new Dictionary<int,List<int>>();
        for(int i = 0; i<numCourses; i++){
            adjList[i] = new List<int>();
        }
        foreach(var prereq in prerequisites){
            adjList[prereq[0]].Add(prereq[1]);
        }

        var visited = new HashSet<int>();

        bool dfs(int crs){
            if(visited.Contains(crs))
                return false;
            if(adjList[crs].Count == 0)
                return true;
            visited.Add(crs);
            foreach(int num in adjList[crs]){
                if(!dfs(num))
                    return false;
            }
            visited.Remove(crs);
            adjList[crs].Clear();
            return true;
        }

        for(int i = 0; i < numCourses; i++){
            if(!dfs(i))
                return false;
        }
        return true;
    }
}