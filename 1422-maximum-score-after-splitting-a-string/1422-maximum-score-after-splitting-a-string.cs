public class Solution {
    public int MaxScore(string s) {
        int ones = 0;
        int zeroes = 0;
        int ans = 0;

        for(int i = 0; i < s.Length; i++){
            if(s[i] == '1')
                ones++;
        }
        for(int i = 0; i < s.Length - 1; i++){
            if(s[i] == '1'){
                ones--;
            }else
                zeroes++;
            ans = Math.Max(ans, zeroes + ones);
        }
        return ans;
    }
}