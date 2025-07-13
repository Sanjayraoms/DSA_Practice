public class Solution {
    public string MinWindow(string s, string t) {
        var tFreq = new Dictionary<char,int>();
        foreach(char c in t){
            if(tFreq.ContainsKey(c))
                tFreq[c]++;
            else
                tFreq[c] = 1;
        }
        var sFreq = new Dictionary<char,int>();
        int l = 0;
        var res = "";
        var len = int.MaxValue;
        int need = tFreq.Count, have = 0;

        for(int r = 0; r < s.Length; r++){
            var key = s[r];
            if(sFreq.ContainsKey(key))
                sFreq[key]++;
            else
                sFreq[key] = 1;
            if(tFreq.ContainsKey(key) && sFreq[key] == tFreq[key])
                have++;
            
            while(need == have){
                if(r-l+1 < len){
                    res = s.Substring(l,r-l+1);
                    len = r-l+1;
                }
                key = s[l];
                sFreq[key]--;
                if(tFreq.ContainsKey(key) && sFreq[key] < tFreq[key])
                    have--;
                l++;
            }
        }
        return res;
    }
}