public class Solution {
    public int MinimumPushes(string word) {
        Dictionary<char,int> charfreq = new Dictionary<char,int>();
        Dictionary<char,int> keymaps = new Dictionary<char,int>();
        int keyStrokes = 1;
        int keyctr = 0;
        int totalStrokes = 0;

        foreach(char item in word){
            if(!charfreq.ContainsKey(item))
               charfreq[item] = 1;
            else
               charfreq[item]++;
        }
        var keyValuePairs = charfreq.OrderByDescending(key=>key.Value).ToList();

        foreach(KeyValuePair<char,int> item in keyValuePairs){
            if(keyctr == 8){
                keyStrokes++;
                keyctr = 0;
            }
            if(!keymaps.ContainsKey(item.Key)){
                keymaps[item.Key] = keyStrokes;
                keyctr++;
            }
        }

        foreach(char item in word)
            totalStrokes += keymaps[item];
        
        return totalStrokes;
    }
}