public class Solution {
    public int MaxVowels(string s, int k) {
        int maxVowels = 0;
        for(int i = 0; i < k; i++){
            if(s[i]=='a'||s[i]=='e'||s[i]=='i'||s[i]=='o'||s[i]=='u'){
                maxVowels++;
            }
        }
        if(maxVowels == k)
            return maxVowels;
        int tempMax = maxVowels;
        for(int j = k;j<s.Length; j++){
            if(s[j-k]=='a'||s[j-k]=='e'||s[j-k]=='i'||s[j-k]=='o'||s[j-k]=='u'){
                tempMax--;
            }
            if(s[j]=='a'||s[j]=='e'||s[j]=='i'||s[j]=='o'||s[j]=='u'){
                tempMax++;
            }
            maxVowels = Math.Max(maxVowels,tempMax);
            if(maxVowels == k)
                return k;
        }
        return maxVowels;
    }
}