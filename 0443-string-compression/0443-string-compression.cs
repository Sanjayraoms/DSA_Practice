public class Solution {
    public int Compress(char[] chars) {
        int n = chars.Length, cntr = 0;
        int left = 0,right = 0,currposn = 0;

        while(right < n){
            cntr = 0;
            while(right < n && chars[left] == chars[right]){
                right++;
                cntr++;
            }
            chars[currposn] = chars[left];
            if(cntr > 1){
                foreach(var ch in cntr.ToString()){
                    chars[++currposn] = ch;
                }    
            }
            currposn++;

            left = right;
        }
        return currposn;
    }
}