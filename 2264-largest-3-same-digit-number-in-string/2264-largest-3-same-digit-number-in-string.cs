public class Solution {
    public string LargestGoodInteger(string num) {
        int res = -1;
        int cnt = 0; 
        char prev = ' ';
        foreach(char c in num){
            if(c == prev)
                cnt++;
            if(cnt == 2){
                var curr = (int)char.GetNumericValue(prev);
                res = Math.Max(res,curr);
                cnt = 0;
            }
            prev = c;
        }
        return res == -1 ? "" : $"{res}{res}{res}";
    }
}