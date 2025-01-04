public class Solution {
    public int CountPalindromicSubsequence(string s) {
        HashSet<string> set = new HashSet<string>();
        HashSet<char> set2 = new HashSet<char>();
        int i = 0;
        int j = s.Length-1;
        StringBuilder sb = new StringBuilder("");
        while(j-i >= 2){
            if(s[i] == s[j]){
                if(set2.Contains(s[i])){
                    j--;
                    continue;
                }
                else
                    set2.Add(s[i]);
                for(int k = i+1; k < j; k++){
                    sb.Clear();
                    sb.Append($"{s[i]}{s[k]}{s[j]}");
                    if(!set.Contains(sb.ToString())){
                        set.Add(sb.ToString());
                    }
                }
                j--;
            }else
                j--;
        }
        i = 0;
        j = s.Length-1;
        while(j-i >= 2){
            if(s[i] == s[j]){
                if(set2.Contains(s[i])){
                    i++;
                    continue;
                }
                else
                    set2.Add(s[i]);
                for(int k = i+1; k < j; k++){
                    sb.Clear();
                    sb.Append($"{s[i]}{s[k]}{s[j]}");
                    if(!set.Contains(sb.ToString())){
                        set.Add(sb.ToString());
                    }
                }
                i++;
            }else
                i++;
        }
        return set.Count;
    }
}