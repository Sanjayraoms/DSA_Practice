public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string,IList<string>>();
        foreach(string str in strs){
            var count = new int[26];
            foreach(char c in str){
                count[c-'a']++;
            }
            var key = string.Join(",",count);
            if(!res.ContainsKey(key)){
                res[key] = new List<string>();
            }
            res[key].Add(str);
        }
        return res.Values.ToList<IList<string>>();
    }
}