public class Solution {
    public int NumTilePossibilities(string tiles) {
        var freq = new Dictionary<char,int>();
        foreach(char c in tiles){
            if(freq.ContainsKey(c))
                freq[c]++;
            else
                freq[c] = 1;
        }

        int backtrack(){
            var res = 0;

            foreach(char c in freq.Keys){
                if(freq[c] > 0){
                    freq[c]--;
                    res += 1;
                    res += backtrack();
                    freq[c]++;
                }
            }
            return res;
        }
        return backtrack();
    }
}