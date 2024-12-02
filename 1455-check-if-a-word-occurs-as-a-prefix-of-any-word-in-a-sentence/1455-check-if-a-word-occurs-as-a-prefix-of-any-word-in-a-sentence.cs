public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) {
        string[] strArr = sentence.Split(" ");
        for(int i = 0;i < strArr.Length;i++){
            var currStr = strArr[i];
            if(currStr.IndexOf(searchWord) == 0)
                return i+1;
        }
        return -1;
    }
}