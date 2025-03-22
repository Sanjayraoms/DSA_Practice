public class Solution {
    public int CountCompleteComponents(int n, int[][] edges) {
        var ufs = new UnionFind(n);
        var map = new Dictionary<int,int>();
        foreach(var edge in edges){
            ufs.UnionBySize(edge[0],edge[1]);
        }
        foreach(var edge in edges){
            var root = ufs.Find(edge[0]);
            if(map.ContainsKey(root))
                map[root]++;
            else
                map[root] = 1;
        }
        int res = 0;
        for(int vertex = 0; vertex < n; vertex++){
            if(ufs.Find(vertex) == vertex){
                var nodes = ufs.size[vertex];
                var expectededges = (nodes*(nodes-1))/2;
                map.TryGetValue(vertex, out int val);
                if(val == expectededges)
                    res++;
            }
        }
        return res;
    }
}

public class UnionFind{
    int[] parent;
    public int[] size;
    public UnionFind(int n){
        parent = new int[n];
        size = new int[n];
        Array.Fill(size,1);
        Array.Fill(parent, -1);
    }

    public int Find(int n){
        if(parent[n] == -1)
            return n;
        return parent[n] = Find(parent[n]);
    }

    public void UnionBySize(int n1, int n2){
        var p1 = Find(n1);
        var p2 = Find(n2);
        if(p1 == p2)
            return;;
        if(size[p1] > size[p2]){
            parent[p2] = p1;
            size[p1] += size[p2];
        }else{
            parent[p1] = p2;
            size[p2] += size[p1];
        }
    }
}