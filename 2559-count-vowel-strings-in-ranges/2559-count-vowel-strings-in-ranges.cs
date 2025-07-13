public class Solution {
    public int[] VowelStrings(string[] words, int[][] queries) {
        int[] prefixVow = new int[words.Length];
        int[] res = new int[queries.Length];
        int currCnt = 0;
        for(int i = 0; i < words.Length; i++){
            var len = words[i].Length - 1;
            if(IsVowel(words[i][0]) && IsVowel(words[i][len])){
                currCnt++;
            }
            prefixVow[i] = currCnt;
        }
        for(int i = 0; i < queries.Length; i++){
            var r = queries[i][1];
            var l = queries[i][0];
            res[i] = prefixVow[r] - (l == 0?0:prefixVow[l-1]);
        }
        return res;
    }
    private bool IsVowel(char c){
        if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'){
            return true;
        }
        return false;
    }
}