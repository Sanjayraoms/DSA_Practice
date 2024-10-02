public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        Dictionary<int,int> rankVals = new Dictionary<int,int>();
        int[] sorted = new int[arr.Length];
        Array.Copy(arr,sorted,arr.Length);
        Array.Sort(sorted);
        int rank = 0;
        for(int i = 0; i < sorted.Length; i++){
            if(!rankVals.ContainsKey(sorted[i])){
                rank++;
                rankVals[sorted[i]] = rank;
            }
        }
        for(int i = 0; i< arr.Length; i++){
            arr[i] = rankVals[arr[i]];
        }
        return arr;
    }
}