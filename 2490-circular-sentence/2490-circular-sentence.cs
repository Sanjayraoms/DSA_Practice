public class Solution {
    public bool IsCircularSentence(string sentence) {
        string[] s = sentence.Split(' ');
        for(int i = 0; i < s.Length - 1; i++){
            var first = s[i];
            var next = s[i+1];
            if(first[first.Length - 1] != next[0]) return false;
        }
        return sentence[0] == sentence[sentence.Length - 1];
    }
}