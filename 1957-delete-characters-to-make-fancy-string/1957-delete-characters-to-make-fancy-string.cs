public class Solution {
    public string MakeFancyString(string s) {
        var res = new StringBuilder("");
        res.Append(s[0]);
        for(int i = 1; i < s.Length - 1; i++){
            if(s[i] != s[i-1] || s[i] != s[i+1])
                res.Append(s[i]);
        }
        if(s.Length > 1)
            res.Append(s[^1]);
        return res.ToString();
    }
}