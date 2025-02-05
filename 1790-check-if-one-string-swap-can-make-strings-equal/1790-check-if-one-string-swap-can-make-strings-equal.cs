public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        int[] freq = new int[26];
        foreach(char c in s1){
            freq[c-'a']++;
        }
        foreach(char c in s2){
            freq[c-'a']--;
        }
        foreach(int f in freq){
            if(f != 0)
                return false;
        }
        int mistake = 0;
        for(int i = 0; i < s1.Length; i++){
            if(s1[i] != s2[i])
                mistake++;
        }
        return mistake <= 2;
    }
}