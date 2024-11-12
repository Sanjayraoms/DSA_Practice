public class Solution {
    public int[] MaximumBeauty(int[][] items, int[] queries) {
        Array.Sort(items,(a,b)=>a[0]-b[0]);
        int[] res = new int[queries.Length];
        int[][] querieswithindices = new int[queries.Length][];
        for(int i = 0; i < queries.Length; i++){
            querieswithindices[i] = new int[2];
            querieswithindices[i][0] = queries[i];
            querieswithindices[i][1] = i;
        }
        Array.Sort(querieswithindices,(a,b)=>a[0]-b[0]);

        int max_bea = 0;
        int p = 0;
        for(int j = 0; j < queries.Length; j++){
            while(p < items.Length && items[p][0] <= querieswithindices[j][0]){
                max_bea = Math.Max(max_bea,items[p][1]);
                p++;
            }
            res[querieswithindices[j][1]] = max_bea;
        }
        return res;
    }
}