public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int exists = 0;
        int[] res = new int[A.Length];
        for(int i = 0; i < A.Length; i++){
            if(dict.ContainsKey(A[i])){
                dict[A[i]]++;
                exists++;
            }else{
                dict[A[i]] = 1;
            }
            if(dict.ContainsKey(B[i])){
                dict[B[i]]++;
                exists++;
            }else{
                dict[B[i]] = 1;
            }
            res[i] = exists;
        }
        return res;
    }
}