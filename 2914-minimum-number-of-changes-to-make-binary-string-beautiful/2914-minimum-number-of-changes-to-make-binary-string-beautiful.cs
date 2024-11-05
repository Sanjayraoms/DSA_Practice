public class Solution {
    public int MinChanges(string s) {
        int minChngs = 0;
        for(int i = 0; i < s.Length - 1; i = i+2){
            if(s[i] != s[i+1])
                minChngs++;
        }
        return minChngs;
    }
}