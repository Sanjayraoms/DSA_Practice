public class Solution {
    public string LongestPalindrome(string s) {
        if(s.Length == 1 || s.Length == 2)
            return s[0].ToString();
        String resStr = "";
        int maxLen = 0;
        int longStr = 0;
        int left,right;
        for(int i = 0; i < s.Length; i++){
            longStr = 0;
            left = i;
            right = i;
            while(left > 0 && right < s.Length && s[left] == s[right]){
                longStr = right - left + 1;
                left--;
                right++;
            }
            if(resStr.Length < longStr){
                resStr = s.Substring(left+1,s.Length - right);
            }

            longStr = 0;
            left = i;
            right = i+1;
            while(left > 0 && right < s.Length && s[left] == s[right]){
                longStr = right - left + 1;
                left--;
                right++;
            }
            if(resStr.Length < longStr){
                resStr = s.Substring(left+1,s.Length - right);
            }
        }
        return resStr;
    }
}