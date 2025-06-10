public class Solution {
    public int MaxDifference(string s) {
        var freq = new int[26];
        foreach(char c in s){
            freq[c-'a']++;
        }
        int maxOdd = 0;
        int minEven = Int16.MaxValue;
        for(int i = 0; i < freq.Length; i++){
            if(freq[i] != 0){
                if(freq[i] % 2 == 1){
                    maxOdd = Math.Max(maxOdd, freq[i]);
                }else{
                    minEven = Math.Min(minEven,freq[i]);
                }
            }
        }
        return maxOdd - minEven;
    }
}