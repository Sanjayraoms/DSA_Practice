public class Solution {
    public bool CanConstruct(string s, int k) {
        if(k > s.Length)
            return false;
        int oddCounts = 0;
        Dictionary<char,int> charCounts = new Dictionary<char,int>();
        foreach(char c in s){
            if(charCounts.ContainsKey(c))
                charCounts[c]++;
            else
                charCounts[c] = 1;
        }
        foreach(int val in charCounts.Values){
            if(val%2 == 1){
                oddCounts++;
                if(oddCounts > k)
                    return false;
            }
        }
        return true;
    }
}