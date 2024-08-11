public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length == 0)
          return true;
        if(s.Length > t.Length)
           return false;
        int i = 0;
        int j = 0;
        while(i < s.Length && j < t.Length){
            if(s[i] == t[j]){
                i++;
                j++;
                if(i == s.Length)
                   return true;
            }else
               j++;
        }
        return false;
    }
}