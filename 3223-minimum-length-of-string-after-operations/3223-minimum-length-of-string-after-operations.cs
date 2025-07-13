public class Solution {
    public int MinimumLength(string s) {
        if(s.Length < 3)
            return s.Length;
        int res = 0;
        int[] map = new int[26];
        for(int i = 0; i < s.Length; i++){
            map[s[i] - 'a']++;
            if(map[s[i] - 'a'] == 3)
                map[s[i] - 'a'] -= 2;
        }
        foreach(int freq in map){
            res += freq;
        }
        return res;
    }
}