public class Solution {
    public int[] QueryResults(int limit, int[][] queries) {
        int[] res = new int[queries.Length];

        var set = new HashSet<int>();
        var map = new Dictionary<int,int>();
        for(int i = 0; i < queries.Length; i++){
            if(map.ContainsKey(queries[i][0])){
                set.Remove(map[queries[i][0]]);
                map[queries[i][0]] = queries[i][1];
                set.Add(queries[i][1]);
            }else{
                map[queries[i][0]] = queries[i][1];
                set.Add(queries[i][1]);
            }
            res[i] = set.Count;
        }

        return res;
    }
}