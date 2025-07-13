public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var set = new HashSet<char>();
        var max = 0;
        var sb =  new StringBuilder("");

        for(int i = 0; i < s.Length; i++){
            if(!set.Add(s[i])){
                var indx = 0;
                while(indx < sb.Length){
                    if(sb[indx] == s[i]){
                        sb.Remove(0,++indx);
                        break;
                    }
                    set.Remove(sb[indx]);
                    indx++;
                }
            }
            set.Add(s[i]);
            sb.Append(s[i]);
            max = Math.Max(max, set.Count);
        }
        return max;
    }
}