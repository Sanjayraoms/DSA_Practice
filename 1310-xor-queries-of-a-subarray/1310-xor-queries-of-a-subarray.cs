public class Solution {
    public int[] XorQueries(int[] arr, int[][] queries) {
        int[] res = new int[queries.Length];
        int indx = 0;
        bool first = true;
        foreach(int[] query in queries){
            res[indx] = arr[query[0]];
            for(int i=query[0]+1; i<= query[1];i++){
                res[indx] = res[indx] ^ arr[i];
            }
            indx++; 
        }
        return res;
    }
}