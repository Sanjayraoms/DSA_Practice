public class Solution {
    public int NumberOfSubstrings(string s) {
        int l = 0;
        var map = new int[3];
        int res = 0;

        for(int i = 0; i < s.Length; i++ ){
            map[s[i] - 'a']++;

            while(map[0] > 0 && map[1] > 0 && map[2] > 0){
                res += s.Length - i;
                map[s[l] - 'a']--;
                l++;
            }
        }
        return res;
    }
}