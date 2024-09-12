public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        HashSet<char> map = new HashSet<char>(allowed);
        int count = 0;
        foreach(string word in words){
            var check = new HashSet<char>(word);
            count++;
            foreach(char c in check){
                if(!map.Contains(c)){
                    count--;
                    break;
                }
            }
        }
        return count;
    }
}