public class Solution {
    public int[] MinimumCost(int n, int[][] edges, int[][] query) {
        var ufd = new UnionFind(n);

        foreach(var edge in edges){
            ufd.Union(edge[0],edge[1]);
        }

        var componentCost = new Dictionary<int,int>();
        foreach(var edge in edges){
            var root = ufd.Find(edge[0]);
            if(componentCost.ContainsKey(root))
                componentCost[root] &= edge[2];
            else
                componentCost[root] = edge[2];
        }

        var res = new List<int>();
        foreach(var q in query){
            var p1 = ufd.Find(q[0]);
            var p2 = ufd.Find(q[1]);

            if(p1 != p2)
                res.Add(-1);
            else
                res.Add(componentCost[p1]);
        }
        return res.ToArray();
    }
}

public class UnionFind{
    int[] parent;
    int[] size;
    public UnionFind(int n){
        parent = new int[n];
        size = new int[n];
        Array.Fill(parent,-1);
        Array.Fill(size,1);
    }

    public int Find(int node){
        if(parent[node] == -1){
            return node;
        }
        return Find(parent[node]);
    }

    public void Union(int n1, int n2){
        var p1 = Find(n1);
        var p2 = Find(n2);

        if(p1!=p2){
            if(size[p1] > size[p2]){
                parent[p2] = p1;
                size[p1] += size[p2];
            }else{
                parent[p1] = p2;
                size[p2] += size[p1];
            }
        }
    }
}