public class Solution {
    public bool CloseStrings(string word1, string word2) {
        if(word1.Length != word2.Length)
           return false;
        Dictionary<char,int> freq = new Dictionary<char,int>();
        Dictionary<char,int> freq2 = new Dictionary<char,int>();
        Dictionary<int,int> freqVal = new Dictionary<int,int>();
        foreach(char c in word1){
            if(freq.ContainsKey(c))
               freq[c]++;
            else
               freq[c] = 1;
        }
        foreach(char c in word2){
            if(freq2.ContainsKey(c))
               freq2[c]++;
            else
               freq2[c] = 1;
        }

        foreach(char key in freq.Keys){
            if(!freq2.ContainsKey(key))
               return false;
        }
        foreach(var val in freq.Values){
            if(freqVal.ContainsKey(val))
               freqVal[val]++;
            else
               freqVal[val] = 1;
        }
        foreach(var val in freq2.Values){
            if(freqVal.ContainsKey(val)){
                freqVal[val]--;
                if(freqVal[val] == 0)
                   freqVal.Remove(val);
            }else
                return false;
        }
        return true;
    }
}