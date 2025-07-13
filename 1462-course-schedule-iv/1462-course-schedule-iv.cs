public class Solution {
    public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries) {
        var res = new List<bool>();
        var adjacencyList = new Dictionary<int,List<int>>();
        var prereqMap = new Dictionary<int,HashSet<int>>();

        //Building Adjacency list
        foreach(var preq in prerequisites){
            if(!adjacencyList.ContainsKey(preq[1]))
                adjacencyList[preq[1]] = new List<int>();
            adjacencyList[preq[1]].Add(preq[0]);
        }

        //Storing Prerequisites for each courses
        HashSet<int> dfs(int crs){
            if(!prereqMap.ContainsKey(crs)){
                prereqMap[crs] = new HashSet<int>();
                if (adjacencyList.ContainsKey(crs))
                {
                    foreach (var val in adjacencyList[crs])
                    {
                        prereqMap[crs].UnionWith(dfs(val));
                    } 
                }
                prereqMap[crs].Add(crs);
            }
            return prereqMap[crs];
        }

        for(int i = 0; i < numCourses;i++){
            dfs(i);
        }

        foreach(var query in queries){
            if(prereqMap[query[1]].Contains(query[0])){
                res.Add(true);
            }else
                res.Add(false);
        }

        return res;
    }
}