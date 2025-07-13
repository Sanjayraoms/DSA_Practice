public class Solution {
    public int PrefixCount(string[] words, string pref) {
        int res = 0;
        foreach(string word in words){
            if(word.StartsWith(pref))
                res++;
        }
        return res;
    }
}