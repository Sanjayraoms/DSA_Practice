public class Solution {
    public bool CanConstruct(string s, int k) {
        if(k > s.Length)
            return false;
        int oddCounts = 0;
        int[] dict = new int[26];
        foreach(char c in s){
            dict[c-'a']++;
        }
        foreach(int i in dict){
            if(i%2 == 1)
                oddCounts++;
            if(oddCounts > k)
                return false;
        }
        return true;
    }
}