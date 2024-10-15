public class Solution {
    public long MinimumSteps(string s) {
        long minSteps = 0;
        int i = 0;
        int j = s.Length - 1;
        while(i<j){
            if(s[i]=='1' && s[j]=='0'){
                minSteps = minSteps + (j - i);
                i++;
                j--;
            }else if(s[i]=='0'){
                i++;
            }else{
                j--;
            }
        }
        return minSteps;
    }
}