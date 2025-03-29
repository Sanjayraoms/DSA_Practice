public class Solution {
    public int ReverseDegree(string s) {
        int res = 0;
        for(int i = 0; i < s.Length; i++){
            var curr = (i+1) * Math.Abs(s[i] - 'z' - 1); 
            res += curr;
        }
        return res;
    }
}