public class Solution {
    public bool IsValid(string word) {
        if(word.Length < 3)
            return false;
        var hasVowel = false;
        var hasConsonants = false;
        foreach(char c in word){
            if(char.IsLetter(c)){
                var ch = char.ToLower(c);
                if(ch == 'a' || ch == 'e' || ch == 'i' || ch =='o' || ch == 'u'){
                    hasVowel = true;
                }else
                    hasConsonants = true;
            }else if(!char.IsDigit(c)){
                return false;
            }
        }
        return hasVowel && hasConsonants;
    }
}