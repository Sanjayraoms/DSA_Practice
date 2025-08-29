public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var set = new HashSet<char>();
        var max = 0;
        var l = 0;

        for(int i = 0; i < s.Length; i++){
            while(set.Contains(s[i])){
                set.Remove(s[l]);
                l++;
            }
            set.Add(s[i]);
            max = Math.Max(max, set.Count);
        }
        return max;
    }
}