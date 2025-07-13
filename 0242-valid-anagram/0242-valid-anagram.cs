public class Solution {
    public bool IsAnagram(string s, string t) {
        var map = new int[26];
        foreach(char c in s){
            map[c-'a']++;
        }
        foreach(char c in t){
            map[c-'a']--;
        }
        foreach(int val in map){
            if(val != 0)
                return false;
        }
        return true;
    }
}