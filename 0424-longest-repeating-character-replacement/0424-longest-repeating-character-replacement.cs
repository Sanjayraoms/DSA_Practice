public class Solution {
    public int CharacterReplacement(string s, int k) {
        int l = 0;
        int res = 0;
        int maxfreq = 0;
        var freq = new Dictionary<char,int>();

        for(int r = 0; r < s.Length; r++){
            if(freq.ContainsKey(s[r]))
                freq[s[r]]++;
            else
                freq[s[r]] = 1;
            
            maxfreq = Math.Max(maxfreq, freq[s[r]]);
            //Verify if character replacement has exceeded the given k times
            //and adjust window accordingly
            while((r-l+1)-maxfreq > k){
                freq[s[l]]--;
                l++;
            }

            res = Math.Max(res, r - l +1);
        }
        return res;
    }
}