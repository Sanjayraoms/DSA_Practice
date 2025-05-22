public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        var odr = new int[26];
        for(int i = 0; i < order.Length; i++){
            odr[order[i] - 'a'] = i;
        }
        
        for(int m = 0; m < words.Length - 1; m++){
            var word1 = words[m];
            var word2 = words[m+1];

            for(int n = 0; n < word1.Length; n++){
                if(n == word2.Length)
                    return false;

                if(word1[n] != word2[n]){
                    if(odr[word1[n] - 'a'] > odr[word2[n] - 'a'])
                        return false;
                    break;
                }
            }
        }
        return true;
    }
}