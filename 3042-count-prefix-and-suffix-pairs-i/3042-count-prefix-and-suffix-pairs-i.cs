public class Solution {
    public int CountPrefixSuffixPairs(string[] words) {
        int ctr = 0;
        for(int i = 0; i < words.Length; i++){
            for(int j = i+1; j < words.Length; j++){
                if(words[j].IndexOf(words[i]) == 0 && 
                   words[j].LastIndexOf(words[i]) == words[j].Length - words[i].Length)
                   ctr++;
            }
        }
        return ctr;
    }
    //Implementing TRIE shortly
}