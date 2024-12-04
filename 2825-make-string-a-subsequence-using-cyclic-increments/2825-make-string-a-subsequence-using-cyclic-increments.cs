public class Solution {
    public bool CanMakeSubsequence(string str1, string str2) {
        if(str1.Length < str2.Length)
            return false;
        int i = 0;
        int j = 0;
        char nextChar;
        while(i < str1.Length && j < str2.Length){
            if(str1[i] == 'z')
                nextChar = 'a';
            else
                nextChar = (char)(((int)str1[i])+1);
            if(str1[i] == str2[j] || nextChar == str2[j]){
                j++;
            }
            i++;
        }
        return j == str2.Length;
    }
}