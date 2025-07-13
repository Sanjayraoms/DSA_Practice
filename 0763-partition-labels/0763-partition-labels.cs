public class Solution {
    public IList<int> PartitionLabels(string s) {
        var res = new List<int>();
        var map = new int[26];
        var tempSet = new HashSet<char>();

        foreach(char c in s){
            map[c-'a']++;
        }
        var currcnt = 1;
        char val;
        foreach(char c in s){
            map[c-'a']--;
            if(map[c-'a'] == 0){
                if(tempSet.TryGetValue(c, out val))
                    tempSet.Remove(val);
            }else
                tempSet.Add(c);
            if(map[c-'a'] == 0 && tempSet.Count == 0){
                res.Add(currcnt);
                currcnt = 0;
            }
            currcnt++;
        }

        return res;
    }
}